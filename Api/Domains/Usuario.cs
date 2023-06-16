using System;

namespace Api.Domains
{
    public partial class Usuario
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public int Idade { get; set; }
    }
}