using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace LakkaPlaylistTool
{
    class Utils
    {
        /// <summary>
        /// Get ROM Chinese name from FBA_Shuffle data base
        /// </summary>
        /// <returns>Key: rom name [wofa], Value : tranlated rom Name [三国志 II (亚洲版 921005)] </returns>
        public static Dictionary<string, string> getFBA_res()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(fba_res.Lakka.gamelist_cn);
            XmlNodeList gameList = doc.SelectNodes("//game");
            foreach (XmlNode game in gameList)
            {
                XmlElement xe = (XmlElement)game;
                string romName = xe.SelectSingleNode("name").InnerText;
                string romCnName = xe.SelectSingleNode("translation").InnerText;
                if (romName.Length > 0 && !dic.ContainsKey(romName))
                {
                    dic[romName] = romCnName;
                }
            }
            return dic;
        }

        /// <summary>
        /// write line to file
        /// </summary>
        /// <param name="fStream"></param>
        /// <param name="str"></param>
        public static void WriteStrToFile(FileStream fStream, string str)
        {
            byte[] data1 = System.Text.Encoding.UTF8.GetBytes(str);
            fStream.Write(data1, 0, data1.Length);

            byte[] data2 = System.Text.Encoding.UTF8.GetBytes("\r\n");
            fStream.Write(data2, 0, data2.Length);
        }

        /// <summary>
        /// Get File Name
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static string GetFileNameWithOutExtention(string file)
        {
            FileInfo fi = new FileInfo(file);
            return fi.Name.Remove(fi.Name.LastIndexOf(fi.Extension));
        }

        /// <summary>
        /// Get File Name
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static string GetFileNameWithOutExtention(FileInfo file)
        {
            return file.Name.Remove(file.Name.LastIndexOf(file.Extension));
        }
    }
}
