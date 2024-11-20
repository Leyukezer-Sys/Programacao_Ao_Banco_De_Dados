using System.ComponentModel.DataAnnotations;

namespace AppGestaoFacil.DTO
{
    public class ServidorDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Nome deve ter no minimo 5 caracteres")]
        public string Nome { get; set; }

        [Required]
        [Length(14, 14, ErrorMessage = "O cpf deve ter no minimo 14 caracteres")]
        public string CPF { get; set; }

        [Required]
        public int Siape { get; set; }
    }
}
