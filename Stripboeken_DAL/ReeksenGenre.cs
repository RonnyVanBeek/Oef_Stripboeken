using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stripboeken_DAL
{
    public class ReeksenGenre
    {
        [Key]
        public int ReeksGenreID { get; set; }

        [Required]
        public int ReeksID { get; set; }

        [Required]
        public int GenreID { get; set; }

        public Reeksen Reeks { get; set; }

        public Genres Genres { get; set; }
    }
}