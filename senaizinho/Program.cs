
using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int limiteAlunos = 10;
            int limiteSalas = 10;
            Aluno[] alunos = new Aluno[100];
            Sala[] salas   = new Sala[10];
            //bool querSair;




        }

        public void CadastrarAluno(Alunos[] alunos, int totalAluno, int alunosCadastrados)
        {
            if(totalAluno < alunosCadastrados)
            {
                Console.WriteLine("cadastro de alunos");
                Console.WriteLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("DT Nascimento:");
                DateTime dtNascimento = DateTime.Parse(Console.ReadLine());

                Aluno novoAluno = new Aluno();
                novoAlunoAluno.Nome = nome;
                novoAluno.DataNascimento = dtNascimento;

                int index = 0;
                foreach(Alunos aluno in aluno)
                {
                    if (aluno == null)
                    {
                        aluno[index] = novoAluno;
                        break;
                    }
                    index ++;
                }
                alunosCadastrados++;
            }
        }
        public void CadastrarSala()
        {
            
        }
        public void AlocarAluno()
        {
            
        }     
        public void RemoverAluno()
        {
            
        }
        public void VerificarSalas()
        {
            
        }
        public void VerificarAlunos()
        {

        }
    }   
}