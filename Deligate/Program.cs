using Delegate;

BubbleSort<int> bubbleSort = new BubbleSort<int>();
int[] s = { 5, 6, 2, 1, 9, 10, 5, 3, 5};

bool CompareNum(int a, int b)
{
    return a > b;
}

bubbleSort.Bubble(s, CompareNum);
foreach (int i in s)
{
    Console.Write(i + " ");
}
Console.WriteLine();

BubbleSort<Person> bubbleSort2 = new BubbleSort<Person>();

Person[] people = new Person[4];
people[0] = new Person { Name = "Sakik", Age = 40 };
people[1] = new Person { Name = "Jalal", Age = 70 };
people[2] = new Person { Name = "Rahim", Age = 34 };
people[3] = new Person { Name = "Sakik", Age = 45 };

bool ComparePerson (Person p1, Person p2)
{
    if (p1.Name.CompareTo(p2.Name) == 0)
        return p1.Age < p2.Age;
    else
        return p1.Name.CompareTo(p2.Name) > 0;
}

Person[] result = bubbleSort2.Bubble(people, ComparePerson);

foreach (Person p in result)
{
    Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
}

