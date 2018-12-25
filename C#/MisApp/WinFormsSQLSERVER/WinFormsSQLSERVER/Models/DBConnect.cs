namespace WinFormsSQLSERVER.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBConnect : DbContext
    {
        public DBConnect()
            : base("name=DBConnect")
        {
        }

        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Data> Data { get; set; }
        public virtual DbSet<Tres> Tres { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tres>()
                .Property(e => e.x1)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x2)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x3)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x4)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x5)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x6)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x7)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x8)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x9)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x10)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x11)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x12)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x13)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x14)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x15)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x16)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x17)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x18)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x19)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x20)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x21)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x22)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x23)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x24)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x25)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x26)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x27)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x28)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x29)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x30)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x31)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x32)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x33)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x34)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x35)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x36)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x37)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x38)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x39)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x40)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x41)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x42)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x43)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x44)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x45)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x46)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x47)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x48)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x49)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x50)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x51)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x52)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x53)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x54)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x55)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x56)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x57)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x58)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x59)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x60)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x61)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x62)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x63)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x64)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x65)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x66)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x67)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x68)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x69)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x70)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x71)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x72)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x73)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x74)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x75)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x76)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x77)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x78)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x79)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x80)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x81)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x82)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x83)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x84)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x85)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x86)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x87)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x88)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x89)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x90)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x91)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x92)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x93)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x94)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x95)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x96)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x97)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x98)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x99)
                .IsFixedLength();

            modelBuilder.Entity<Tres>()
                .Property(e => e.x100)
                .IsFixedLength();
        }
    }
}
