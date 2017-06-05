using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSide
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Client c = new Client("127.0.0.1", 6666);
                c.Connect();
            }
        }
    }
}
