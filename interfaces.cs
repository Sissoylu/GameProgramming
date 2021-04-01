using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingWeek1
{
    interface IFlyBehaviour
    {
        //already public, tekrar public yazmaya gerek yok.
        void Fly();
    }

    interface IPunchBehaviour
    {
        //already public, tekrar public yazmaya gerek yok.
        void Punch(character oppent);
    }
        interface IJumpBehaviour
    {
        //already public, tekrar public yazmaya gerek yok.
        void Jump();
    }
}