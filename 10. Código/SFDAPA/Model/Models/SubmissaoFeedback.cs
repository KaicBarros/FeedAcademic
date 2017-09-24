using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
namespace Model.Models
{
    public class SubmissaoFeedback
    {

        public int Codigo { get; set; }
        public int CodigoFeedback { get; set; }
        public int CodigoPergunta { get; set; }
        public char RespostaFeedback { get; set; }


        public SubmissaoFeedback()
        {

        }

        public SubmissaoFeedback(int Codigo, int CodigoFeedback, int CodigoPergunta, char RespostaFeedback)
        {
            this.Codigo = Codigo;
            this.CodigoFeedback = CodigoFeedback;
            this.CodigoPergunta = CodigoPergunta;
            this.RespostaFeedback = RespostaFeedback;
        }


        public void Enviar()
        {
            // TODO implement here
        }

        public void Visualizar()
        {
            // TODO implement here
        }

    }
}