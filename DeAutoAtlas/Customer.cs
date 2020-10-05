using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeAutoAtlas
{
    public class Customer: User
    {
    
        public EnumUserType UserType { get { return EnumUserType.Customer; } }

        public List<AutoMerk> FavorieteAutomerken;

    }
}
