using ARG.Dominio;
using ARG.Infraestrutura.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARG.Infraestrutura.Implementation
{
    public class DesenvolvedoresRepository : IDesenvolvedoresRepository
    {
        private readonly ContextoPrincipal _contexto;

        public DesenvolvedoresRepository(ContextoPrincipal contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Desenvolvedores desenvolvedores)
        {
            _contexto.Desenvolvedores.Add(desenvolvedores);
            _contexto.SaveChanges();
        }

        public IEnumerable<Desenvolvedores> Buscar()
        {
            return _contexto.Desenvolvedores;
        }

        public Desenvolvedores Buscar(int id)
        {
            return _contexto.Desenvolvedores.Where(desenvolvedor => desenvolvedor.Id == id).FirstOrDefault();
        }

        public void Atualizar(int id, Desenvolvedores desenvolvedores)
        {
            var registroAtualizar = _contexto.Desenvolvedores.Where(x => x.Id == id).FirstOrDefault();
            if (registroAtualizar != null)
            {
                registroAtualizar.Nivel = desenvolvedores.Nivel;
                registroAtualizar.Hobby = desenvolvedores.Hobby;
                registroAtualizar.Idade = desenvolvedores.Idade;
                registroAtualizar.Nome = desenvolvedores.Nome;
                registroAtualizar.Sexo = desenvolvedores.Sexo;
                registroAtualizar.DataNascimento = desenvolvedores.DataNascimento;
                    
            }
            _contexto.Desenvolvedores.Update(registroAtualizar);
            _contexto.SaveChanges();
        }


        public void Excluir(int id)
        {
            var registroExcluir = _contexto.Desenvolvedores.Where(x => x.Id == id).FirstOrDefault();
            if (registroExcluir != null)
                _contexto.Desenvolvedores.Remove(registroExcluir);
            _contexto.SaveChanges();
        }
    }
}
