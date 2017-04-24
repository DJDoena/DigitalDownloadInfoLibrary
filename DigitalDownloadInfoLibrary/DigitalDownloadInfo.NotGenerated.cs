using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

// xsd.exe /c /l:cs /f DigitalDownloadInfo.xsd /n:DoenaSoft.DVDProfiler.DigitalDownloadInfo

namespace DoenaSoft.DVDProfiler.DigitalDownloadInfo
{
    public sealed partial class DigitalDownloadInfoList
    {
        private static XmlSerializer s_XmlSerializer;

        [XmlIgnore]
        public static XmlSerializer XmlSerializer
        {
            get
            {
                if (s_XmlSerializer == null)
                {
                    s_XmlSerializer = new XmlSerializer(typeof(DigitalDownloadInfoList));
                }

                return (s_XmlSerializer);
            }
        }

        public static DigitalDownloadInfoList Deserialize(String fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                DigitalDownloadInfoList instance = (DigitalDownloadInfoList)(XmlSerializer.Deserialize(fs));

                return (instance);
            }
        }

        public static void Serialize(DigitalDownloadInfoList instance
            , String fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (XmlTextWriter xtw = new XmlTextWriter(fs, Encoding.UTF8))
                {
                    xtw.Formatting = Formatting.Indented;

                    XmlSerializer.Serialize(xtw, instance);
                }
            }
        }

        public void Serialize(String fileName)
        {
            Serialize(this, fileName);
        }
    }

    public sealed partial class DigitalDownloadInfo
    {
        private static XmlSerializer s_XmlSerializer;

        [XmlIgnore]
        public static XmlSerializer XmlSerializer
        {
            get
            {
                if (s_XmlSerializer == null)
                {
                    s_XmlSerializer = new XmlSerializer(typeof(DigitalDownloadInfo));
                }

                return (s_XmlSerializer);
            }
        }

        public static DigitalDownloadInfo Deserialize(String fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                DigitalDownloadInfo instance = (DigitalDownloadInfo)(XmlSerializer.Deserialize(fs));

                return (instance);
            }
        }

        public static void Serialize(DigitalDownloadInfo instance
            , String fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (XmlTextWriter xtw = new XmlTextWriter(fs, Encoding.UTF8))
                {
                    xtw.Formatting = Formatting.Indented;

                    XmlSerializer.Serialize(xtw, instance);
                }
            }
        }

        public void Serialize(String fileName)
        {
            Serialize(this, fileName);
        }
    }
}
