using System;

namespace ProEventos.Domain
{
    public class Lote
    {

         public Lote(string nome, decimal preco, int quantidade, int eventoId)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            EventoId = eventoId;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public int Quantidade { get; set; }
        public int EventoId { get; set; }
        public Evento Evento { get; set; }
        
    }
}