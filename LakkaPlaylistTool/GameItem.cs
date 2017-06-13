using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace LakkaPlaylistTool
{
    public class GameItem : IComparable<GameItem>
    {
        public GameItem()
        {
            V1RomFullFileName = V2RomCnName = V3core = V4EmuType = V5Crc32 = V6pListName = imageName = "";
        }
        
        // Put those two column in front to shown in front of the table
        public String V2RomCnName { get; set; }
        public String imageName { get; set; }

        public String V1RomFullFileName { get; set; }
        public String V3core { get; set; }
        public String V4EmuType { get; set; }
        public String V5Crc32 { get; set; }
        public String V6pListName { get; set; }
        
        public Image image { get; set; }
        
        public void handleILegalChars()
        {
            this.V2RomCnName = this.V2RomCnName.Replace(":", "_").Replace("/", "").Replace(@"\", "").Replace("|", "").Replace("*", "").Replace("<", "(").Replace(">", ")").Replace("?", "_").Replace(@"""", "_");
        }

        public string getRomShortFileName()
        {
            return V1RomFullFileName.Split('/').Last();
        }

        public int CompareTo(GameItem obj)
        {
            int result;
            if (this.V2RomCnName == obj.V2RomCnName)
            {
                result = 0;
            }
            else
            {
                if (this.V2RomCnName.CompareTo(obj.V2RomCnName) > 0)
                {
                    result = 1;
                }
                else
                {
                    result = -1;
                }
            }
            return result;
        }

    }
}
