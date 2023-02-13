using System;
using System.ComponentModel.DataAnnotations;

namespace API_Schedule.Infrastucture.Entities
{
    public class ClassEvento
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data_Evento { get; set; }
        public string Descricao { get; set; }
        public int Tempo_Notificacao { get; set; }
    }
}
