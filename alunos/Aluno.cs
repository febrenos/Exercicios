using System;

namespace alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("FELIPE","527.346.738.-19");
            Aluno aluno2 = new Aluno("maheus nascimento","777.777.777-77","prog1");
            Console.WriteLine("Nome:" +     aluno1.Nome);
            Console.WriteLine("Curso: " +   aluno1.Curso);
            Console.WriteLine("Cpf: " +     aluno1.Cpf);

            Console.WriteLine("Nome:" +   aluno2.Nome);
            Console.WriteLine("Curso: " + aluno2.Curso);
            Console.WriteLine("Cpf: " +   aluno2.Cpf);

            Console.Write("Entre com o Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Entre com o cpf: " );
            string cpf = Console.ReadLine();
            Console.Write("Entre com o curso: ");
            string curso = Console.ReadLine();
            Console.Write("Entre com a nota: ");
            int nota = int.Parse(Console.ReadLine());
            Console.Write("Entre com o bimestre: ");
            int bimestre = int.Parse(Console.ReadLine());
            Aluno aluno3 = new Aluno(nome,cpf,curso);
            aluno3.setNotas(bimestre,nota);
        }
    }
}