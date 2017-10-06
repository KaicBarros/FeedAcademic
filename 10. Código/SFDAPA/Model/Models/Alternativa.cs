using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.App_GlobalResources;
using System.ComponentModel.DataAnnotations;


/**
 * 
 */
namespace Model.Models
{
    public class Alternativa
    {

        public int Codigo { get; set; }
        public String Descricao { get; set; }
        public char Resposta { get; set; }
        public int Pergunta { get; set; }

        public Alternativa()
        {
        }

        public Alternativa(int Codigo, String Descricao, char Resposta)
        {
            this.Codigo = Codigo;
            this.Descricao = Descricao;
            this.Resposta = Resposta;
        }


    }
}