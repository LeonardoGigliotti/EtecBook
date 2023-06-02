using System.ComponentModel.DataAnnotations;


namespace EtecBookAPI.DataTransferObjects;

    public class LoginDto
    {
        [Required(ErrorMessage = "Informe o Email ou Nome do Usuário")]
        [StringLength(100, ErrorMessage = "O Email ou Nome deve possuir no máximo 100 carateres")]
        public string Email { get; set;}

        [DataType(DataType.password)]
        [Required(ErrorMessage = "Informe a Senha")]
        [StringLength(20, ErrorMessage = "O Email ou Nome deve possuir no máximo 20 carateres")]
        public string Password { get; set;}
    }
