//I can use either var or dynamic

//var anon = new { Name = "foo", Age = 26, Sex = "Male", CGPA = 2.86 };

dynamic anon = new { Name = "foo", Age = 26, Sex = "Male", CGPA = 2.86 };
Console.WriteLine(anon.Name);