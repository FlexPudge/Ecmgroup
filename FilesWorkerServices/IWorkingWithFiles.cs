namespace Ecmgroup.FilesWorkerServices
{
    public interface IWorkingWithFiles
    {
        /// <summary>
        /// Десериализация xml файла 
        /// </summary>
        /// <typeparam name="T">Объект</typeparam>
        /// <param name="path">путь к файлу</param>
        /// <returns></returns>
        T Deserialize<T>(string path);

        /// <summary>
        /// Сериализация
        /// </summary>
        /// <typeparam name="T">тип оъекта</typeparam>
        /// <param name="entity">объект</param>
        /// <param name="path">путь к файлу</param>
        void Serialize<T>(T entity, string path);
    }
}
