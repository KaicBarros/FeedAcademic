using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Persistencia.Persistence
{
    public class AulaPersistencia
    {
        private static List<Aula> listaAulas;

        static AulaPersistencia()
        {
            listaAulas = new List<Aula>();
        }

        public Aula Adicionar(Aula aula)
        {
            aula.Codigo = listaAulas.Count + 1;
            listaAulas.Add(aula);
            return aula;
        }

        public void Editar(Aula aula)
        {
            int posicao = listaAulas.FindIndex(a => a.Codigo == aula.Codigo);
            listaAulas[posicao] = aula;
        }

        public void Remover(Aula aula)
        {
            int posicao = listaAulas.FindIndex(a => a.Codigo == aula.Codigo);
            listaAulas.RemoveAt(posicao);
        }

        public Aula Obter(Func<Aula, bool> Where)
        {
            return listaAulas.Where(Where).FirstOrDefault();
        }

        public List<Aula> ObterTodos()
        {
            return listaAulas;
        }
    }
}
