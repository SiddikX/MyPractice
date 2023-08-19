using System.Collections;

List<string> name = new List<string>();
name.Add("Jk baal");
name.Add("kutus haramjada");
name.Add("taura pola");
foreach (string s in name)
{
    Console.WriteLine(s);
}
Console.WriteLine();

ArrayList items = new ArrayList();
items.Add("Hey");
items.Add(45);
items.Add(true);
items.Add(7.99);

foreach (object obj in items)
{
    Console.WriteLine(obj);
}

Console.WriteLine();

Dictionary<string, int> map = new Dictionary<string, int>();
map.Add("jan", 1);
map.Add("rasel", 56);
map.Add("sun", 2);
map["rasel"] = 45;


HashSet<string> set = new HashSet<string>();
set.Add("jel");
set.Add("hel");
set.Add("jel");
set.Add("hellll");

foreach(string s in set)
{ Console.WriteLine(s); }