List<int> inteiros = new List<int>();
int limite = 10;
for (int i = 0; i <= limite; i++)
{
    inteiros.Add(i);
}

List<int> buscaPares = inteiros.FindAll(pares => pares % 2 == 0);
buscaPares.ForEach(inteiro => Console.Write($"{inteiro}, "));