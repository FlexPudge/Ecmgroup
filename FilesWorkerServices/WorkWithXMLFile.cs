using System.Xml.Serialization;

namespace Ecmgroup.FilesWorkerServices
{
    public class WorkWithXMLFile : IWorkingWithFiles
    {
        public T Deserialize<T>(string path)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var reader = new StreamReader(path))
            {
                return (T)serializer.Deserialize(reader)!;
            }
        }

        public void Serialize<T>(T entity, string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, entity);
                Console.WriteLine($"{entity.ToString()} has been serialized");
            }
        }
    }
}
