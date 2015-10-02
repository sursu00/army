using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

namespace WpfApplication1
{


    public class Question
    {
        [Indexed, MaxLength(1000)]
        public string subject { get; set; }
        [Indexed, MaxLength(1000)]
        public string answer { get; set; }
        [Indexed, MaxLength(5)]
        public string type { get; set; }
    }

    public class User
    {
        [Indexed, MaxLength(100)]
        public string Name { get; set; }
        [Indexed, MaxLength(100)]
        public string Soname{ get; set; }
        [Indexed, MaxLength(100)]
        public string Thname{ get; set; }
        [Indexed]
        public int devision { get; set; }
    }



}
