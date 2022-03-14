using ARG.Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARG.Infraestrutura.Interfaces
{
    public interface IDesenvolvedoresRepository
    {
        void Excluir(int id);
        IEnumerable<Desenvolvedores> Buscar();
        Desenvolvedores Buscar(int id);
        void Adicionar(Desenvolvedores desenvolvedores);
        void Atualizar(int id, Desenvolvedores desenvolvedores);
    }
}
