using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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