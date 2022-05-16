namespace Библиотека.DB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB")
        {
        }

        public virtual DbSet<История_заказов> История_заказов { get; set; }
        public virtual DbSet<Книги> Книги { get; set; }
        public virtual DbSet<Поставщики> Поставщики { get; set; }
        public virtual DbSet<Сотрудники> Сотрудники { get; set; }
        public virtual DbSet<Читатель> Читатель { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<История_заказов>()
                .Property(e => e.Цена)
                .HasPrecision(8, 0);

            modelBuilder.Entity<Книги>()
                .Property(e => e.Цена)
                .HasPrecision(8, 0);

            modelBuilder.Entity<Книги>()
                .HasMany(e => e.Читатель)
                .WithOptional(e => e.Книги)
                .HasForeignKey(e => e.Одолженные_книги);

            modelBuilder.Entity<Поставщики>()
                .Property(e => e.ИНН)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Поставщики>()
                .HasMany(e => e.Книги)
                .WithOptional(e => e.Поставщики)
                .HasForeignKey(e => e.Поставщик_книг);

            modelBuilder.Entity<Сотрудники>()
                .Property(e => e.Телефон)
                .HasPrecision(11, 0);

            modelBuilder.Entity<Сотрудники>()
                .Property(e => e.ИНН)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Сотрудники>()
                .Property(e => e.Паспортные_данные)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Сотрудники>()
                .Property(e => e.Оклад)
                .HasPrecision(8, 0);

            modelBuilder.Entity<Читатель>()
                .Property(e => e.Телефон)
                .HasPrecision(11, 0);

            modelBuilder.Entity<Читатель>()
                .Property(e => e.Паспортные_данные)
                .HasPrecision(10, 0);
        }
    }
}
