using System;
using System.IO;
using System.Xml.Serialization;

namespace WriteXMLfile.Serial
{
    public static class WriteXmlFile
    {
        private static string AppPath => Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
        private static DirectoryInfo myDir = new DirectoryInfo(AppPath);
        private static string dataDir = myDir.Parent.Parent.FullName.ToString();
        public static string xmlDishPath = $"{dataDir}\\Data\\Dishes.xml";
        public static string xmlFeedBack = $"{dataDir}\\Data\\FeedBack.xml";
        public static string xmlUsers = $"{dataDir}\\Data\\Users.xml";
        public static string xmlOrder = $"{dataDir}\\Data\\Order.xml";





        public static void Serialize<T>(T obj, string path)
        {
            var writer = new XmlSerializer(typeof(T));

            using (var file = new StreamWriter(path))
            {
                writer.Serialize(file, obj);
            }
        }


        public static T Deserialize<T>(string path)
        {
            var reader = new XmlSerializer(typeof(T));
            using (var stream = new StreamReader(path))
            {
                return (T)reader.Deserialize(stream);
            }

        }

        public static void SerializeAppend<T>(T obj, string path)
        {
            var writer = new XmlSerializer(typeof(T));

            FileStream file = File.Open(path, FileMode.Append, FileAccess.Write);

            writer.Serialize(file, obj);

            file.Close();
        }
    }

}
