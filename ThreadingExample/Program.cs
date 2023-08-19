using System.Diagnostics;

Stopwatch sw = Stopwatch.StartNew();
void PrintEven()
{
    for(int i = 0; i < 100; i++)
        if(i%2 == 0)
            Console.WriteLine(i);
}

void PrintOdd()
{
    for (int i = 0; i < 100; i++)
        if (i % 2 != 0)
            Console.WriteLine(i);
}

sw.Start();
Thread t1 = new Thread((x) => PrintEven());
Thread t2 = new Thread((y) => PrintOdd());
t1.Start();
t2.Start();
sw.Stop();
Console.WriteLine(sw.Elapsed);