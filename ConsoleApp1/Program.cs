class Program
{
    static void Main(string[] args)
    {
        // List of GUIDs
        string[] ids = new string[]
        {
            "70cea570-4c2c-48f9-9eb8-5e8e600ec86d",
            "a94c43fe-f2ec-468b-a081-278ebe7c0adb",

        };
        
        // Source folder path
        string sourceFolder = @"D:\Programming\Prod\202305";

        // Destination folder path
        string destinationFolder = @"D:\Programming\ProdNew\HSI-TECS";

        // Get all files in the source folder
        string[] files = Directory.GetFiles(sourceFolder, "*.jpg");

        int filesMoved = 0;

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
                filesMoved++;
            }
        }

        Console.WriteLine($"{filesMoved} Files moved successfully.");
    }
}
