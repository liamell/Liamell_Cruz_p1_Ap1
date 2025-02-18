using Liamell_Cruz_p1_Ap1.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Liamell_Cruz_p1_Ap1.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
    }

    public DbSet<Aportes> Aportes{ get; set; }   

}
