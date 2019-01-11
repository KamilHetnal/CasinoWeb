using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CasinoWeb.Models
{
    public class GameModel
    {
        public int ID { get; set; }
        public int Credits { get; set; }
        public int Bet { get; set; }
        public int Lines { get; set; }
        public int Total { get; set; }
        [NotMapped] public int[] Tab1 { get; set; }
        [NotMapped] public int[] Tab2 { get; set; }
        [NotMapped] public int[] Tab3 { get; set; }
        public int[] PriceInts = {
            5,15,80,400
        };

        public int CountWin()
        {
            Total = 0;

            if (Lines == 3)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (Tab1[0] == Tab1[i + 1])
                        Total = Total + 1 * PriceInts[i];
                    else
                    {
                        break;
                    }
                }
                for (int i = 0; i < 4; i++)
                {
                    if (Tab3[0] == Tab3[i + 1])
                        Total = Total + 1 * PriceInts[i];
                    else
                    {
                        break;
                    }
                }
            }
            if (Lines == 1 || Lines == 3)
                for (int i = 0; i < 4; i++)
                {
                    if (Tab2[0] == Tab2[i + 1])
                        Total = Total + 1 * PriceInts[i];
                    else
                    {
                        break;
                    }
                }

            Total = Total * Bet;
            Bet = Bet * Lines;
            Credits += Total - Bet;
            return Credits;
        }

    }
}
