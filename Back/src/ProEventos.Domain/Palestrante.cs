using System.Collections.Generic;

namespace ProEventos.Domain
{
    public class Palestrante
    {
        public Palestrante(string nome, string miniCurriculo, string imagemURL, string telefone, string email)
        {
            Nome = nome;
            MiniCurriculo = miniCurriculo;
            ImagemURL = imagemURL;
            Telefone = telefone;
            Email = email;

            RedesSociais = new List<RedeSocial>();
            PalestrantesEventos = new List<PalestranteEvento>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string MiniCurriculo { get; set; }
        public string ImagemURL { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public IEnumerable<RedeSocial> RedesSociais { get; set; }
        public IEnumerable<PalestranteEvento> PalestrantesEventos { get; set; }

    }
}