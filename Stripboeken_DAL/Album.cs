using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stripboeken_DAL
{
    public class Albums
    {
        [Key]
        public int AlbumID { get; set; }

        [Required]
        public int Reeksnummer { get; set; }

        [Required]
        public string Titel { get; set; }

        public string Beschrijving { get; set; }

        [Required]
        public int AlbumtypeID { get; set; }

        [Required]
        public bool Favoriet { get; set; }

        public byte Waardering { get; set; }
        public DateTime Uitgiftedatum { get; set; }

        [Required]
        public bool EersteDruk { get; set; }

        [Required]
        public string Kaft { get; set; }

        [Required]
        public string Inkleuring { get; set; }

        [Required]
        public int Paginas { get; set; }

        [Required]
        public decimal Breedte { get; set; }

        [Required]
        public decimal Hoogte { get; set; }

        [Required]
        public string Taal { get; set; }

        public byte Conditie { get; set; }

        [Column(TypeName = "money")]
        public decimal Inbedrag { get; set; }

        [Column(TypeName = "money")]
        public decimal Waarde { get; set; }

        [Column(TypeName = "money")]
        public decimal Uitbedrag { get; set; }

        [Required]
        public DateTime LaatsteUpdate { get; set; }

        [Required]
        public int ReeksID { get; set; }

        [Required]
        public int UitgeverID { get; set; }

        public int EventIDIn { get; set; }
        public int EventIDUit { get; set; }

        public Reeksen Reeks { get; set; }
    }
}