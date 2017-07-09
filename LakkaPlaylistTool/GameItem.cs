using System;
using System.Drawing;
using System.Linq;

namespace LakkaPlaylistTool
{
    /// <summary>
    /// /storage/roms/n64/Legend of Zelda, The - Ocarina of Time (USA).n64
    /// Legend of Zelda, The - Ocarina of Time (USA)
    /// /tmp/cores/mupen64plus_libretro.so
    /// Nintendo 64 (Mupen64Plus)
    /// EC95702D|crc
    /// Nintendo - Nintendo 64.lpl
    /// <see cref="http://www.lakka.tv/doc/Playlists/"/>
    /// </summary>
    public class GameItem : IComparable<GameItem>
    {
        public GameItem()
        {
            V1RomFullFileName = V2RomCnName = V3coreBinaryPath = V4EmuType = V5Crc32 = V6pListName = imageFullName = "";
        }
        
        /// <summary>
        /// ROM中文名称
        /// </summary>
        public String V2RomCnName { get; set; }
        public Image image { get; set; }

        /// <summary>
        /// ROM在Linux系统中的路径
        /// </summary>
        public String V1RomFullFileName { get; set; }
        /// <summary>
        ///  模拟器核心
        /// </summary>
        public String V3coreBinaryPath { get; set; }
        /// <summary>
        /// 模拟器核心的名称
        /// </summary>
        public String V4EmuType { get; set; }
        /// <summary>
        /// CRC32
        /// </summary>
        public String V5Crc32 { get; set; }
        /// <summary>
        /// 游戏列表文件的文件名
        /// </summary>
        public String V6pListName { get; set; }


        /// <summary>
        /// 图片全路径
        /// </summary>
        public String imageFullName;

        public void handleSpecialChars()
        {
            this.V2RomCnName = this.V2RomCnName.Replace(":", "_").Replace("/", "").Replace(@"\", "").Replace("|", "").Replace("*", "").Replace("<", "(").Replace(">", ")").Replace("?", "_").Replace(@"""", "_").Replace("&", "_");
        }

        /// <summary>
        /// ROM短文件名 wolf.zip
        /// </summary>
        /// <returns></returns>
        public string getRomShortFileNameWithExtension()
        {
            return V1RomFullFileName.Split('/').Last().Split('\\').Last();
        }
        /// <summary>
        /// ROM短文件名 wolf
        /// </summary>
        /// <returns></returns>
        public string getRomShortFileNameWithOutExtension()
        {
            return V1RomFullFileName.Split('/').Last().Split('\\').Last().Split('.').First();
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
