using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

// xsd.exe /c /l:cs /f /n:DoenaSoft.DVDProfiler.DigitalDownloadInfo DigitalDownloadInfo.xsd

namespace DoenaSoft.DVDProfiler.DigitalDownloadInfo
{
    public sealed partial class DigitalDownloadInfoList
    {
        private static XmlSerializer _xmlSerializer;

        [XmlIgnore]
        public static XmlSerializer XmlSerializer
        {
            get
            {
                if (_xmlSerializer == null)
                {
                    _xmlSerializer = new XmlSerializer(typeof(DigitalDownloadInfoList));
                }

                return _xmlSerializer;
            }
        }

        public static DigitalDownloadInfoList Deserialize(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var instance = (DigitalDownloadInfoList)(XmlSerializer.Deserialize(fs));

                return instance;
            }
        }

        public static void Serialize(DigitalDownloadInfoList instance, string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (var xtw = new XmlTextWriter(fs, Encoding.UTF8))
                {
                    xtw.Formatting = Formatting.Indented;
                    xtw.Namespaces = false;

                    var ns = new XmlSerializerNamespaces();
                    ns.Add(string.Empty, string.Empty);

                    XmlSerializer.Serialize(xtw, instance, ns);
                }
            }
        }

        public void Serialize(string fileName)
        {
            Serialize(this, fileName);
        }
    }

    public sealed partial class DigitalDownloadInfo
    {
        private static XmlSerializer _xmlSerializer;

        [XmlIgnore]
        public static XmlSerializer XmlSerializer
        {
            get
            {
                if (_xmlSerializer == null)
                {
                    _xmlSerializer = new XmlSerializer(typeof(DigitalDownloadInfo));
                }

                return _xmlSerializer;
            }
        }

        public static DigitalDownloadInfo Deserialize(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var instance = (DigitalDownloadInfo)(XmlSerializer.Deserialize(fs));

                return instance;
            }
        }

        public static void Serialize(DigitalDownloadInfo instance, string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (var xtw = new XmlTextWriter(fs, Encoding.UTF8))
                {
                    xtw.Formatting = Formatting.Indented;
                    xtw.Namespaces = false;

                    var ns = new XmlSerializerNamespaces();
                    ns.Add(string.Empty, string.Empty);

                    XmlSerializer.Serialize(xtw, instance, ns);
                }
            }
        }

        public void Serialize(string fileName)
        {
            Serialize(this, fileName);
        }
    }
}
