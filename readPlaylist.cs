using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TFMusic_New
{
    class readPlaylist
    {
        private ArrayList name = new ArrayList();
        private string m_xmlFile;

        /// <SUMMARY>
        /// The Windows Media Playlist Path xxx.wpl file
        /// </SUMMARY>
        public string playListPath
        {
            get
            {
                return m_xmlFile;
            }
            set
            {
                m_xmlFile = value;
                Makeplaylist();
            }
        }

        /// <SUMMARY>
        /// Return an Arraylist of file found in Windows Media Playlist file
        /// </SUMMARY>
        public ArrayList PlayList
        {
            get
            {
                return name;
            }
        }

        /// <SUMMARY>
        /// Fills up an Arraylist with titles found in the
        /// Windows Media Playlist file.
        /// Using XmlTextReader
        /// </SUMMARY>
        private void Makeplaylist()
        {
            XmlTextReader readList = new XmlTextReader(m_xmlFile);
            while (readList.Read())
            {
                if (readList.NodeType == XmlNodeType.Element)
                {
                    if (readList.LocalName.Equals("media"))
                    {
                        name.Add(Path.GetFileName(readList.GetAttribute(0).ToString()));
                        //Path.Combine(newPath, Path.GetFileName(filePath))
                        //name.Add(readList.GetAttribute(0).ToString());

                    }
                }
            }
        }
    }
}
