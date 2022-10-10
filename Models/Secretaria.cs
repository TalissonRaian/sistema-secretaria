using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace secretaria_plataforma.Models
{
    public class Secretaria
    {
        List<string> novoAluno = new List<string>();
        
        public void MatriculaAluno()
        {
            Console.WriteLine("Digite o nome do novo(a) aluno(a):");
             novoAluno.Add(Console.ReadLine());
        }
       

       public void AlunoMatriculados()
       {
        int[] position;
        position = new int[5];
        if (novoAluno.Any())
        {
            Console.WriteLine("Os alunos matriculados são:");
            foreach (string listaAlunos in novoAluno)
            {
                
                Console.WriteLine($"{position} {listaAlunos} =");
            }
            Console.WriteLine("Deseja trancar a matricula \nde algum dos aluno? \n1-SIM \n2-NÃO");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                TrancarMatricula();
                break;
            
                default:
                Console.WriteLine("Retornando ao menu!");
                break;
            }
        }
       }

       public void TrancarMatricula()
       {
        Console.WriteLine("Digite o nome do aluno \nque deseja trancar a matricula:");

        string alunoRemove = Console.ReadLine();

        if (novoAluno.Any(x => x.ToUpper() == alunoRemove.ToUpper()))
        {
            Console.WriteLine($"Matricula do aluno(a) {alunoRemove} trancada!");
            novoAluno.Remove(alunoRemove);
        }
        
       }
    }
}