int Sum(int a, int b)
{
    return a + b;
}

int Sum2(int a, int b) => a + b;

Func<int, int, int> res = (int a, int b) => a + b;

int[] p = new int[5];
p.Where(x => x > 0);
