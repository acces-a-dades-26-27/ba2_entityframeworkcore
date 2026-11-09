namespace InstitutApp
{
   internal class Program
   {
      static void Main(string[] args)
      {
         using (var ctx = new InstitutContext())
         {
            //Esborrem i creem BD
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();

            var claudia = new Professor(){Nom="Claudia", Cognom="Reina"};
            var ismael = new Professor(){Nom="Ismael", Cognom="Pajuelo"};
            
            //Persistim
            ctx.Professor.Add(claudia);
            ctx.Professor.Add(ismael);
            ctx.SaveChanges();
            
            //Lectura
            Console.WriteLine("\n=== DADES INSERIDES ===");
            List<Professor> llista = ctx.Professor.ToList();
            foreach (Professor prof in llista)
            {
               Console.WriteLine(prof);
            }
         }
      }
   }
}

