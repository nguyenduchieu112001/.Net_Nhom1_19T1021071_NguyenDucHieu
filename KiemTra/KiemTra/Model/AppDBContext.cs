using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace KiemTra.Model
{
    public partial class AppDBContext : DbContext
    {
        public AppDBContext()
            : base("name=AppDBContext")
        {
        }

        public virtual DbSet<DanhBa> DanhBas { get; set; }
        public virtual DbSet<Nhom> Nhoms { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nhom>()
                .HasMany(e => e.DanhBas)
                .WithOptional(e => e.Nhom)
                .HasForeignKey(e => e.IDNhom);
        }
    }
}
