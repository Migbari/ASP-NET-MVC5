using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TreinamentoMVC.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage = "De 5 a 50 caracteres")]
        public string Observacoes { get; set; }
        [Range(18, 70, ErrorMessage = "Idade entre 18 e 70 anos apenas")]
        public int Idade { get; set; }
        [Display(Name = "Email ou Telefone")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$|^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}", ErrorMessage = "Digite um email ou número válido")]
        public string Email { get; set; }
        [Display(Name = "Nome de Login")]
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Deve conter letras de 5 a 15 caracteres")]
        [Required(ErrorMessage = "O login é obrigatório")]
        [Remote("LoginUnico", "Usuario", ErrorMessage = "Este login já existe")]
        public string Login { get; set; }
        [Required(ErrorMessage = "A Senha é obrigatória")]
        public string Senha { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "Senhas não são iguais")]
        public string ConfirmaSenha { get; set; }

    }
}