using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerFileCleaner.Models {
    internal class StatisticsObject {
        //Playerdata
        public int uuidTotalFound = 0;
        public int uuidTotalCleaned = 0;
        public int v3UUIDConverted = 0;
        public int v3UUIDFailed = 0;
        public int unknownUUIDConverted = 0;
        public int unknownUUIDFailed = 0;
        public int geyserCleaned = 0;
        public int duplicates = 0;
        public int noMatch = 0;
        //Advancements
        public int advancementUUIDTotalFound = 0;
        public int advancementUUIDTotalCleaned = 0;
        public int advancementV3UUIDConverted = 0;
        public int advancementV3UUIDFailed = 0;
        public int advancementUnknownUUIDConverted = 0;
        public int advancementUnknownUUIDFailed = 0;
        public int advancementGeyserCleaned = 0;
        public int advancementDuplicates = 0;
        public int advancementNoMatch = 0;

        public void StatisticIncrement(int stat, string type) {
            switch (stat) {
                case 1:
                    if (type == "playerdata") {
                        v3UUIDConverted++;
                    } else if (type == "advancements") {
                        advancementV3UUIDConverted++;
                    }
                    break;
                case 2:
                    if (type == "playerdata") {
                        v3UUIDFailed++;
                    } else if (type == "advancements") {
                        advancementV3UUIDFailed++;
                    }
                    break;
                case 3:
                    if (type == "playerdata") {
                        unknownUUIDConverted++;
                    } else if (type == "advancements") {
                        advancementUnknownUUIDConverted++;
                    }
                    break;
                case 4:
                    if (type == "playerdata") {
                        unknownUUIDFailed++;
                    } else if (type == "advancements") {
                        advancementUnknownUUIDFailed++;
                    }
                    break;
                case 5:
                    if (type == "playerdata") {
                        geyserCleaned++;
                    } else if (type == "advancements") {
                        advancementGeyserCleaned++;
                    }
                    break;
                case 6:
                    if (type == "playerdata") {
                        duplicates++;
                    } else if (type == "advancements") {
                        advancementDuplicates++;
                    }
                    break;
                case 7:
                    if (type == "playerdata") {
                        noMatch++;
                    } else if (type == "advancements") {
                        advancementNoMatch++;
                    }
                    break;
                default:
                    break;
            }
        }
        public string GetStatistic() {
            var stat = "==========Playerfiles========== \n"
               + "UUIDs found: " + uuidTotalFound + "\n"
               + "UUIDs cleaned: " + uuidTotalCleaned + "\n"
               + "V3 UUIDs converted: " + v3UUIDConverted + "\n"
               + "V3 UUIDs failed: " + v3UUIDFailed + "\n"
               + "Unknown UUIDs converted: " + unknownUUIDConverted + "\n"
               + "Unknown UUIDs failed: " + unknownUUIDFailed + "\n"
               + "Geyser UUIDs cleaned: " + geyserCleaned + "\n"
               + "Duplicates: " + duplicates + "\n"
               + "Unmatched UUIDs: " + noMatch + "\n"
               + "==========Advancements========== \n"
               + "Advancements found: " + advancementUUIDTotalFound + "\n"
               + "Advancements cleaned: " + advancementUUIDTotalCleaned + "\n"
               + "V3 Advancements converted: " + advancementV3UUIDConverted + "\n"
               + "V3 Advancementss failed: " + advancementV3UUIDFailed + "\n"
               + "Unknown advancements converted: " + advancementUnknownUUIDConverted + "\n"
               + "Unknown advancements failed: " + advancementUnknownUUIDFailed + "\n"
               + "Geyser advancements cleaned: " + advancementGeyserCleaned + "\n"
               + "Unmatched advancements: " + advancementNoMatch + "\n"
               + "Duplicates: " + advancementDuplicates;
            return stat;
        }
    }
}
