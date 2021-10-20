using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stripboeken_DAL
{
    public class Genres
    {
        [Key]
        public int GenreID { get; set; }

        [Required]
        public string Naam { get; set; }

        [Required]
        public string Beschrijving { get; set; }

        public ICollection<ReeksenGenre> Reeksen { get; set; }
    }
}