using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameTest2.Models
{
    class GameMap: EntityTypeConfiguration<Game>
    {
        public GameMap()
        {
            ToTable("Games");

            HasKey(k => new { k.Id });

            // Attenzione: senza questa impostazione tenta di usare il campo Id come un "identity" !!! :(
            Property(p => p.Id).
                HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // demo gestione concurrency
            Property(p => p.RowVersion)
                .IsFixedLength()
                .HasMaxLength(8)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)
                .IsRowVersion();
        }
    }
}
