
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
    public class Assunto
    {

        [Key]
        public int Codigo { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "Nome do assunto")]
        public String Nome { get; set; }
        

        public Aula Aula { get; set; }

        public Assunto()
        {

        }

        public Assunto(int Codigo, String Nome)
        {
            this.Codigo = Codigo;
            this.Nome = Nome;
        }



    }
}