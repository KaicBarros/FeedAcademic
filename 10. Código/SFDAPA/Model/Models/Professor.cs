
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
    public class Professor
    {

        [Key]
        public int Codigo { get; set; }

        [Required(ErrorMessageResourceName = "EmailRequerido", ErrorMessageResourceType = typeof(Resources.Mensagens))]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        public String Email { get; set; }

        public String Instituição { get; set; }

        [Required(ErrorMessageResourceName = "NomeRequerido", ErrorMessageResourceType = typeof(Resources.Mensagens))]
        [StringLength(50, MinimumLength = 10)]
        [DataType(DataType.Text)]
        [Display(Name = "Nome completo")]
        public String Nome { get; set; }


        [Required(ErrorMessageResourceName = "SenhaRequerida", ErrorMessageResourceType = typeof(Resources.Mensagens))]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public String Senha { get; set; }

        public Professor()
        {

        }

        public Professor(int Codigo, String Email, String Instituicao, String Nome, String Senha)
        {
            this.Codigo = Codigo;
            this.Email = Email;
            this.Instituição = Instituição;
            this.Nome = Nome;
            this.Senha = Senha;
        }


        public void CadastrarTurma()
        {
            // TODO implement here
        }

        public void VisualizarTurma()
        {
            // TODO implement here
        }

        public void CadastrarAssunto()
        {
            // TODO implement here
        }

        public void CadastrarAula()
        {
            // TODO implement here
        }

        public void CadastrarPergunta()
        {
            // TODO implement here
        }

    }
}