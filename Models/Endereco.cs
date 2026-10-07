using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorViaCep.Models
{
    public class Endereco
    {
        public String Cep {get; set;}
        public String Logradouro {get; set;}
        public String Complemento {get; set;}
        public String Bairro {get; set;}
        public String Localidade {get; set;}
        public String Uf {get; set;}
    }
}