
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
namespace Model.Models
{
    public class FeedbackAssunto
    {

        public int Codigo { get; set; }
        public PerguntaFeedback[] QuestionarioFeedback { get; set; }

        public FeedbackAssunto()
        {
        }

        public void Disponibilizar()
        {
            // TODO implement here
        }

        public void Encerrrar()
        {
            // TODO implement here
        }

    }
}