using System;
using System.Collections.Generic;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 1-Sum of Biggest Neighbor

            int[] arr = new int[] { 1, 2, 1, 5, 5, 3, 3, 3, 4 };


            Program program = new Program();

            program.Challenge(arr);

            #endregion

            #region 2-UserClass

            //while (true)
            //{
            //    var user = Singleton.Instance;
            //    Console.WriteLine("please enter your userName or q to exit");
            //    var userName = Console.ReadLine();
            //    if (userName == "q")
            //    {
            //        break;
            //    }

            //    user.Add(userName);
            //    Console.WriteLine($"number of addedUser {user.GetUsersCount()}");

            //}

            #endregion

            #region 3-John The Robot

            //var john = new Humanoid(new Dancing());
            //Console.WriteLine(john.ShowSkill()); //print dancing
            //var alex = new Humanoid(new Cooking());
            //Console.WriteLine(alex.ShowSkill());//print cooking
            //var bob = new Humanoid();
            //Console.WriteLine(bob.ShowSkill());//print no skill is defined

            #endregion

            #region 4-Alexa Settings

            //var alexa = new Alexa();
            //Console.WriteLine(alexa.Talk()); //print hello, i am Alexa
            //alexa.Configure(x =>
            //{
            //    x.OwnerName = "Bob Marley";
            //    x.GreetingMessage = $"Hello {x.OwnerName}, I'm at your service";
            //});
            //Console.WriteLine(alexa.Talk()); //print Hello Bob Marley, I'm at your service
            //Console.WriteLine("press any key to exit");
            //Console.ReadKey();

            #endregion

            #region 6- Construction Game

            //var myHouse = new Building()
            //     .AddKitchen()
            //     .AddBedroom("master")
            //     .AddBedroom("guest")
            //     .AddBalcony();

            //var normalHouse = myHouse.Build();

            ////kitchen, master room, guest room, balcony
            //Console.WriteLine(normalHouse.Describe());

            //myHouse.AddKitchen().AddBedroom("another");

            //var luxuryHouse = myHouse.Build();

            ////it only shows the kitchen after build
            ////kitchen, master room, guest room, balcony, kitchen, another room
            //Console.WriteLine(luxuryHouse.Describe());

            #endregion


        }

        public int[] Challenge(int[] inputs)
        {
            int temp;
            int[] newArr;

            //List<int> list = new List<int>(inputs);

            var dict = new Dictionary<int, int>();

            foreach (var value in inputs)
            {
                if (dict.ContainsKey(value))
                    dict[value]++;
                else
                    dict[value] = 1;
            }

            foreach (var pair in dict)
            {
                if (pair.Value == 1)
                {
                    dict.Remove(pair.Key);
                }
                Console.WriteLine("number {0} is repeated {1} times.", pair.Key, pair.Value);
                Console.ReadKey();
            }

            inputs = 




            // traverse 0 to array length 
            //for (int i = 0; i < inputs.Length - 1; i++)

            //    // traverse i+1 to array length 
            //   // for (int j = i + 1; j < inputs.Length; j++)

            //        // compare array element with  
            //        // all next element 
            //        if (inputs[i] % 2 == 0)
            //        {
            //            list.RemoveAt(i);

            //            temp = inputs[i];
            //           // inputs[i] = inputs[j];
            //          //  inputs[j] = temp;
            //        }
            //inputs = list.ToArray();

            //// print all element of array 
            //foreach (int value in inputs)
            //{
            //    Console.Write(value + " ");
            //}

            return inputs;
        }
    }


    /// <summary>
    /// User Class contains two methods for addUser and GetUserCount
    /// </summary>
    public class User
    {

        IList<int> counts = new List<int>();

        public void Add(string userName)
        {
            if (userName != null)
            {
                int count = 0;
                count += 1;
                counts.Add(count);
            }
        }

        public int GetUsersCount()
        {
            return counts.Count;
        }
    }
}
