using System;
using Visitor_23.SantaExample;

namespace Visitor_23
{
    class Program
    {
        static void VillageExample()
        {
            Village village = new Village();
            village.Add(new BoysHouse());
            village.Add(new GirlsHouse());
            
            village.Accept(new Santa());
        }

        static void Main(string[] args)
        {
            VillageExample();
        }
    }
}