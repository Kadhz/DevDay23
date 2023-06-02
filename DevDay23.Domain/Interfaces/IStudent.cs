using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDay23.Domain.Interfaces
{
    internal interface IStudent
    {
        void Add(Aluno aluno);

        void Update(Aluno aluno);

        void Delete(Aluno aluno);

        IEnumerable<Aluno> GetAll();
    }
}
