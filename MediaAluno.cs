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

        public void VerMediaFinal()
        {
            Console.WriteLine($"média final do aluno: {mediaFinal}");
        }
        

        public void VerMensalidade()
        {
            Console.WriteLine($" Mensalidade paga pelo aluno: {valorMensalidade}");
        }

        
    }
}




