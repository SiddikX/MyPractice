using Enumsed;
Console.WriteLine((int)Enums.Months.Jun);

int u = (int)Enums.Status.Pending;

Console.WriteLine(u);

DateTime d = new DateTime(2016, 9, 24);
DateTime d2 = d;
Console.WriteLine(d);
Console.WriteLine(d2);
Console.WriteLine();
d = new DateTime(2017, 5, 9);
Console.WriteLine(d);
Console.WriteLine(d2);
Console.WriteLine(DateTime.Now);