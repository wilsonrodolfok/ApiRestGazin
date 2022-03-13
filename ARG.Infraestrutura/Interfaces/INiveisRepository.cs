using ARG.Dominio;
using System.Linq;
using System.Threading.Tasks;

namespace ARG.Infraestrutura.Interfaces
{
    public interface INiveisRepository
    {
        IQueryable<Niveis> GetAll();
        Task Add(Niveis entity);
    }
}
