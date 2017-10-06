using System.ComponentModel.DataAnnotations;

namespace Model.Models.Account
{
    public class LoginModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "O login é obrigatório.")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Deve possuir uma quantidade de caracteres entre 5 e 20.")]
        [RegularExpression(@"^[a-zA-Z0-9_]{5,20}$", ErrorMessage = "Digite um login válido. Use letras, números e underscore ( _ ).")]
        public string Login { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A senha é obrigatória.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Deve possuir uma quantidade de caracteres entre 5 e 100.")]
        [RegularExpression(@"^[a-zA-Z0-9_@#$%&]{5,100}$", ErrorMessage = "Digite uma senha válida. Use letras, números e os caracteres especiais _ @ # $ % &.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Display(Name = "Lembrar-me?")]
        public bool LembrarMe { get; set; }
    }

    public class SenhasModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Senha atual é obrigatória.")]
        [StringLength(100, ErrorMessage = "A senha deve possuir, pelo menos, 5 caracteres em seu tamanho.", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [RegularExpression(@"^[a-zA-Z0-9_@#$%&]{5,100}$", ErrorMessage = "Digite uma senha válida. Use letras, números e os caracteres especiais _ @ # $ % &.")]
        [Display(Name = "Senha Atual")]
        public string SenhaAtual { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Nova senha é obrigatória.")]
        [StringLength(100, ErrorMessage = "A senha deve possuir, pelo menos, 5 caracteres em seu tamanho.", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [RegularExpression(@"^[a-zA-Z0-9_@#$%&]{5,100}$", ErrorMessage = "Digite uma senha válida. Use letras, números e os caracteres especiais _ @ # $ % &.")]
        [Display(Name = "Nova Senha")]
        public string NovaSenha { get; set; }

        [Required(ErrorMessage = "Senha de confirmação é obrigatória.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirme a Nova Senha")]
        [System.ComponentModel.DataAnnotations.Compare("NovaSenha", ErrorMessage = "A nova senha e sua confirmação não são correspondentes.")]
        public string ConfirmaNovaSenha { get; set; }
    }
}