using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeTask19_06_2023
{
    public class ComputerStore<TId, TName, TPrice>
    {
        public TId Id { get; set; }
        public TName Name { get; set; }
        public TPrice Price{ get; set; }



        public ComputerStore(TId id, TName name, TPrice price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Computer name:{Name}\nComputer ID:{Id}\nComputer Price:{Price}\n");
        }


    }

    public class ComputerService<TRam, TSsd>
    {

        public ComputerService(TRam ram, TSsd ssd)
        {
            Ram = ram;
            Ssd = ssd;
        }


        public TRam Ram { get; set; }

        public TSsd Ssd { get; set;}

        public void GetServiceInfo()
        {
            Console.WriteLine($"RAM info:{Ram}\nSSD info:{Ssd}\n");

        }
    }




}
