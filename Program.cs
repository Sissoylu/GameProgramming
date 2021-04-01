using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingWeek1 //package
{
    enum Season
    {
        SPRING=1, WINTER, SUMMER, FALL //ilk elemana verilen değerden sonra diğer elemanlar ona göre artmaya devam eder
    }
    class Program
    {
        //static int number = 0; //static olmayan değerler bir objeye aittir ve onları sadece obje üzerinden çağırabiliriz

        static void Main(string[] args) //public //main String
        {

            #region NotinUse


              //    int result = sum(4, 5);

        //    if (result == 9)
        //    {
        //        Console.WriteLine("Correct");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Wrong");
        //    }

     //       Season season = Season.SPRING;

     //       switch (season)
     //       {
     //           case Season.SPRING:
     //               Console.WriteLine("spring");
     //               break;
     //           case Season.WINTER:
     //               Console.WriteLine("winter");
     //               break;
     //           case Season.SUMMER:
     //               Console.WriteLine("summer");
     //               break;
     //           case Season.FALL:
     //               Console.WriteLine("fall");
     //               break;
     //       }
     
            //int[] numbers = new int[4];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = i+1;
            //    Console.WriteLine(numbers[i]);
                
            //}

            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
                
            //}

            //while (number ++ < 10)
            //{
            //    Console.WriteLine(number);
                
            //}

            //do 
            //{
            //    Console.WriteLine(number);

                
            //} while (number ++ < 10); 

            //PrintAllEnums();


           // Console.WriteLine(result);

            #endregion
            //classlar bir modeldir.

            enemy character1 = new enemy(3, "jack", 100);
            player character2 = new player(2, "jane", 100, 5);
            
            
            //((enemy)character1).Punch(character2);
            //((player)character2).Punch(character1);
//
            //Console.WriteLine(character1.score+" health "+ character1.health);
            //Console.WriteLine(character2.score+" health "+ character1.health);


            //Console.WriteLine(character1);

            //character1.MakeScore();
            //character2.TakeDamage(5);

            //Console.WriteLine(character1.score);
            //Console.WriteLine(character2.score);

            arrays();




            Console.ReadKey();
        }

        static void PrintAllEnums()
        {
            Array seasons = Enum.GetValues(typeof(Season));
            foreach (var season in seasons)
            {
                Console.WriteLine(season);
            }

        }

        static void arrays()
        {
            character character1 = new enemy(3, "jack", 100);
            character character2 = new player(2, "jane", 100, 5);

            List<character> characterList = new List<character>();
            characterList.Add(character1);
            characterList.Add(character2);

           //foreach (var ch in characterList)
           //{
           //    Console.WriteLine(ch);
           //}

            LinkedList<character> lCharacterList = new LinkedList<character>();
            lCharacterList.AddLast(character1);
            lCharacterList.AddLast(character2);    

            IEnumerator enumerator = lCharacterList.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }     
        }

        static int sum(int a, int b){

            return a+b;
        }
    }
}
