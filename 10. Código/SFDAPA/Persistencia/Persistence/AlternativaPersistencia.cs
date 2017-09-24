using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Persistencia.Persistence
{
    public class AlternativaPersistencia
    {
        private static List<Alternativa> listaAlternativas;

        static AlternativaPersistencia()
        {
            listaAlternativas = new List<Alternativa>();
        }

        public Alternativa Adicionar(Alternativa alternativa)
        {
            alternativa.Codigo = listaAlternativas.Count + 1;
            listaAlternativas.Add(alternativa);
            return alternativa;
        }

        public void Editar(Alternativa alternativa)
        {
            int posicao = listaAlternativas.FindIndex(a => a.Codigo == alternativa.Codigo);
            listaAlternativas[posicao] = alternativa;
        }

        public void Remover(Alternativa alternativa)
        {
            int posicao = listaAlternativas.FindIndex(a => a.Codigo == alternativa.Codigo);
            listaAlternativas.Remove(alternativa);
        }

        public Alternativa Obter(Func<Alternativa, bool> Where)
        {
            return listaAlternativas.Where(Where).FirstOrDefault();
        }

        public List<Alternativa> ObterTodos()
        {
            return listaAlternativas;
        }
    }
}
