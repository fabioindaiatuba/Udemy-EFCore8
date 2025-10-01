
using EFCoreConsole.DbContexts;

using (var context = new Context())
{
  context.Database.EnsureCreated();
}