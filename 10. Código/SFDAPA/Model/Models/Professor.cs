
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
namespace Model.Models
{
    public class Professor
    {

        public int Codigo { get; set; }
        public String Email { get; set; }
        public String Instituição { get; set; }
        public String Nome { get; set; }
        public String Senha { get; set; }

        public Professor()
        {

        }

        public Professor(int Codigo, String Email, String Instituicao, String Nome, String Senha)
        {
            this.Codigo = Codigo;
            this.Email = Email;
            this.Instituição = Instituição;
            this.Nome = Nome;
            this.Senha = Senha;
        }


        public void CadastrarTurma()
        {
            // TODO implement here
        }

        public void VisualizarTurma()
        {
            // TODO implement here
        }

        public void CadastrarAssunto()
        {
            // TODO implement here
        }

        public void CadastrarAula()
        {
            // TODO implement here
        }

        public void CadastrarPergunta()
        {
            // TODO implement here
        }

    }
}