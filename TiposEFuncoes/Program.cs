/*
 * 1 - Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
 * 2 - Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
 * 3 - Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
 * 4 - Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.
 * 
 */



int notaMedia = 6;

verificaNota(notaMedia);
void verificaNota(int nota)
{
    if(nota > 5)
    {
        Console.WriteLine($"Sua nota foi {nota}. Você está acima de média! Parabéns");
    } else
    {
        Console.WriteLine($"Sua nota foi {nota}. Infelizmente sua nota está abaixo da média");
    }
}


List<string> linguagens = new List<string>() { "C#", "Java", "Javascript" };

for (int i = 0; i < linguagens.Count; i++)
{
    if (linguagens[i].Equals("Java"))
    {
        Console.WriteLine(linguagens[i]);
    }
}

Console.Write("Digite um valor para buscar na lista: ");
int entrada = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Você buscou o valor {entrada}");
