using System.IO;
using System.Xml.Serialization;

namespace ManagerFile
{
    public class Formatters
    {
        public static class XML
        {
            /// <summary>
            /// Сериализация XML файла
            /// </summary>
            /// <typeparam name="T">  </typeparam>
            /// <param name="obj">Объект</param>
            /// <param name="file">Путь + название файла для сохранения</param>
            /// <returns></returns>
            public static void SerializeXML<T>(string file, T obj)
            {
                XmlSerializer formatter = new XmlSerializer(typeof(T));
                using (FileStream stream = new FileStream(file, FileMode.Create))
                {
                    formatter.Serialize(stream, obj);
                }

            }

            /// <summary>
            /// Десериализация XML файла
            /// </summary>
            /// <typeparam name="T"> Объект десериализаци </typeparam>
            /// <param name="stream"></param>
            /// <returns></returns>
            public static T DeserializeXML<T>(Stream stream)
            {
                T result = default;

                XmlSerializer formatter = new XmlSerializer(typeof(T));
                result = (T)formatter.Deserialize(stream);

                return result;
            }
        }
    }
}
