using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using chessproject2.Models;

namespace chessproject2.Controllers
{
    public class ChessGamesController : Controller
    {
        private readonly chessproject2Context _context;

        public ChessGamesController(chessproject2Context context)
        {
            _context = context;
        }

        // GET: ChessGames
        public async Task<IActionResult> Index()
        {
            return View(await _context.ChessGame.ToListAsync());
        }

        // GET: ChessGames/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chessGame = await _context.ChessGame
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chessGame == null)
            {
                return NotFound();
            }

            return View(chessGame);
        }

        // GET: ChessGames/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChessGames/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fen,gameDate,userName")] ChessGame chessGame)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chessGame);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chessGame);
        }

        // GET: ChessGames/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chessGame = await _context.ChessGame.FindAsync(id);
            if (chessGame == null)
            {
                return NotFound();
            }
            return View(chessGame);
        }

        // POST: ChessGames/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fen,gameDate,userName")] ChessGame chessGame)
        {
            if (id != chessGame.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chessGame);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChessGameExists(chessGame.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(chessGame);
        }

        // GET: ChessGames/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chessGame = await _context.ChessGame
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chessGame == null)
            {
                return NotFound();
            }

            return View(chessGame);
        }

        // POST: ChessGames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chessGame = await _context.ChessGame.FindAsync(id);
            _context.ChessGame.Remove(chessGame);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChessGameExists(int id)
        {
            return _context.ChessGame.Any(e => e.Id == id);
        }
    }
}
