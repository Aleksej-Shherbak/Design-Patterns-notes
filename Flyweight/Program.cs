using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            ActorMikeMayer actorMikeMayer = new ActorMikeMayer();
            
            RoleAustinPowers austinPowers = new RoleAustinPowers(actorMikeMayer);
            austinPowers.Greeting("Hello! I'm Austin Powers!");
            
            RoleDoctorEvil doctorEvil = new RoleDoctorEvil(actorMikeMayer);
            doctorEvil.Greeting("Hello! I'm doctor Evil!!!");
        }
    }
}