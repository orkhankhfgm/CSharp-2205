using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_Part2_Homework_Solution
{
    public sealed class Tv : Item
    {
        public bool IsSmartTv { get; set; }
        public bool HasHDMI { get; set; }
        public string Resolution { get; set; }
    }
}
