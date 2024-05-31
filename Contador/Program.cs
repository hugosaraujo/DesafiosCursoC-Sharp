List<int> inteiros = new List<int>();
int limite = 10;

for (int i = 0; i <= limite; i++)
{
    if (i % 2 != 0)
    {
        i++;
    }
    inteiros.Add(i);
}

foreach (int inteiro in inteiros)
{
    Console.Write($"{inteiro}, ");
}