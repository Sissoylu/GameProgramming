using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameProgrammingWeek1
{
    class enemy:character,IFlyBehaviour, IPunchBehaviour //base kullanabilmek için character classını eklememiz gerekiyor buraya
    {
        public enemy(int id, string name, int health):base(id,name,health)
        {

        }

        public void Fly()
        {
            Console.WriteLine("fly");

        }

        public void Punch(character oppent){
            oppent.health -= 10;
            this.MakeScore();
        }

        public override void MakeScore()
        {
            this.score +=3;
        }

        
    }
    
}