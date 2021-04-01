using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingWeek1 //package

{
    abstract class character
    {
        //alt+shift ile hepsini seçip başlarına public yazdırabiliriz.
        public int id;
        public string name;
        public int score { get; protected set; } //get ve set verildiği takdirde bu özellik artık dışarıdan erişilebilirdir
        //private set yaptığımız içn hiçbir şekilde set edilemez
        public int health;


    //constuctor
     public character(int id, string name, int health)
     {
         this.id = id;
         this.name = name;
         this.health = health;
     }

     public void TakeDamage(int amount){
         this.health -= amount;
     }

    //virtual (sanallaştırma) işlemi sayesinde yavru classların override etmesine olanak sağlıyoruz
     public abstract void MakeScore();
     

        //public override string ToString()
        //{
        //    return name;
        //    //bu kod bloğu sayesinde character1'i konsola yazdığımızda nameini döndürecek.
        //}





    }
}