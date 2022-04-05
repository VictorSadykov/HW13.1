using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace HW13._1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var list = new List<char>();
            var linkedList = new LinkedList<char>();
            var result = new Dictionary<string, double>();
            var stopWatch = new Stopwatch();


            using (var sr = new StreamReader("Text1.txt"))
            {
                string str = sr.ReadToEnd();
                stopWatch.Start();
                foreach (var item in str)
                {
                    linkedList.AddLast(item);
                }
                stopWatch.Stop();
                result.Add("Время добавления всего текста в связаный список", stopWatch.Elapsed.TotalMilliseconds);
                stopWatch.Reset();

                stopWatch.Start();
                foreach (var item in str)
                {
                    list.Add(item);
                }
                stopWatch.Stop();
                result.Add("Время добавления всего текста в список", stopWatch.Elapsed.TotalMilliseconds);
                stopWatch.Reset();
            }

            stopWatch.Start();
            list.Insert(0, ' ');
            stopWatch.Stop();
            result.Add("Время добавления элемента в начало списка", stopWatch.Elapsed.TotalMilliseconds);
            stopWatch.Reset();

            stopWatch.Start();
            linkedList.AddFirst(' ');
            stopWatch.Stop();
            result.Add("Время добавления элемента в начало связанного списка", stopWatch.Elapsed.TotalMilliseconds);
            stopWatch.Reset();

            stopWatch.Start();
            list.Add(' ');
            stopWatch.Stop();
            result.Add("Время добавления элемента в конец списка", stopWatch.Elapsed.TotalMilliseconds);
            stopWatch.Reset();

            stopWatch.Start();
            linkedList.AddLast(' ');
            stopWatch.Stop();
            result.Add("Время добавления элемента в конец связанного списка", stopWatch.Elapsed.TotalMilliseconds);
            stopWatch.Reset();

            stopWatch.Start();
            list.Insert(1, ' ');
            stopWatch.Stop();
            result.Add("Время добавления элемента в середину списка", stopWatch.Elapsed.TotalMilliseconds);
            stopWatch.Reset();

            stopWatch.Start();
            linkedList.AddAfter(linkedList.First, ' ');
            stopWatch.Stop();
            result.Add("Время добавления элемента в середину связанного списка", stopWatch.Elapsed.TotalMilliseconds);
            stopWatch.Reset();

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value} мс");
            }
        }
    }
}
