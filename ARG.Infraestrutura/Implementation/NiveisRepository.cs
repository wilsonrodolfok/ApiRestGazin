using ARG.Dominio;
using ARG.Infraestrutura.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARG.Infraestrutura.Implementation
{
    public class NiveisRepository : INiveisRepository
    {
        private readonly ContextoPrincipal _contexto;

        public NiveisRepository(ContextoPrincipal contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Niveis niveis)
        {
            _contexto.Niveis.Add(niveis);
            _contexto.SaveChanges();
        }

        public IEnumerable<Niveis> Buscar()
        {
            return _contexto.Niveis;
        }

        public Niveis Buscar(int id)
        {             
            return _contexto.Niveis.Where(niveis => niveis.Id == id).FirstOrDefault();
        }

        public void Atualizar(int id, Niveis niveis)
        {
            var registroAtualizar = _contexto.Niveis.Where(x => x.Id == id).FirstOrDefault();
            if (registroAtualizar != null)
            {
                registroAtualizar.Nivel = niveis.Nivel;
            }
                _contexto.Niveis.Update(registroAtualizar);
            _contexto.SaveChanges();
        }

        public void Excluir(int id)
        {
            var registroExcluir = _contexto.Niveis.Where(x => x.Id == id).FirstOrDefault();
            if (registroExcluir != null)
            {
                if (!VerificarRegistroFilho(id))
                    _contexto.Niveis.Remove(registroExcluir);
                else
                    throw new Exception("Existem Desenvolvedores com este nível, Não pode ser excluído!");
            }                
            _contexto.SaveChanges();

        }

        private bool VerificarRegistroFilho(int registro)
        {
            return _contexto.Niveis.Where(x => x.Id == registro).Any();
        }
    }
}
