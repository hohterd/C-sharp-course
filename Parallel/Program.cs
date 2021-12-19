using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ParallelConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Car>();

            for (int i = 0; i < 1000000; i++)
            {
                list.Add(new Car(i));
            }

            Stopwatch stopWatch = new Stopwatch();

            //---------------------------------------------------------------------------------

            stopWatch.Start();

            UsualFor(list);

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds);

            Console.WriteLine($"UsualFor RunTime: {elapsedTime}");

            //---------------------------------------------------------------------------------

            stopWatch.Reset();

            stopWatch.Start();

            UsualForEach(list);

            stopWatch.Stop();

            TimeSpan ts2 = stopWatch.Elapsed;

            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts2.Hours, ts2.Minutes, ts2.Seconds,
                ts2.Milliseconds);

            Console.WriteLine($"UsualForEach RunTime: {elapsedTime2}");

            //---------------------------------------------------------------------------------

            stopWatch.Reset();

            stopWatch.Start();

            ParallelFor(list);

            stopWatch.Stop();

            TimeSpan ts3 = stopWatch.Elapsed;

            string elapsedTime3 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts3.Hours, ts3.Minutes, ts3.Seconds,
                ts3.Milliseconds);

            Console.WriteLine($"ParallelFor RunTime: {elapsedTime3}");

            //---------------------------------------------------------------------------------

            stopWatch.Reset();

            stopWatch.Start();

            ParallelForEach(list);

            stopWatch.Stop();

            TimeSpan ts4 = stopWatch.Elapsed;

            string elapsedTime4 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts4.Hours, ts4.Minutes, ts4.Seconds,
                ts4.Milliseconds);

            Console.WriteLine($"ParallelForEach RunTime: {elapsedTime4}");
        }

        static void UsualFor(List<Car> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Age = 343 * 34 * DateTime.Now.Millisecond * 77 / DateTime.Now.Minute;
            }
        }

        static void UsualForEach(List<Car> list)
        {
            foreach (var item in list)
            {
                item.Age = 343 * 34 * DateTime.Now.Millisecond * 77 / DateTime.Now.Minute;
            }
        }

        static void ParallelFor(List<Car> list)
        {
            Action<int> ageChange = (int i) => list[i].Age = (343 * 34 * DateTime.Now.Millisecond * 77 / DateTime.Now.Minute);

            Parallel.For(0, list.Count, ageChange);       
        }

        static void ParallelForEach(List<Car> list)
        {
            Parallel.ForEach(list, car => car.Age = (343 * 34 * DateTime.Now.Millisecond * 77 / DateTime.Now.Minute));
        }


    }
}
