using DDDNLayerExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDNLayerExample.Domain.Interfaces.Entities
{
    public class User : BaseEntitie
    {
         public User()
        {
            Id = Guid.NewGuid();
        }
        public string Name  { get; set; }


        public string Email { get; set; }

    
   
        public string Cpf { get; set; }
    }
}
