using ARG.Dominio;
using ARG.Infraestrutura.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace ARG.Infraestrutura.Implementation
{
    public class DesenvolvedoresRepository : IDesenvolvedoresRepository
    {
        private readonly ContextoPrincipal _database;

        public DesenvolvedoresRepository(ContextoPrincipal database)
        {
            _database = database;
        }

        public async Task Add(Desenvolvedores entity)
        {
            await _database.AddAsync(entity);
            await _database.SaveChangesAsync();
        }

        public IQueryable<Desenvolvedores> GetAll()
        {
            return _database.Desenvolvedores;
        }
    }
}
