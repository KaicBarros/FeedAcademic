
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
namespace Model.Models
{
    public class Aula
    {

        public int Codigo { get; set; }
        public DateTime Data { get; set; }
        public int CodigoTurma { get; set; }
        public String Título { get; set; }

        public Aula()
        {
        }

        public Aula(int Codigo, DateTime Data, int CodigoTurma, String Titulo)
        {
            this.Codigo = Codigo;
            this.Data = Data;
            this.CodigoTurma = CodigoTurma;
            this.Título = Titulo;

        }

    }
}