/*
    1- Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.
    2- Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.
    3- Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.
    4- Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.
*/
int opcaoSelecionada = -1;
// while (opcaoSelecionada != 0)
// {
//     Calcula(10, 2);
// }

void Calcula(double a, double b)
{
    Console.WriteLine("[1] Soma");
    Console.WriteLine("[2] Subtração");
    Console.WriteLine("[3] Multiplicação");
    Console.WriteLine("[4] Divisão");
    Console.WriteLine("[0] Sair");
    
    Console.Write("Selecione a operação básica: ");
    opcaoSelecionada = int.Parse(Console.ReadLine()!);
    switch (opcaoSelecionada)
    {
        case 1:
            double soma = a + b;
            Console.WriteLine($"{a} + {b} = {soma}");
            break;
        case 2:
            double subtracao = a - b;
            Console.WriteLine($"{a} - {b} = {subtracao}");
            break;
        case 3:
            double multiplicacao = a * b;
            Console.WriteLine($"{a} x {b} = {multiplicacao}");
            break;
        case 4:
            double divisao = a / b;
            Console.WriteLine($"{a} / {b} = {divisao}");
            break;
        case 0:
            Console.WriteLine("Fechando a aplicação");
            break; 
        default:
            Console.WriteLine("Não é uma opção válida. ");
            break;
            
    }
}

List<string> bandasFavoritas = new List<string>();
bandasFavoritas.Add("Japãozinho");
bandasFavoritas.Add("Barões da Pisadinha");
bandasFavoritas.Add("Alvvays");
bandasFavoritas.Add("Nadson, o ferinha");

// foreach (string bandas in bandasFavoritas)
// {
//     Console.WriteLine(bandas);
// }


List<int> numeros = new List<int>();
numeros.Add(10);
numeros.Add(5);
numeros.Add(2);
numeros.Add(4);

int soma = 0;

foreach (int numero  in  numeros)
{
    soma += numero;
}

Console.WriteLine($"A soma de todos os números da coleção é {soma}");