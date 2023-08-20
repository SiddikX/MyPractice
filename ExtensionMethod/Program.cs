using ExtensionMethod;

var length = int.Parse(Console.ReadLine());
var str = Console.ReadLine();
var res = str.ToShortString(length);
Console.WriteLine(res);
