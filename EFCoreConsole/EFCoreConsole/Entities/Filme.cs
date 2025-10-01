using System;

namespace EFCoreConsole.Entities;

public class Filme
{
  public int Id { get; set; }

  public required string Titulo { get; set; }

  public int Ano { get; set; }

  public Diretor? Diretor { get; set; }
}
