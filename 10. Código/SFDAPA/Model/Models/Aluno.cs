using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
namespace Model.Models
{
    public class Aluno
    {

        public int Codigo { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }


        public Aluno()
        {
        }

        public Aluno(int Codigo, String Nome, String Email, String Senha)
        {
            this.Codigo = Codigo;
            this.Nome = Nome;
            this.Email = Email;
            this.Senha = Senha;
        }

        public void EntrarNaTurma()
        {
            // TODO implement here
        }

        public void VisualizarTurma()
        {
            // TODO implement here
        }

        public void VisualizarPerguntas()
        {
            // TODO implement here
        }

        public void ResponderPerguntas()
        {
            // TODO implement here
        }

        public void VisualizarFeedback()
        {
            // TODO implement here
        }

        public void ResponderFeedback()
        {
            // TODO implement here
        }

    }
}