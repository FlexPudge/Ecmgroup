using System.Xml.Serialization;
using System;
using System.IO;

namespace Ecmgroup.FilesWorkerServices
{
    public static class WorkWithFiles
    {
        /// <summary>
        /// Десериализация xml файла 
        /// </summary>
        /// <typeparam name="T">Объект</typeparam>
        /// <param name="path">путь к файлу</param>
        /// <returns></returns>
        public static T Deserialize<T>(string path)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var reader = new StreamReader(path))
            {
                return (T)serializer.Deserialize(reader)!;
            }
        }

        /// <summary>
        /// Сериализация
        /// </summary>
        /// <typeparam name="T">тип оъекта</typeparam>
        /// <param name="entity">объект</param>
        /// <param name="path">путь к файлу</param>
        public static void Serialize<T>(T entity, string path)
        {
            throw new NotImplementedException();
        }
    }
}
