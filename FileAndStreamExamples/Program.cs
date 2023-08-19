using System.Text;

//File.WriteAllText("Hellowwww.txt", "Hello world. How Re you?");
//File.WriteAllLines("Lines.txt", new string[] { "Line1", "Line2", "Line 3" });



//using (StreamWriter writer = File.AppendText("Lines.txt"))
//{
//    writer.WriteLine("Line3");
//    writer.WriteLine("Line50");
//}
using (StreamWriter writer = File.AppendText(filePath))
{
    writer.WriteLine(userInput);
}

Console.WriteLine("Data appended to the file successfully.");

//FileStream fileStream = File.Open("Lines.txt", FileMode.Open);
//byte[] buffer = new byte[10];
//fileStream.Read(buffer, 0, 8);
//string text = Encoding.UTF8.GetString(buffer);
//Console.WriteLine(text);

FileInfo file = new FileInfo("Lines.txt");
if(file.Exists)
    Console.WriteLine("File existed");

if(File.Exists("Lines.txt"))
    Console.WriteLine("File holla");


string currentDir = Directory.GetCurrentDirectory();
DirectoryInfo dirInfo = new DirectoryInfo(currentDir);
string rootDir = dirInfo.Parent.Parent.Parent.FullName;
string path = Path.Combine(rootDir, "newfile.txt");
Console.WriteLine(path);
File.WriteAllText(path, "Just aother file. I have created this. Hurraaaaahhhhh!");
string text = File.ReadAllText(path);
Console.WriteLine(text);