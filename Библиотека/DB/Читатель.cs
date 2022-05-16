namespace Библиотека.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Читатель
    {
        [Key]
        public int ID_читателя { get; set; }

        [StringLength(50)]
        public string ФИО { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Телефон { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Дата_взятия { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Дата_возврата { get; set; }

        public int? Одолженные_книги { get; set; }

        [StringLength(50)]
        public string Состояние { get; set; }

        [StringLength(50)]
        public string Адрес { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Паспортные_данные { get; set; }

        public virtual Книги Книги { get; set; }
    }
}
