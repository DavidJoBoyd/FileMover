class Program
{
    static void Main(string[] args)
    {
        // List of GUIDs
        string[] ids = new string[]
        {
            "21dfcd09-e8ea-4b99-93e4-eaadeb02bde2",
            "0df7fb02-5051-4861-a423-6739ea94138f",
            "d128f8e9-deb6-4f8b-ab9e-7b5179502538",
            "5b80a9ed-7a1c-4b72-9848-ad05f80bea8f",
            "ac924487-e6d1-489a-8af4-de7bf6501f77",
            "a4dfaee3-4a5e-4593-87a6-515c759e0df2",
            "8a2fc289-f3ee-4559-bf6b-43a388c931c4",
            "d0401775-1bec-427b-a656-89cea2f502dd",
            "90399b33-3a7c-4adf-aa0f-eff21e9a065f",
            "6817a76d-20c4-46fb-a068-5b949eb7f682",
            "bbef97e3-6f01-465a-97e3-bf45e4ecb2cd",
            "2a1394d2-2ca5-4020-82d3-a413d715f1e9",
            "5f29d55a-89cc-4eff-a366-652a6a6a58f1",
            "30003068-86e1-47f4-a03b-169f0d8a103d",
            "eabedab3-adde-4920-9669-06bf7b18a949",
            "1b0649a8-8048-4da1-860f-3e0b16d27596",
            "6e5fcbcf-0530-4088-a9b5-ce5779e841e7",
            "0687092d-e019-4f5c-993b-c50ec12320ff",
            "f8479ecc-750b-40c3-af26-03a5f4239a3d",
            "4c4afafd-d378-41a1-a98c-0350e4012c0e",
            "d5d0b774-2cda-4fba-8d53-57050dc83ff3",
            "b39561de-4086-4a96-808a-7a041e98368a",
            "5f47c718-0979-483d-84af-e8e6e8714f3e",
            "2982a88f-8638-462a-a4eb-1fcb1785a776",
            "478c642f-9bc6-4bc5-92ab-779abe260959",
            "59165da7-440e-45ce-ad6e-2e1127ca7f7f",
            "b229fd8b-4d70-442f-ab4c-d457e985ccc2",
            "5cf0598d-6b88-4edc-b4e7-553c49df3a76",
            "6df8b029-d60d-441a-a159-ccbbd2098dbc",
            "2f0eb977-a723-4d84-9cc2-c765df32c5b1",
            "df783610-ddf3-47fe-9cb9-106071f67329",
            "9bccf76d-5916-49b5-ac68-3aa656b16c80",
            "67426e95-58c8-43d5-bdc9-b5620707441b",
            "220931f8-f717-41d0-9b43-6dd0bb7df461",
            "c7899d2e-8ce2-4ad8-80b0-e487bfc69dd3",
            "2b6ab6eb-de05-487d-8829-d99049872861",
            "390b1d7b-a118-4308-bb3c-0d283804efd1",
            "c3276877-6afa-47c8-b6c0-921e603c71dd"
        };
        
        // Source folder path
        string sourceFolder = @"D:\Programming\Old2";

        // Destination folder path
        string destinationFolder = @"D:\Programming\CrossBorder";

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
