namespace Библиотека.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Поставщики
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Поставщики()
        {
            Книги = new HashSet<Книги>();
        }

        [Key]
        public int ID_поставщика { get; set; }

        [StringLength(50)]
        public string Наименование { get; set; }

        [StringLength(50)]
        public string Страна { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ИНН { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Книги> Книги { get; set; }
    }
}
