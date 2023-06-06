using System;

namespace Api.Domains
{
    public partial class Eventos
    {

        public int Id { get; set; }
        public string NomeEvento { get; set; }
        public int QuantidadeParticipantes { get; set; }
        public string DataEvento { get; set; }
        public string DuracaoEvento { get; set; }
        public string CriadorEvento { get; set; }

    }
}