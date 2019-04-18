using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace chessproject2.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new chessproject2Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<chessproject2Context>>()))
            {
                // Look for any movies.
                if (context.ChessGame.Any())
                {
                    return;   // DB has been seeded
                }

                context.ChessGame.AddRange(
                    new ChessGame
                    {
                        Fen = "rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1",
                        gameDate = DateTime.Parse("2019-4-15"),
                        userName = "homiie"
                    },
                    new ChessGame
                    {
                        Fen = "rnbqkbnr/pp1ppppp/8/2p5/4P3/8/PPPP1PPP/RNBQKBNR w KQkq c6 0 1",
                        gameDate = DateTime.Parse("2019-4-11"),
                        userName = "homiie"
                    },
                    new ChessGame
                    {
                        Fen = "rnbqkbnr/pp1pp1pp/5p2/2p2P2/4P3/8/PPPP2PP/RNBQKBNR w KQkq - 0 1",
                        gameDate = DateTime.Parse("2019-4-12"),
                        userName = "homiie"
                    },
                    new ChessGame
                    {
                        Fen = "r1bqkbnr/pp1pp1p1/2n2p1p/2p2P2/4P2P/2P2Q2/PP1P2P1/RNB1KBNR b KQkq - 0 1",
                        gameDate = DateTime.Parse("2019-4-17"),
                        userName = "homiie"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}