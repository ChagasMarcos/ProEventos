using System;

namespace ProEventos.Domain
{
    public class Lote
    {
        // public Lote(int id, string nome, decimal preco, DateTime? dataInicio, DateTime? dataFim, int quantidade, int eventoId, Evento evento)
        // {
        //     Id = id;
        //     Nome = nome;
        //     Preco = preco;
        //     DataInicio = dataInicio;
        //     DataFim = dataFim;
        //     Quantidade = quantidade;
        //     EventoId = eventoId;
        //     Evento = evento;
        // }

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