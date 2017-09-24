using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Persistencia.Persistence
{
    public class AlunoPersistencia
    {
        private static List<Aluno> listaAlunos;

        static AlunoPersistencia()
        {
            listaAlunos = new List<Aluno>();
        }
    
       public Aluno Adicionar(Aluno aluno)
        {
            aluno.Codigo = listaAlunos.Count + 1;
            listaAlunos.Add(aluno);
            return aluno;
        }

        public void Editar(Aluno aluno)
        {
            int posicao = listaAlunos.FindIndex(a => a.Codigo == aluno.Codigo);
            listaAlunos[posicao] = aluno;
        }

        public void Remover(Aluno aluno)
        {
            int posicao = listaAlunos.FindIndex(a => a.Codigo == aluno.Codigo);
            listaAlunos.RemoveAt(posicao);
        }

        public Aluno Obter(Func<Aluno, bool> Where)
        {
            return listaAlunos.Where(Where).FirstOrDefault();
        }

        public List<Aluno> ObterTodos()
        {
            return listaAlunos;
        }  
    }
}
