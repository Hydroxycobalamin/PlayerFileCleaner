using Newtonsoft.Json;
using PlayerFileCleaner.Models;

namespace PlayerFileCleaner.Helpers {
    internal class Cleaner {

        string file = "";
        string fileExt = "";
        string uuid = "";
        string worldName = "";
        Dictionary<string, string> playerNames = new();

        StatisticsObject stats = new();
        public void InitializeCleanup(Dictionary<string, string> playerNames, string[] advancementsFiles, string[] playerFiles, string outputPath, string worldName, bool cleanGeyser) {
            this.playerNames = playerNames;
            this.worldName = worldName;
            stats.uuidTotalFound = playerFiles.Length;
            foreach (var filePath in playerFiles) {
                CleanPlayerFile(outputPath, filePath, "playerdata", cleanGeyser);
            }
            stats.advancementUUIDTotalFound = advancementsFiles.Length;
            foreach (var filePath in advancementsFiles) {
                CleanPlayerFile(outputPath, filePath, "advancements", cleanGeyser);
            }
            stats.uuidTotalCleaned = stats.v3UUIDConverted + stats.unknownUUIDConverted;
            stats.advancementUUIDTotalCleaned = stats.advancementV3UUIDConverted + stats.advancementUnknownUUIDConverted;
            MessageBox.Show(stats.GetStatistic()
                + "\n\nLogfile can be found at: " + outputPath + "\\log.log");
            Logging.Write("Finished!");
            Logging.Write(stats.GetStatistic());
        }

        private void CleanPlayerFile(string outputPath, string filePath, string folderName, bool cleanGeyser) {
            file = Path.GetFileName(filePath);
            fileExt = Path.GetExtension(filePath);
            uuid = Path.GetFileNameWithoutExtension(filePath);
            if (!(playerNames.ContainsKey(uuid))) {
                Logging.Write("UUID: " + uuid + " doesn't match player file.");
                FileManager.MoveFile(filePath, outputPath + worldName + "\\" + folderName + "\\nomatch\\", file);
                stats.StatisticIncrement(7, folderName);
                return;
            }
            string type = uuid.Substring(14, 1);
            switch (type) {
                case "0":
                    if (cleanGeyser) {
                        FileManager.MoveFile(filePath, outputPath + worldName + "\\" + folderName + "\\V0\\", file);
                        stats.StatisticIncrement(5, folderName);
                    }
                    return;
                case "3": {
                        FileManager.CopyFile(filePath, outputPath + worldName + "\\" + folderName + "\\V3\\", file);
                        var playerData = JsonConvert.DeserializeObject<Dictionary<string, string>>(Conversion.GetV4(playerNames[uuid]).Result);
                        if (playerData == null) {
                            Logging.Write("Failed to convert playerdata for " + uuid);
                            File.Delete(filePath);
                            stats.StatisticIncrement(2, folderName);
                            return;
                        }
                        ConvertToV4(playerData, filePath, outputPath, folderName, type);
                        return;
                    }
                case "4":
                    return;
                default: {
                        FileManager.CopyFile(filePath, outputPath + worldName + "\\" + folderName + "\\undefined\\", file);
                        var playerData = JsonConvert.DeserializeObject<Dictionary<string, string>>(Conversion.GetV4(playerNames[uuid]).Result);
                        if (playerData == null) {
                            Logging.Write("Failed to convert playerdata for " + uuid);
                            File.Delete(filePath);
                            stats.StatisticIncrement(4, folderName);
                            return;
                        }
                        ConvertToV4(playerData, filePath, outputPath, folderName, type);
                        return;
                    }
            }
        }

        private void ConvertToV4(Dictionary<string, string> playerData, string filePath, string outputPath, string folderName, string type) {
            if (!Conversion.TryV4(playerData, uuid)) {
                return;
            }
            if (Conversion.IsDuplicate(playerData, fileExt, filePath)) {
                Logging.Write("[Duplicate] Found " + Conversion.ToUUID(playerData["id"]) + " in " + worldName + "\\" + folderName);
                FileManager.MoveFile(filePath, outputPath + worldName + "\\" + folderName + "\\duplicate\\" + playerData["name"] + "\\", file);
                stats.StatisticIncrement(6, folderName);
            } else {
                Logging.Write("[Converted] " + uuid + " to " + Conversion.ToUUID(playerData["id"]) + " in " + worldName + "\\" + folderName);
                FileManager.MoveFile(filePath, Path.GetDirectoryName(filePath) + "\\", Conversion.ToUUID(playerData["id"]) + fileExt);
                if (type == "3") {
                    stats.StatisticIncrement(1, folderName);
                } else {
                    stats.StatisticIncrement(3, folderName);
                }
            }
            return;
        }




    }
}