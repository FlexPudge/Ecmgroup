namespace Ecmgroup.FilesWorkerServices
{
    internal class WorkingWithTXTFiles
    {
        public void Serialize(string message, string path)
        {
            // полная перезапись файла 
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.Write(message);
                Console.WriteLine($"ErrorMessage has been save");
            }
        }
    }
}
