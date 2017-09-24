
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
namespace Model.Models
{
    public class Turma
    {

        public int Codigo { get; set; }
        public String NomeTurma { get; set; }
        public String EmailProfessor { get; set; }
        public String[] EmailAlunos { get; set; }

        public Turma()
        {
        }

        public Turma(int Codigo, String NomeTurma, String EmailProfessor, String[] EmailAlunos)
        {
            this.Codigo = Codigo;
            this.NomeTurma = NomeTurma;
            this.EmailProfessor = EmailProfessor;
            this.EmailAlunos = EmailAlunos;
        }


        public void GetNomeDaTurma()
        {
            // TODO implement here
        }

        /**
         * 
         */
        public void SetNomeDaTurma()
        {
            // TODO implement here
        }

        /**
         * 
         */
        public void GetNomeDoProfessor()
        {
            // TODO implement here
        }

    }
}