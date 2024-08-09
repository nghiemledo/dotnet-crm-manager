using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Domain.Common.Models
{
    public abstract class Entity<Iid>
    {
        public Iid Id { get; protected set; }
        protected Entity(Iid id)
        {
            Id = id;
        }
        protected Entity()
        {
            
        }
    }
}
