using Microsoft.EntityFrameworkCore;
using Nume_Pren_Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corpodean_Vlad_Lab2.Data
{
    public class Corpodean_Vlad_Lab2Context : DbContext
    {
        public Corpodean_Vlad_Lab2Context(DbContextOptions<Corpodean_Vlad_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Nume_Pren_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
