using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class BusinessEntity
    {
        private int id;

        public BusinessEntity()
        {
            this.state = States.New;
        }
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
