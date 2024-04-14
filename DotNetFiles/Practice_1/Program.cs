    using System.IO;
//Return Directores
    IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories("stores");

    foreach (var dir in listOfDirectories) {
        Console.WriteLine(dir);
    }
    Console.WriteLine("====================================================");

// Outputs:
// stores/201
// stores/202

///////////////////////////////////////////////////////////////
//return with Files
IEnumerable<string> files = Directory.EnumerateFiles("stores");

foreach (var file in files)
{
    Console.WriteLine(file);
}
    Console.WriteLine("====================================================");

// Find all *.txt files in the stores folder and its subfolders
IEnumerable<string> allFilesInAllFolders = Directory.EnumerateFiles("stores", "*.txt", SearchOption.AllDirectories);

foreach (var file in allFilesInAllFolders)
{
    Console.WriteLine(file);
}
    Console.WriteLine("====================================================");

// Outputs:
// stores/totals.txt
// stores/201/inventory.txt