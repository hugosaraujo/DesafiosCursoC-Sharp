/*
    1- Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
    2- Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.
    3- Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.
    4- Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.
    
*/

//Resolução pergunta 3


//Resolução pergunta 2
Dictionary<string, int> listaDeProdutos = new Dictionary<string, int>();
listaDeProdutos.Add("Caneta Preta", 10);
listaDeProdutos.Add("Caneta Vermelha", 2);

foreach (var produto in listaDeProdutos)
{
    string nomeProduto = produto.Key;
    int quantidadeEmEstoque = produto.Value;
    Console.WriteLine($"{nomeProduto} = {quantidadeEmEstoque} unidades");
}

//Resolução da pergunta 1
Dictionary<string, List<double>> alunos = new Dictionary<string, List<double>>()
{
    {"Steve", new List<double>{10, 9, 9 }}
};
alunos.Add("Alice", new List<double>{10, 9, 6});
alunos.Add("João", new List<double>{8, 9.5, 6.5});

// foreach (var aluno in alunos)
// {
//     string nomeAluno = aluno.Key;
//     var listaDeNotas = aluno.Value;
//     double mediaNotas = listaDeNotas.Average();
//
//     Console.WriteLine($"A média do {nomeAluno} é {mediaNotas}");
// }