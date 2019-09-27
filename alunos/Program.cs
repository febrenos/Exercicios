﻿using System;

namespace alunos
{
    class Aluno{
        //Propriedades
        public string Nome;
        public string Curso;
        public string Cpf;
        public int [] Notas;

        //construtor
        public Aluno(string Nome, string Cpf){
            this.Nome = Nome;
            this.Cpf = Cpf;
        }

        public Aluno(string Nome, string Cpf, string Curso){
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Curso = Cpf;
        }
    }
}
