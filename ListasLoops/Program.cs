/*
 * 1 - Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.
 * 2 - Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.
 * 3 - Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.
 * 4 - Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.
 */

using System;

void calcula(double a, double b)
{
    Console.Write("Selecione a operação matemática: ");
    int operacaoSelecionada = int.Parse(Console.ReadLine()!);

    exibeMenuDeOperacoes();

    switch (operacaoSelecionada)
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
            Console.WriteLine($"{a} X {b} = {multiplicacao}");
            break;
        case 4:
            double divisao = a / b;
            Console.WriteLine($"{a} + {b} = {divisao}");
            break;
        default: 
            Console.WriteLine("Não é uma opção válida");
            break;
    }
}

void exibeMenuDeOperacoes()
{
    Console.WriteLine("(1) - Soma");
    Console.WriteLine("(2) - Subtração");
    Console.WriteLine("(3) - Multiplicação");
    Console.WriteLine("(4) - Divisão");

}