using MathNet.Numerics.Statistics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CodeChallenge.BusinessLogic
{
    public class Domain 
    {
        public static string[][] ArrangeData(string File_Path)
        {
            var lines = File.ReadAllLines(File_Path).Select(a => a.Split(';')).ToArray();
            var dataRowsArray = lines.Skip(1).ToArray();
            return dataRowsArray;
        }

        public static Double CalculateMedian(string[][] dataRowsArray)
        {
            List<double> listDataValue = new List<double>();
            var median = new double();
            foreach (var item in dataRowsArray)
            {
                var eachLine = string.Join(",", item);
                var arr = eachLine.Split(",");
                var medianValue = Convert.ToDouble(arr[5]);
                listDataValue.Add(medianValue);
            }
            median = listDataValue.Median();
            return median;
        }

        public static List<CsvObject> GetDataResult(string File_Path, double median, string name, string[][] dataRowsArray)
        {
            List<CsvObject> res = new List<CsvObject>();

            // 20% above or below median value
            var percentageAbove = ((median * .2) + median);
            var percentageBelow = (median - (median * .2));

            foreach (var item in dataRowsArray)
            {
                var eachLine = string.Join(",", item);
                var arr = eachLine.Split(",");
                if ((Convert.ToDouble(arr[5]) > percentageAbove) || (Convert.ToDouble(arr[5]) < percentageBelow))
                {
                    var result = new CsvObject
                    {
                        Name = name,
                        MedianValue = median,
                        DateTime = arr[3],
                        Value = arr[5]
                    };
                    res.Add(result);
                }
            }
            return res;
        }
    }
}
