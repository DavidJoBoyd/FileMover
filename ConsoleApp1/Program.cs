class Program
{
    static void Main(string[] args)
    {
        // List of GUIDs
        string[] ids = new string[]
        {
            "Folder Names"
        };
        
        // Source folder path
        string sourceFolder = @"D:\Programming\Example\Original";

        // Destination folder path
        string destinationFolder = @"D:\Programming\Example\New";

        // Get all files in the source folder
        string[] files = Directory.GetFiles(sourceFolder, "*.jpg");

        // Iterate over the files
        foreach (string filePath in files)
        {
            string fileName = Path.GetFileName(filePath);

            // Check if the file name contains any of the GUIDs
            bool isMatched = false;
            foreach (string guid in ids)
            {
                if (fileName.Contains(guid))
                {
                    isMatched = true;
                    break;
                }
            }

            if (isMatched)
            {
                // Move the file to the destination folder
                string destinationFilePath = Path.Combine(destinationFolder, fileName);
                File.Move(filePath, destinationFilePath);
            }
        }

        Console.WriteLine("Files moved successfully.");
    }
}
