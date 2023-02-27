using System.IO;

// string sourcePath = @"c:\temp\txt.txt";
// string targetPath = @"c:\temp\txt1.txt";

// try
// {
//     FileInfo fileInfo = new FileInfo(sourcePath);
//     fileInfo.CopyTo(targetPath);
//     string[] lines = File.ReadAllLines(sourcePath);
//     foreach(string line in lines)
//     {
//         Console.WriteLine(line);
//     }
// }
// catch (IOException e)
// {
//     Console.WriteLine("An error ocorred!");
//     Console.WriteLine(e.Message);
// }


// string path = @"c:\temp\txt.txt";
// FileStream fs = null;
// StreamReader sr = null;
// try{
//    fs =  new FileStream(path, FileMode.Open);
//    sr = new StreamReader(fs);
//    string line = sr.ReadLine();
//    Console.WriteLine(line); 
// }
// catch(IOException e)
// {
//     Console.WriteLine("An error acurred!");
//     Console.WriteLine(e.Message);
// }
// finally
// {
//     if(sr != null) sr.Close();
//     if(fs != null) fs.Close();

// }

string sourcePath = @"c:\temp\txt.txt";
string targetPath = @"c:\temp\txt1.txt";

try{
   string [] lines = File.ReadAllLines(sourcePath);
   using (StreamWriter sw = File.AppendText(targetPath))
   {
    foreach(string line in lines)
    {
        sw.WriteLine(line.ToUpper());
    }
   }
}
catch(IOException e)
{
    Console.WriteLine("An error acurred!");
    Console.WriteLine(e.Message);
}