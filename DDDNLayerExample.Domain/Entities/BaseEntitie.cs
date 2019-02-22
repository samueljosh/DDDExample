using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDNLayerExample.Domain.Entities
{

    // Entidade do meu sistema no qual todas as classes herdarão o seus atributos
    // Forçando as mesmas a terem os atributos destacados abaixo

    public abstract class BaseEntitie
    {

      // ID que podera ser alterado nas  classes herdadas
        public virtual Guid  Id { get; set; }
    }
}
