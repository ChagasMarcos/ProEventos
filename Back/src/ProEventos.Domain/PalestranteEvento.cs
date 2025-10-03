namespace ProEventos.Domain
{
    public class PalestranteEvento
    {
        public PalestranteEvento(int palestranteId, int eventoId)
        {
            PalestranteId = palestranteId;
            EventoId = eventoId;
        }

        public int PalestranteId { get; set; }
        public Palestrante Palestrante { get; set; }

        public int EventoId { get; set; }
        public Evento Evento { get; set; }
    }
}