using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models
{
    [Table("osoba")]
    public class Osoba
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nazwisko")]
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        [StringLength(100)]
        public string Nazwisko { get; set; } = string.Empty;

        [Column("plec_id")]
        public int PlecId { get; set; }

        [ForeignKey(nameof(PlecId))]
        public Plec? Plec { get; set; }
    }
}
