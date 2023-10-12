string path = @"C:\Users\Momo\Documents\C#";

// create directory

DirectoryInfo directoryInfo = new DirectoryInfo($"{path}/papka");

directoryInfo.Create();

//check if exists
if (!directoryInfo.Exists)
{
    Console.WriteLine("Directory doesn't exist,");
}
else
{
    Console.WriteLine("Directory exists!");
}

//create file
var file = $"{path}/file.txt";

// write information to a file
string[] info = { "momi", "14" };

File.WriteAllLines(file, info);


//move to another file 
var file2 = $@"{path}\file2.txt";

File.Move(file, file2);


// copy file 
var file3 = $@"{path}\file3.txt";

File.Copy(file2, file3);
//note: need to delete the created files to copy them after you run it ones


// write on file
using (StreamWriter sw = File.AppendText(file3))
{
    sw.WriteLine("Extra text");
}

// Open the file to read from.
using (StreamReader sr = File.OpenText(file3))
{
    string s = "";
    while ((s = sr.ReadLine()) != null)
    {
        Console.WriteLine(s);
    }
}




