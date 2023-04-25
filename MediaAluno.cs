using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_de_aluno
{
    public class MediaAluno
    {

        public string nome;
        public string curso;
        public int idade;
        public string RG;
        public string bolsista;
        public float mediaFinal;
        public float valorMensalidade;


        static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
        {
            Console.Write(texto);

            for (int i = 0; i < quantidadePontinhos; i++)
            {
                Console.Write($".");
                Thread.Sleep(tempo);
            }
        }



        public float Bolsista()
        {
            if (bolsista == "sim")
            {
                if (mediaFinal > 8)
                {
                    Console.WriteLine(@$"
    O desconto aplicado será de 50%");
                    float valorComDesconto = (valorMensalidade / 2);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@$"
    O valor com desconto será de: R$ {valorComDesconto}");
                    Console.ResetColor();

                    BarraCarregamento(@"
    Imprimindo dados", 8, 500);

                    VerDados();

                }
                else if (mediaFinal > 6 && mediaFinal <= 8)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@$"
    O desconto aplicado será de 30%");
                    Console.ResetColor();
                    float valorComDesconto = (valorMensalidade * 0.7F);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@$"
    O valor com desconto será de R$ {valorComDesconto}");
                    Console.ResetColor();
                    BarraCarregamento(@"
    Imprimindo dados", 8, 500);

                    VerDados();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"VOÇÊ NÃO TERÁ DIREITO A DESCONTO!");
                    Console.ResetColor();

                    BarraCarregamento(@"
    Imprimindo dados", 8, 500);

                    VerDados();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@$"
    VOÇÊ NÃO TERÁ DIREITO A DESCONTO!");
                Console.ResetColor();

                BarraCarregamento(@"
    Imprimindo dados", 8, 500);

                VerDados();

            }
            return 0;
        }



        public void VerMediaFinal()
        {
            Console.WriteLine($"média final do {nome}: {mediaFinal}");
        }


        public void VerMensalidade()
        {
            Console.WriteLine($" Mensalidade paga pelo aluno: {valorMensalidade}");
        }


        public void VerDados()
        {
            Console.WriteLine(@$"
            
    Dados do aluno:

    Nome: {nome}

    Curso: {curso}
            
    Idade: {idade}
            
    RG: {RG}
            
    Bolsista: {bolsista}
            
    Media: {mediaFinal}
            
    Mensalidade: {valorMensalidade}
            ");

        }

    }
}




