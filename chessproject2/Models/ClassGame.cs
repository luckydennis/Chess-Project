using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace chessproject2.Models
{
    public class ChessGame
    {
        public int Id { get; set; }
        public string Fen { get; set; }

        [Display(Name = "Game Date")]
        [DataType(DataType.Date)]
        public DateTime gameDate { get; set; }

        [Display(Name = "User Name")]
        public string userName { get; set; }
    }
}
