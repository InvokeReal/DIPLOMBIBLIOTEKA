namespace Библиотека.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Книги
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Книги()
        {
            Читатель = new HashSet<Читатель>();
        }

        [Key]
        public int ID_книги { get; set; }

        [StringLength(50)]
        public string Название { get; set; }

        public decimal? Цена { get; set; }

        [StringLength(50)]
        public string Жанр { get; set; }

        [StringLength(50)]
        public string Издатель { get; set; }

        [StringLength(50)]
        public string Дата_издания { get; set; }

        public int? В_наличии { get; set; }

        [StringLength(200)]
        public string Описание { get; set; }

        [StringLength(50)]
        public string Фото { get; set; }

        public int? Поставщик_книг { get; set; }

        public virtual Поставщики Поставщики { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Читатель> Читатель { get; set; }
    }
}
