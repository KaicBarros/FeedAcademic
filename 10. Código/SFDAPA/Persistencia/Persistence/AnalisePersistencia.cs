using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Persistencia.Persistence
{
    public class AnalisePersistencia
    {
        private static List<Analise> listaAnalises;

        static AnalisePersistencia()
        {
            listaAnalises = new List<Analise>();
        }

        public Analise Adicionar(Analise analise)
        {
            analise.Codigo = listaAnalises.Count + 1;
            listaAnalises.Add(analise);
            return analise;
        }

        public void Editar(Analise analise)
        {
            int posicao = listaAnalises.FindIndex(a => a.Codigo == analise.Codigo);
            listaAnalises[posicao] = analise;
        }

        public void Remover(Analise analise)
        {
            int posicao = listaAnalises.FindIndex(a => a.Codigo == analise.Codigo);
            listaAnalises.RemoveAt(posicao);
        }

        public Analise Obter(Func<Analise, bool> Where)
        {
            return listaAnalises.Where(Where).FirstOrDefault();
        }

        public List<Analise> ObterTodos()
        {
            return listaAnalises;
        }
    }
}
