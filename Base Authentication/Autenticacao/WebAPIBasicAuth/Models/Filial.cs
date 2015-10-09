using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIBasicAuth.Models
{
    public class Filial
    {
        public String Telefone { get; set; }
        public String Endereco { get; set; }
        public String Bairro { get; set; }
        public String UF { get; set; }
        public String Cidade { get; set; }
    }

    public class ListaFilial
    {
        public List<Filial> Filial { get; set; }
    }
}