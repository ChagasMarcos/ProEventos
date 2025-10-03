using System;

namespace ProEventos.Domain
{
    public class RedeSocial
    {
        public RedeSocial(string nome, string url, int? eventoId = null, int? palestranteId = null)
        {
            // --- Lógica de Validação XOR ---
            
            // 1. Não pode estar associada a nada (os dois nulos)
            if (!eventoId.HasValue && !palestranteId.HasValue)
            {
                throw new ArgumentException("A Rede Social deve estar associada a um Evento ou a um Palestrante.");
            }

            // 2. Não pode estar associada aos dois (os dois preenchidos)
            if (eventoId.HasValue && palestranteId.HasValue)
            {
                throw new ArgumentException("A Rede Social não pode estar associada a um Evento E a um Palestrante simultaneamente.");
            }
            
            // --- Atribuição de Valores ---
            Nome = nome;
            URL = url;
            EventoId = eventoId;
            PalestranteId = palestranteId;
        }
        
        // Construtor padrão exigido por alguns ORMs (pode ser private se você não quiser usá-lo)
        public RedeSocial() {}

        public int Id { get; set; }
        public string Nome { get; set; }
        public string URL { get; set; }
        public int? EventoId { get; set; }
        public Evento Evento { get; set; }
        public int? PalestranteId { get; set; }
        public Palestrante Palestrante { get; set; }
    }
}