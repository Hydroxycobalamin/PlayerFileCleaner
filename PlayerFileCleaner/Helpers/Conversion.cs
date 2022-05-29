using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Newtonsoft.Json;

namespace PlayerFileCleaner.Helpers {
    public class Conversion {

        public static string ToUUID(string uuid) {
            return uuid.Insert(8, "-").Insert(13, "-").Insert(18, "-").Insert(23, "-");
        }
        public static bool TryV4(Dictionary<string, string> playerData, string uuid) {
            if (playerData == null) {
                return false;
            }
            if (!playerData.ContainsKey("id") && !playerData.ContainsKey("name")) {
                return false;
            }
            return true;
        }
        public static bool IsDuplicate(Dictionary<string, string> playerData, string fileExt, string filePath) {
            if (File.Exists(Path.GetDirectoryName(filePath) + "\\" + ToUUID(playerData["id"] + fileExt))) {
                return true;
            }
            return false;
        }
        public static async Task<string> GetV4(string playerName) {
            string content = "";
            using HttpClient client = new();
            // var response = await client.GetStringAsync("https://api.mojang.com/users/profiles/minecraft/" + playerName);

            var uri = new Uri("https://api.mojang.com/users/profiles/minecraft/" + playerName);
            var response = client.GetAsync(uri).Result;
            if (response != null) {
                if (response.IsSuccessStatusCode) {
                    content = await response.Content.ReadAsStringAsync();
                }
            }
            return content;
        }
    }
}