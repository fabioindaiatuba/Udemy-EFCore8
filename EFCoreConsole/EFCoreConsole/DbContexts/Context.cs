using System;
using EFCoreConsole.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreConsole.DbContexts;

public class Context : DbContext
{
  public DbSet<Filme> Filmes { get; set; }
  public DbSet<Diretor> Diretores { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite("Data Source=EFCoreConsole.db");
}
