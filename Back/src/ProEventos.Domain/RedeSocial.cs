namespace ProEventos.Domain
{
    public class RedeSocial
    {
        // public RedeSocial(int id, string nome, string uRL, int? eventoId, Evento evento, int? palestranteId, Palestrante palestrante)
        // {
        //     Id = id;
        //     Nome = nome;
        //     URL = uRL;
        //     EventoId = eventoId;
        //     Evento = evento;
        //     PalestranteId = palestranteId;
        //     Palestrante = Palestrante;
        // }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string URL { get; set; }
        public int? EventoId { get; set; }
        public Evento Evento { get; set; }
        public int? PalestranteId { get; set; }
        public Palestrante Palestrante { get; set; }
    }
}