using System;
using System.ComponentModel.DataAnnotations;

namespace API_Schedule.Infrastucture.Entities
{
    
    public class ClassMeta
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime Data_Inicio  { get; set; }
        public DateTime Data_Fim  { get; set; }
        public int Meta { get; set; }
        public string Uni_Medida { get; set; }
        public int Tempo_Notificacao { get; set; }
    }
}
