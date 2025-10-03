using System;
using System.Collections.Generic;

namespace ProEventos.Domain
{
    public class Evento
    {

            public Evento(string local, string tema, int qtdPessoas, string imagemURL, string telefone, string email)
            {
                Local = local;
                Tema = tema;
                QtdPessoas = qtdPessoas;
                ImagemURL = imagemURL;
                Telefone = telefone;
                Email = email;
                
                //Opcional: Você pode inicializar as coleções aqui para garantir que nunca sejam null
                Lotes = new List<Lote>();
                RedesSociais = new List<RedeSocial>();
                PalestrantesEventos = new List<PalestranteEvento>();
            }
                

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