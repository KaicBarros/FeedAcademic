
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Models
{
    public class Analise
    {
        public int Codigo { set; get; }

        public string analise { set; get; }
        public Analise()
        {
        }

        public Analise(int Codigo, string analise)
        {
            this.Codigo = Codigo;
            this.analise = analise;
        }
    }
}