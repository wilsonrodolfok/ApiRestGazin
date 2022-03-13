using ARG.Dominio;
using System.Linq;
using System.Threading.Tasks;

namespace ARG.Infraestrutura.Interfaces
{
    public interface IDesenvolvedoresRepository
    {
        IQueryable<Desenvolvedores> GetAll();
        Task Add(Desenvolvedores entity);
    }
}
