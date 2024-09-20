namespace CreateTestData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:/tmp/TestFiles";
            string[] filePrefixes = { "SU3411", "RK3452", "GL0013", "ZX7402", "GL0007", "AF3621", "JL9206", "RK4587" };

            Directory.CreateDirectory(filePath);

            foreach (string fp in filePrefixes)
            {
                foreach (char c in GetAlphabetArray())
                {
                    File.Create(Path.Combine(filePath, fp + c + ".jpg")).Close();
                }
            }
        }

        public static char[] GetAlphabetArray()
        {
            char[] alphabet = new char[26];
            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)('a' + i);
            }
            return alphabet;
        }
    }
}
