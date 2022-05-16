namespace Библиотека.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Сотрудники
    {
        [Key]
        public int ID_сотрудника { get; set; }

        [StringLength(50)]
        public string ФИО { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Дата_рождения { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Телефон { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ИНН { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Паспортные_данные { get; set; }

        [StringLength(50)]
        public string Адрес_проживания { get; set; }

        public decimal? Оклад { get; set; }

        [StringLength(50)]
        public string Должность { get; set; }

        [StringLength(50)]
        public string login { get; set; }

        [StringLength(50)]
        public string password { get; set; }
    }
}
