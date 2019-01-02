using CasinoWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasinoWeb.Context
{
	public class CDbContext : IdentityDbContext
	{
		public CDbContext(DbContextOptions options) : base(options)
		{
		}
		DbSet<GameModel> Game { get; set; }
	}
}
