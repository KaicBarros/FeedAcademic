
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
namespace Model.Models
{
    public class PerguntaFeedback
    {

        public int Codigo { get; set; }
        public String Questao { get; set; }

        public PerguntaFeedback()
        {
        }

        public PerguntaFeedback(int Codigo, String Questao)
        {
            this.Codigo = Codigo;
            this.Questao = Questao;
        }
    }
}