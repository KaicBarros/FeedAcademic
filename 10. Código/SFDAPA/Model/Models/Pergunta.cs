
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Model.App_GlobalResources;
using System.ComponentModel.DataAnnotations;


namespace Model.Models
{
    public class Pergunta
    {

        public int Codigo { get; set; }
        public String Questao { get; set; }
        public List<Alternativa> Alternativas { get; set; }
        public Assunto Assunto { get; set; }

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