Random rnd = new Random();
int m = rnd.Next(0,4);
int n = rnd.Next(0,6);

int resolt = Akkerman(m,n);
Console.WriteLine($"m={m}, n={n} -> A(m,n) = {resolt}");

int Akkerman(int m, int n)
{
    if(m == 0)
        return n + 1;
    else if(m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else if(m > 0 && n > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    else
        return 0;
    
}
