using System;
using System.Collections.Generic;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 1-Sum of Biggest Neighbor

            int[] arr = { 1, 2, 1, 5, 5, 3, 3, 3, 4 };


            Program program = new Program();

            var sortedArray = program.Challenge(arr);

            foreach (var item in sortedArray)
            {
                Console.Write(item);
            }

            int output = findLargestSumPair(sortedArray);

            #endregion

            #region 2-UserClass

            while (true)
            {
                var user = Singleton.Instance;
                Console.WriteLine("please enter your userName or q to exit");
                var userName = Console.ReadLine();
                if (userName == "q")
                {
                    break;
                }

                user.Add(userName);
                Console.WriteLine($"number of addedUser {user.GetUsersCount()}");

            }

            #endregion

            #region 3-John The Robot

            var john = new Humanoid(new Dancing());
            Console.WriteLine(john.ShowSkill()); //print dancing
            var alex = new Humanoid(new Cooking());
            Console.WriteLine(alex.ShowSkill());//print cooking
            var bob = new Humanoid();
            Console.WriteLine(bob.ShowSkill());//print no skill is defined

            #endregion

            #region 4-Alexa Settings

            var alexa = new Alexa();
            Console.WriteLine(alexa.Talk()); //print hello, i am Alexa
            alexa.Configure(x =>
            {
                x.OwnerName = "Bob Marley";
                x.GreetingMessage = $"Hello {x.OwnerName}, I'm at your service";
            });
            Console.WriteLine(alexa.Talk()); //print Hello Bob Marley, I'm at your service
            Console.WriteLine("press any key to exit");
            Console.ReadKey();

            #endregion

            #region 6- Construction Game

            var myHouse = new Building()
                 .AddKitchen()
                 .AddBedroom("master")
                 .AddBedroom("guest")
                 .AddBalcony();

            var normalHouse = myHouse.Build();

            //kitchen, master room, guest room, balcony
            Console.WriteLine(normalHouse.Describe());

            myHouse.AddKitchen().AddBedroom("another");

            var luxuryHouse = myHouse.Build();

            //it only shows the kitchen after build
            //kitchen, master room, guest room, balcony, kitchen, another room
            Console.WriteLine(luxuryHouse.Describe());

            #endregion

        }

        public int[] Challenge(int[] inputs)
        {

            List<int> list = new List<int>(inputs);

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

                    list.Remove(pair.Key);
                }

                Console.WriteLine("number {0} is repeated {1} times.", pair.Key, pair.Value);

                // Console.ReadKey();
            }

            inputs = list.ToArray();


            return inputs;
        }


        static int findLargestSumPair(int[] arr)
        {
            // Initialize first and  
            // second largest element 
            int first, second;
            if (arr[0] > arr[1])
            {
                first = arr[0];
                second = arr[1];
            }
            else
            {
                first = arr[1];
                second = arr[0];
            }

            // Traverse remaining array and 
            // find first and second largest 
            // elements in overall array 
            for (int i = 2; i < arr.Length; i++)
            {
                /* If current element is greater  
                   than first then update both 
                   first and second */
                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }

                /* If arr[i] is in between first 
                   and second then update second */
                else if (arr[i] > second)
                    second = arr[i];
            }
            return (first + second);
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
