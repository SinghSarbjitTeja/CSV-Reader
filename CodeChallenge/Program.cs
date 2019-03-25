
using System;
using System.Collections.Generic;
using System.IO;
using CodeChallenge.DataAccess;
using System.Linq;
using MathNet.Numerics.Statistics;

namespace CodeChallenge
{
    public class Program
    {
        // File paths to print data
        private const string File_Path_LP1 = "../../../DataInput/LP_214612653_20150907T220027915.csv";
        private const string File_Path_LP2 = "../../../DataInput/LP_214612534_20150907T084333712.csv";
        private const string File_Path_LP3 = "../../../DataInput/LP_210095893_20150901T011608049.csv";
        private const string File_Path_TOU1 = "../../../DataInput/TOU_212621147_20150911T022240.csv";
        private const string File_Path_TOU2 = "../../../DataInput/TOU_212621145_20150911T022358.csv";
        private const string File_Path_TOU3 = "../../../DataInput/TOU_214667141_20150901T040057.csv";

        static void Main(string[] args)
        {
            var domain = new DataAccess.DataAccess();

            // First LP file results
            var median1 = domain.GetMedianValue(File_Path_LP1);
            var res1 = domain.GetData(File_Path_LP1, median1, "LP");
            if (res1.Count() == 0)
            {
                Console.WriteLine("{0}", "No Results for this file");
            }
            else
            {
                foreach (var item in res1)
                {
                    Console.WriteLine("{0}, {1}, {2}, {3}", item.Name, item.DateTime, item.Value, item.MedianValue);
                }
            }

            //second LP file results
            var median2 = domain.GetMedianValue(File_Path_LP2);
            var res2 = domain.GetData(File_Path_LP2, median2, "LP");
            if (res2.Count() == 0)
            {
                Console.WriteLine("{0}", "No Results for this file");
            }
            else
            {
                foreach (var item in res2)
                {
                    Console.WriteLine("{0}, {1}, {2}, {3}", item.Name, item.DateTime, item.Value, item.MedianValue);
                }
            }

            //Third LP file results
            var median3 = domain.GetMedianValue(File_Path_LP3);
            var res3 = domain.GetData(File_Path_LP3, median3, "LP");
            if (res3.Count() == 0)
            {
                Console.WriteLine("{0}", "No Results for this file");
            }
            else
            {
                foreach (var item in res3)
                {
                    Console.WriteLine("{0}, {1}, {2}, {3}", item.Name, item.DateTime, item.Value, item.MedianValue);
                }
            }

            // ---- Tests for TOU files

            // First TOU file results
            var median4 = domain.GetMedianValue(File_Path_TOU1);
            var res4 = domain.GetData(File_Path_TOU1, median4, "Energy");
            if (res4.Count() == 0)
            {
                Console.WriteLine("{0}", "No Results for this file");
            }
            else
            {
                foreach (var item in res4)
                {
                    Console.WriteLine("{0}, {1}, {2}, {3}", item.Name, item.DateTime, item.Value, item.MedianValue);
                }
            }
           
            // Second TOU file results
            var median5 = domain.GetMedianValue(File_Path_TOU2);
            var res5 = domain.GetData(File_Path_TOU2, median5, "Energy");
            if (res5.Count() == 0)
            {
                Console.WriteLine("{0}", "No Results for this file");
            }
            else
            {
                foreach (var item in res5)
                {
                    Console.WriteLine("{0}, {1}, {2}, {3}", item.Name, item.DateTime, item.Value, item.MedianValue);
                }
            }

            // Third TOU file results
            var median6 = domain.GetMedianValue(File_Path_TOU3);
            var res6 = domain.GetData(File_Path_TOU3, median6, "Energy");
            if (res6.Count() == 0)
            {
                Console.WriteLine("{0}", "No Results for this file");
            }
            else
            {
                foreach (var item in res6)
                {
                    Console.WriteLine("{0}, {1}, {2}, {3}", item.Name, item.DateTime, item.Value, item.MedianValue);
                }
            }
            Console.ReadLine();
        }
    }
}
