using System;
using System.Collections.Generic;
using System.Linq;

using Model.App_GlobalResources;
using System.ComponentModel.DataAnnotations;

/**
 * 
 */
namespace Model.Models
{
    public class Aluno
    {

        [Key]
        public int Codigo { get; set; }

        [Required(ErrorMessageResourceName = "NomeRequerido", ErrorMessageResourceType = typeof(Resources.Mensagens))]
        [StringLength(50, MinimumLength = 10)]
        [DataType(DataType.Text)]
        [Display(Name = "Nome completo")]
        public String Nome { get; set; }


        [Required(ErrorMessageResourceName = "EmailRequerido", ErrorMessageResourceType = typeof(Resources.Mensagens))]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        public String Email { get; set; }

        [Required (ErrorMessageResourceName ="SenhaRequerida", ErrorMessageResourceType = typeof(Resources.Mensagens))]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public String Senha { get; set; }

        
        public Aluno() { }

        public void EntrarNaTurma()
        {
            // TODO implement here
        }

        public void VisualizarTurma()
        {
            // TODO implement here
        }

        public void VisualizarPerguntas()
        {
            // TODO implement here
        }

        public void ResponderPerguntas()
        {
            // TODO implement here
        }

        public void VisualizarFeedback()
        {
            // TODO implement here
        }

        public void ResponderFeedback()
        {
            // TODO implement here
        }

    }
}