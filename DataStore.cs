using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask19_06_2023
{
    public class DataStore<TId, TStore>
    {
        public TId Id { get; set; }
        public TStore Store { get; set; }
    }

}
