using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_EFCore_01.Class
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ISBN { get; set; }
        public int Price { get; set; }
        public int NumberOfPage { get; set; }
        public DateTime Year { get; set; }



    }
}
