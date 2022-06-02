using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerFileCleaner.Models {

    enum Stat : ushort {
        playerdata = 0,
        advancements = 10
    }
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
            int i = (ushort)Enum.Parse(typeof(Stat), type) + stat;
            switch (i) {
                case 0:
                    uuidTotalFound++;
                    break;
                case 1:
                    uuidTotalCleaned++;
                    break;
                case 2:
                    v3UUIDConverted++;
                    break;
                case 3:
                    v3UUIDFailed++;
                    break;
                case 4:
                    unknownUUIDConverted++;
                    break;
                case 5:
                    unknownUUIDFailed++;
                    break;
                case 6:
                    geyserCleaned++;
                    break;
                case 7:
                    duplicates++;
                    break;
                case 8:
                    noMatch++;
                    break;
                case 10:
                    advancementUUIDTotalFound++;
                    break;
                case 11:
                    advancementUUIDTotalCleaned++;
                    break;
                case 12:
                    advancementV3UUIDConverted++;
                    break;
                case 13:
                    advancementV3UUIDFailed++;
                    break;
                case 14:
                    advancementUnknownUUIDConverted++;
                    break;
                case 15:
                    advancementUnknownUUIDFailed++;
                    break;
                case 16:
                    advancementGeyserCleaned++;
                    break;
                case 17:
                    advancementDuplicates++;
                    break;
                case 18:
                    advancementNoMatch++;
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
