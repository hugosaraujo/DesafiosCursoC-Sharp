/*
    1- Criar uma variável chamada curso, e guarde nela o nome do curso estudado.
    2- Mostrar o conteúdo da variável curso no console.
    3- Criar uma variável chamada nome e outra chamada sobrenome e guardar nelas seu nome e sobrenome.
    4- Mostrar na tela o nome dos instrutores do curso.
*/

string curso = "C# Fundamentos";
Console.WriteLine(curso);

string nome = "Anthony"; 
string sobrenome = "Edwards";
string nomeCompleto = nome + " " + sobrenome;
Console.WriteLine(nomeCompleto);


string instrutorGui = "Guilherme";
string instrutorDaniel = "Daniel";

Console.WriteLine($"Curso {curso} com os instrutores {instrutorDaniel} e {instrutorGui}");