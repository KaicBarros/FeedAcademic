
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
namespace Model.Models
{
    public class SubmissaoResposta
    {
        public int Codigo { get; set; }
        public int CodigoPergunta { get; set; }
        public char[] Respostas { get; set; }


        public SubmissaoResposta()
        {
        }

        public SubmissaoResposta(int Codigo, int CodigoPergunta, char[] Respostas)
        {
            this.Codigo = Codigo;
            this.CodigoPergunta = CodigoPergunta;
            this.Respostas = Respostas;
        }

        public void Enviar()
        {
            // TODO implement here
        }

        public void Alterar()
        {
            // TODO implement here
        }

        public void Visualizar()
        {
            // TODO implement here
        }

    }
}