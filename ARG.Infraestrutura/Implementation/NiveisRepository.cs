using ARG.Dominio;
using ARG.Infraestrutura.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace ARG.Infraestrutura.Implementation
{
    public class NiveisRepository : INiveisRepository
    {
        private readonly ContextoPrincipal _database;

        public NiveisRepository(ContextoPrincipal database)
        {
            _database = database;
        }

        public async Task Add(Niveis entity)
        {
            await _database.AddAsync(entity);
            await _database.SaveChangesAsync();
        }

        public IQueryable<Niveis> GetAll()
        {
            return _database.Niveis;
        }
    }
}
