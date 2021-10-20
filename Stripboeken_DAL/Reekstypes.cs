using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stripboeken_DAL
{
    [Table("Reekstypes")]
    public class Reekstypes
    {
        [Key]
        public int ReekstypeID { get; set; }

        public string Beschrijving { get; set; }

        public ICollection<Reeksen> Reeks { get; set; }
    }
}