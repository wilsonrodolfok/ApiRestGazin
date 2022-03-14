using ARG.Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARG.Infraestrutura.Interfaces
{
    public interface INiveisRepository
    {
        IEnumerable<Niveis> Buscar();
        Niveis Buscar(int id);
        void Adicionar(Niveis niveis);
        void Atualizar(int id, Niveis niveis);
        void Excluir(int id);
    }
}
