
using System.ComponentModel.DataAnnotations;

namespace cadastro_de_contatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "Digite o nome do contato!")]
        public string Nome { get; set; } = string.Empty;
        [Required(ErrorMessage = "Digite o e-mail do contato!")]
        [EmailAddress(ErrorMessage = "O e-mail informado nao é valido!")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Digite o celular do contato!")]
        [Phone(ErrorMessage = "O celular informado nao e valido!")]
        public string Celular { get; set; } = string.Empty;

    }
}
