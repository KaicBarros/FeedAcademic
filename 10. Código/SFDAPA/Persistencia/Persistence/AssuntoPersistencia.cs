using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Persistencia.Persistence
{
    public class AssuntoPersistencia
    {
        private static List<Assunto> listaAssuntos;

        static AssuntoPersistencia()
        {
            listaAssuntos = new List<Assunto>();
        }

        public Assunto Adicionar(Assunto assunto)
        {
            assunto.Codigo = listaAssuntos.Count + 1;
            listaAssuntos.Add(assunto);
            return assunto;
        }

        public void Editar(Assunto assunto)
        {
            int posicao = listaAssuntos.FindIndex(a => a.Codigo == assunto.Codigo);
            listaAssuntos[posicao] = assunto;
        }

        public void Remover(Assunto assunto)
        {
            int posicao = listaAssuntos.FindIndex(a => a.Codigo == assunto.Codigo);
            listaAssuntos.RemoveAt(posicao);
        }

        public Assunto Obter(Func<Assunto, bool> Where)
        {
            return listaAssuntos.Where(Where).FirstOrDefault();
        }

        public List<Assunto> ObterTodos()
        {
            return listaAssuntos;
        }
    }
}
