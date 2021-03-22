using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_13
{
    class UniqueItem
    {
        public int _id;
        public static int Id { get; set; }
        public UniqueItem()
        {
            _id = Id;
            Id ++;
        }
    }
}