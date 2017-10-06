
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
    public class Aula
    {

        [Key]
        public int Codigo { get; set; }

        [Required]
        [DataType (DataType.DateTime)]
        public DateTime Data { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 3)]
        [DataType(DataType.Text)]
        [Display(Name = "Título")]
        public String Título { get; set; }

        public Turma turma { get; set; }

        public Aula()
        {
        }

        public Aula(int Codigo, DateTime Data, int CodigoTurma, String Titulo, Turma turma)
        {
            this.Codigo = Codigo;
            this.Data = Data;
            this.Título = Titulo;
            this.turma = turma;
        }

    }
}