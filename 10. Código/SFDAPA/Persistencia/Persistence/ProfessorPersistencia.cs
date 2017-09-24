using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Persistencia.Persistence
{
    public class ProfessorPersistencia
    {
        private static List<Professor> listaProfessor;
    
        static ProfessorPersistencia()
        {
            listaProfessor = new List<Professor>();
        }

        public Professor Adicinoar(Professor professor)
        {
            professor.Codigo = listaProfessor.Count + 1;
            listaProfessor.Add(professor);
            return professor;
        }

        public void Editar(Professor professor)
        {
            int posicao = listaProfessor.FindIndex(p => p.Codigo == professor.Codigo);
            listaProfessor[posicao] = professor;
        }

        public void Remover(Professor professor)
        {
            int posicao = listaProfessor.FindIndex(p => p.Codigo == professor.Codigo);
            listaProfessor.RemoveAt(posicao);
        }

        public Professor Obter(Func<Professor, bool> where)
        {
            return listaProfessor.Where(where).FirstOrDefault();
        }

        public List<Professor> ObterTodos()
        {
            return listaProfessor;
        }
    }
}
