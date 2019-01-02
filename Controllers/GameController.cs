using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;
using CasinoWeb.Context;
using CasinoWeb.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CasinoWeb.Contollers
{
    public class GameController : Controller
    {
        public readonly CDbContext context;

        public GameController(CDbContext context)
        {
            this.context = context;
        }
        Slot slot = new Slot();
        static private GameModel gameModel = new GameModel {Credits = 500, Tab1 = new int[5], Tab2 = new int[5], Tab3 = new int[5] };
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(gameModel);
        }
        [HttpPost]
        public IActionResult Index(int bet, int lines)
        {
            gameModel.Bet = bet;
            gameModel.Lines = lines;
            if ((bet * lines) <= gameModel.Credits)
            {
                for (int i = 0; i < 5; i++)
                {
                    gameModel.Tab1[i] = slot.GenerateRandomNo();
                    gameModel.Tab2[i] = slot.GenerateRandomNo();
                    gameModel.Tab3[i] = slot.GenerateRandomNo();
                }
                int Total =  gameModel.CountWin();
            }
            return View(gameModel);
        }
    }
}
