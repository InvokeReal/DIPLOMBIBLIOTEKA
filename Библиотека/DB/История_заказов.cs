namespace Библиотека.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class История_заказов
    {
        [Key]
        public int ID_заказа { get; set; }

        public int? Количество { get; set; }

        [StringLength(50)]
        public string Адрес_доставки { get; set; }

        [StringLength(50)]
        public string ФИО_получателя { get; set; }

        [StringLength(50)]
        public string Статус { get; set; }

        public decimal? Цена { get; set; }

        [StringLength(50)]
        public string Название_книги { get; set; }
    }
}
