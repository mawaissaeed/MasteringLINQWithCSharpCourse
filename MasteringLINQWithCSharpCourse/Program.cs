﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using MoreLinq.Extensions;

namespace MasteringLINQWithCSharpCourse
{

    class Program
    {
        public Program()
        {
            //BatchDemo();
            //InterleaveDemo();
            //PermDemo();
            SplitDemo();
        }

        private void SplitDemo()
        {
            var rand = new Random();
            var numbers = Enumerable.Range(1, 100).Select(_ => rand.Next(10));

            var split = numbers.Split(5);
            foreach (var group in split)
                Console.WriteLine($"{group.Count()} elements :" +
                                  string.Join(", ", group));
        }

        private void PermDemo()
        {
            char[] letters = "draw".ToCharArray();

            foreach (var item in letters.Permutations())
            {
                Console.WriteLine(new string(item.ToArray()));
            }
        }

        private void InterleaveDemo()
        {
            var rand = new Random();
            var wholeNumbers = Enumerable.Range(1, 10).Select(_ => (double)rand.Next(10));
            var fractNumbers = Enumerable.Range(1, 10).Select(_ => rand.NextDouble());

            foreach (var d in wholeNumbers.Interleave(fractNumbers))
            {
                Console.Write(d);
                Console.Write("\t");
            }
            Console.WriteLine();
        }

        private void BatchDemo()
        {
            var numbers = Enumerable.Range(1, 100);
            foreach (var batch in numbers.Batch(10))
            {
                Console.WriteLine("Got a batch!");
                foreach (var i in batch)
                    Console.Write($"{i}\t");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            new Program();
            // 40. MoreLINQ

            // This is a extension and have many useful features 
        }
    }
    
}
