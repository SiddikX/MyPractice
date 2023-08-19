using ParameterModifier;

var test = new TestClass();
int res = test.Sum(5, 9);

int[] arr = { 2, 5, 6 };

int res2 = test.Sum(arr);
Console.WriteLine(res);
Console.WriteLine(res2);
