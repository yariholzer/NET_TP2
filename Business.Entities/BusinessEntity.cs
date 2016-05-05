using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class BusinessEntity
    {
        public BusinessEntity()
        {
            this.state= States.New;
        }

        public int id { get; set;}

        public States state { get; set; }
        public enum States
        {
            Deleted,
            New,
            Modified,
            Unmodified,
        }
    }
}
