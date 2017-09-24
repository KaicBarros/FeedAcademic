
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
namespace Model.Models
{
    public class Assunto
    {

        public int Codigo { get; set; }
        public String Nome { get; set; }
        public int CodigoAula { get; set; }

        public Assunto(int Codigo, String Nome, int CodigoAula)
        {
            this.Codigo = Codigo;
            this.Nome = Nome;
            this.CodigoAula = CodigoAula;
        }



    }
}