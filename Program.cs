// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.

//Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

using Cadastro_de_aluno;

MediaAluno Media = new MediaAluno();



Console.Write(@$"Digite o nome do aluno: 
");
Media.nome = Console.ReadLine();

Console.Write(@$"Digite o nome do curso: 
");
Media.curso = Console.ReadLine();

Console.Write(@$"Digite a idade do aluno: 
");
Media.idade = int.Parse(Console.ReadLine());

Console.Write(@$"Digite o RG do aluno: 
");
Media.RG = Console.ReadLine();

Console.Write(@$"Digite se o aluno é bolsista: (sim ou não) 
");
Media.bolsista = Console.ReadLine();

Console.Write(@$"Digite a média final do aluno: 
");
Media.mediaFinal = float.Parse(Console.ReadLine());

Console.Write(@$"Digite a mensalidade paga pelo aluno: 
");
Media.valorMensalidade = float.Parse(Console.ReadLine());

if (Media.bolsista == "sim")
{
    if (Media.mediaFinal > 8)
    {

    }
    else if (Media.mediaFinal > 6 && Media.mediaFinal <= 8)
    {

    }
    else
    {

    }
}
else
{
    Console.WriteLine($"{Media.mediaFinal}");
    
}

