using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeAutoAtlas
{
    public class Dealer : User
    {
        public EnumUserType UserType { get { return EnumUserType.Dealer; } }
        public List<AutoMerk> AutoMerken { get; set; }
    }
}
