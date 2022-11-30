using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHottel.Models
{
    public class EntityBase
    {
        public int Id { get; set; }

        internal object ToList()
        {
            throw new NotImplementedException();
        }
    }
}
