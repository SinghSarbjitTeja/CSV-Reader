using ServiceStack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Globalization;
using MathNet.Numerics.Statistics;
using CodeChallenge.BusinessLogic;

namespace CodeChallenge.DataAccess
{
    public class DataAccess
    {
        // Calculates the median of any file type passed "LP or TOU"
        public double GetMedianValue(string File_Path)
        {
            var result = new double();

            // Making an array with each line in csv files
            var dataRowsArray = Domain.ArrangeData(File_Path);

            if (dataRowsArray != null)
            {
                try
                {
                    result = Domain.CalculateMedian(dataRowsArray);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return result;
        }

        //Returns the object to be sent to UI to display data with 20% abve or below the median
        public IEnumerable<CsvObject> GetData(string File_Path, double median, string name)
        {
            var dataRowsArray = Domain.ArrangeData(File_Path);
            List<CsvObject> res = new List<CsvObject>();

            // Check for null and any exception occurs 
            if (dataRowsArray != null)
            {
                try
                {
                    res = Domain.GetDataResult(File_Path, median, name, dataRowsArray);
                }
                catch (Exception)
                {
                    throw ;
                }
            }
            return res;
        }
    }
}

