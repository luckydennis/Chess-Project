using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace chessproject2.Models
{
    public class chessproject2Context : DbContext
    {
        public chessproject2Context (DbContextOptions<chessproject2Context> options)
            : base(options)
        {
        }

        public DbSet<chessproject2.Models.ChessGame> ChessGame { get; set; }
    }
}
