using System;
using System.Collections.Generic;

namespace ProEventos.Domain
{
    public class Evento
    {
        // public Evento(int id, string local, DateTime? dataEvento, string tema, int qtdPessoas, string lote, string imagemURL, string telefone, string email, IEnumerable<Lote> lotes, IEnumerable<RedeSocial> redesSociais, IEnumerable<PalestranteEvento> palestrantesEventos)
        // {
        //     Id = id;
        //     Local = local;
        //     DataEvento = dataEvento;
        //     Tema = tema;
        //     QtdPessoas = qtdPessoas;
        //     Lote = lote;
        //     ImagemURL = imagemURL;
        //     Telefone = telefone;
        //     Email = email;
        //     Lotes = lotes;
        //     RedesSociais = redesSociais;
        //     PalestrantesEventos = palestrantesEventos;
        // }

        public int Id { get; set; }
        public string Local { get; set; }
        public DateTime? DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string ImagemURL { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public IEnumerable<Lote> Lotes { get; set; }
        public IEnumerable<RedeSocial> RedesSociais { get; set; }
        public IEnumerable<PalestranteEvento> PalestrantesEventos { get; set; }

        
    }
}