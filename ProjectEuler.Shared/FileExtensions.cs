namespace ProjectEuler.Shared
{
    public static class FileExtensions
    {
        public static List<string> GetAppFileAsArray(string folderName, string fileName)
        {
            var fileResult = System.IO.File.ReadAllLines($@"..\..\..\{folderName}\" + fileName);
            return fileResult.ToList();
        }

        public static string GetAppFileAsString(string folderName, string fileName)
        {
            var fileResult = System.IO.File.ReadAllText($@"..\..\..\{folderName}\" + fileName);
            return fileResult;
        }

        public static List<string> GetTestFileAsArray(string fileName)
        {
            var fileResult = System.IO.File.ReadAllLines(@"..\..\..\" + fileName);
            return fileResult.ToList();
        }

        public static string GetTestFileAsString(string fileName)
        {
            var fileResult = System.IO.File.ReadAllText(@"..\..\..\" + fileName);
            return fileResult;
        }

        public static void WriteToLog(string log)
        {
            using (var sw = new System.IO.StreamWriter(@"..\..\..\logs.txt", true))
                sw.WriteLine(log);
        }

        public static void WriteToLog(List<string> logs)
        {
            System.IO.File.WriteAllLines(@"..\..\..\logs.txt", logs);
        }
    }
}
