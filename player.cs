using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameProgrammingWeek1
{
    class player:character,IPunchBehaviour, IJumpBehaviour
    {
        int extrapower;
        public player(int id, string name, int health, int epower):base(id,name,health)
        {
            this.extrapower=epower;
        }

        public void Jump()
        {
            Console.WriteLine("jump");

        }

        public void Punch(character oppent)
        {
            oppent.health -= 10;
            this.MakeScore();

        }




        public override void MakeScore()
        {
            //private olduğu zaman sadece classın kendisi erişebilir. yavru classlar erişemez.
            this.score += 10;
        }
    }
    
}