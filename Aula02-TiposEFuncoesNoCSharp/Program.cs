/*
    1- Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
    2- Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
    3- Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
    4- Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.
*/

Console.Write("Insira a nota que deseja avaliar: ");
int nota = int.Parse(Console.ReadLine()!);
AvaliaNota(nota);

void AvaliaNota(int nota)
{
    if (nota >= 5)
    {
        Console.WriteLine("Parabéns!!!");
        Console.WriteLine("Nota suficiente para aprovação");
    }
    else
    {
        Console.WriteLine("Infelizmente sua nota é insuficiente para a aprovação");
    }
}


List<string> listaLinguagens = new List<string>
{
    "C#",
    "Java",
    "JavaScript"
};

// Console.Write("Escreve a posição da linguagem de programação que deseja ver: ");
// int posicao = int.Parse(Console.ReadLine()!);
//
// Console.WriteLine(listaLinguagens[posicao]);