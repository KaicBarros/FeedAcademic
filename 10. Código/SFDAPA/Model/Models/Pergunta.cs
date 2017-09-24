
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Models
{
    public class Pergunta
    {

        public int Codigo { get; set; }
        public String Questao { get; set; }
        public Alternativa[] Alternativas { get; set; }
        public int CodigoAssunto { get; set; }

        public Pergunta()
        {
        }


        public Pergunta(int Codigo, String Questao, Alternativa[] Alternativas, int CodigoAssunto)
        {
            this.Codigo = Codigo;
            this.Questao = Questao;
            this.Alternativas = Alternativas;
            this.CodigoAssunto = CodigoAssunto;
        }

    }
}