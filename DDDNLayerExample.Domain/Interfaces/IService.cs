using DDDNLayerExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDNLayerExample.Domain.Interfaces
{
    public interface IService<T> where  T : BaseEntitie
    {
        // T Modelo genérico referente
        // V entidade para validação
        T Post<V> (T obj) where  V : AbstractValidator<T>;
        T Put<V>(T obj) where V : AbstractValidator<T>;

        T Get(int id);

        T Delete(int id);



    }
}
