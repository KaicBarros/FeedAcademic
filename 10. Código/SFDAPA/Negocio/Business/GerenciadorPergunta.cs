using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistencia.Persistence;


namespace Negocio.Business
{
    public class GerenciadorPergunta
    {
        private PerguntaPersistencia persistencia;

        public GerenciadorPergunta()
        {
            persistencia = new PerguntaPersistencia();
        }

        public Pergunta Adicionar(Pergunta pergunta)
        {
            persistencia.Adicionar(pergunta);
            return pergunta;
        }

        public void Editar(Pergunta pergunta)
        {
            persistencia.Editar(pergunta);
        }

        public void remover(Pergunta pergunta)
        {
            persistencia.Remover(pergunta);
        }

        public Pergunta Obter(int id)
        {
            return persistencia.Obter(e => e.Codigo == id);
        }

        public List<Pergunta> ObterTodos()
        {
            return persistencia.ObterTodos();
        }
    }
}
