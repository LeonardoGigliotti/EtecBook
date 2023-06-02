using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtecBookAPI.DataTransferObjects
{    public class LoginDto
    {
        [Required(ErrorMessage = "Informe o Email ou Nome do Usuário")]
        [StringLength(60, ErrorMessage = "O Email ou Nome deve possuir no máximo 60 carateres")]
        public string Name { get; set;}

        [Required(ErrorMessage = "Informe o Email ou Nome do Usuário")]
        [EmailAddress(ErrorMessage = "Informe um Email Válido!")]
        [StringLength(100, ErrorMessage = "O Email deve possuir no máximo 100 carateres")]
        public string Email { get; set;}


        [DataType(DataType.password)]
        [Required(ErrorMessage = "Informe a Senha")]
        [StringLength(20, MinimumLegth = 6,
            ErrorMessage = "A Senha deve possuir no mínimo 6 e máximo 20 carateres")]
        public string Password { get; set;}
    }
}    
