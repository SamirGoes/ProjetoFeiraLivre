namespace FeiraLivre.Api.Models
{
    public class Feira
    {
        public int Id { get; set; }

        public long Longitude { get; set; }

        public long Latitude { get; set; }

        public long SetCens { get; set; }

        public long Areap { get; set; }

        public int CodDist { get; set; }

        public string Distrito { get; set; }

        public int CodSubprefitura { get; set; }

        public string SubPrefeitura { get; set; }

        public Regiao Regiao05 { get; set; }

        public Regiao Regiao08 { get; set; }

        public string NomeFeira { get; set; }

        public string Registro { get; set; }

    }

    public class Regiao
    {
        public string NomeRegiao { get; set; }
    }
}