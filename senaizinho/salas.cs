
using System;

namespace teste
{
    class Sala
    {
        public int capacidadeAtual;
        public int capacidadeTotal;
        public int numeroSala;
        public string [] Alunos;
        public string listaAlunos;

        public Sala(int numeroSala, int capacidadeTotal)
        {
            this.numeroSala = numeroSala;
            this.capacidadeTotal = capacidadeTotal;
            this.capacidadeAtual = this.capacidadeTotal;
            this.Alunos = new string[capacidadeTotal];

        }

        public string AlocarAluno(string NomeAluno)
        {
            int index = 0;

            if(this.capacidadeAtual > 0)
            {
                foreach(string aluno in this.Alunos)
                {
                    if (aluno == "")
                    {
                        this.Alunos[index] = NomeAluno;
                        break;
                    }
                    index++;
                }
                this.capacidadeAtual--;
                return "Ok";
            } else 
                return "LOTADO";
        }
        public string RemoveAluno(string NomeAluno)
        {
            int index = 0;
            if(this.capacidadeAtual == this.capacidadeTotal)
            {
                return "SALA VAZIA";
            }
            foreach(string aluno in this.Alunos)
            {
                if(NomeAluno == aluno)
                {
                    this.Alunos[index] = "";
                    return "Ok";
                }
            }
            return "NAO ENCONTRADO";
        }
        public string MostrarAlunos()

        {
            foreach(string aluno in this.Alunos)
            {

            string listaAlunos= "";
                if(aluno != "")
                {
                    listaAlunos = listaAlunos + aluno + " ";
                }
            }
            listaAlunos.TrimEnd();
            return listaAlunos;
        }
    }
}