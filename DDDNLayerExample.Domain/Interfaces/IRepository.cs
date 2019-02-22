using DDDNLayerExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDNLayerExample.Domain.Interfaces
{



    // Interface genérica  que atribui ao Repository
    // O conceito de Crud
    public  interface IRepository<T> where T : BaseEntitie
    {
        void Insert(T obj);
        void Delete(T obj);

        void Update(T obj);

        T Select(T obj);

        ICollection<T> SelectAll();





    }
}
