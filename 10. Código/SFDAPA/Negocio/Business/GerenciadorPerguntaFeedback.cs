using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
    public class GerenciadorPerguntaFeedback
    {
        private PerguntaFeedbackPersistencia persistencia;

        public GerenciadorPerguntaFeedback()
        {
            persistencia = new PerguntaFeedbackPersistencia();
        }

        public PerguntaFeedback Adicionar(PerguntaFeedback perguntaFeedback)
        {
            persistencia.Adicionar(perguntaFeedback);
            return perguntaFeedback;
        }

        public void Editar(PerguntaFeedback perguntaFeedback)
        {
            persistencia.Editar(perguntaFeedback);
        }

        public void Remover(PerguntaFeedback perguntaFeedback)
        {
            persistencia.Remover(perguntaFeedback);
        }
        
        public PerguntaFeedback Obter(int id)
        {
            return persistencia.Obter(e => e.Codigo == id);
        }

        public List<PerguntaFeedback> ObterTodos()
        {
            return persistencia.ObterTodos();
        } 

    }
}
