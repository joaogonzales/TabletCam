using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFMusic_New
{
    public class GeraInfo
    {
        public ArrayList devolveString(ArrayList nowPlaylist)
        {
            const string s = "I have a cat";

            // Location of the letter c.
            int i = s.IndexOf('\\');

            // Remainder of string starting at c.
            string d = s.Substring(i);

            return nowPlaylist;
        }

        public string CriaArqM3U(string path, string[] Files, string Extensao)
        {

            string dirName = new DirectoryInfo(path).Parent.FullName +"\\"+ new DirectoryInfo(path).Parent.Name + Extensao;
            if (!File.Exists(dirName))
            {
                // Cria Arquivo M3U, abasteçe com os Mp3 da pasta e retorna o arquivo M3U
                using (StreamWriter sw = File.CreateText(dirName))
                {
                    for (int i = 0; i < Files.Length; i++)
                    {
                        sw.WriteLine(new DirectoryInfo(Files[i]).Name);
                        if (i == Files.Length)
                            sw.Close();
                    }
                    
                }
            }
            return dirName;
        }

    }
}
