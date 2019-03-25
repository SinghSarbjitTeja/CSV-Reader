using CodeChallenge;
using CodeChallenge.DataAccess;
using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Sdk;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private const string File_Path_LP = "../../../DataInput/LP_214612653_20150907T220027915.csv";
        private const string File_Path_TOU = "../../../DataInput/TOU_212621147_20150911T022240.csv";

        [Fact]
        public void Test_GetMedianValue_Returns_NoException()
        {
            //Act
            var dataAccess = new DataAccess();
            var median = dataAccess.GetMedianValue(File_Path_LP);

            //Assert         
            try
            {
                Assert.Throws<InvalidOperationException>(() => median);
            }
            catch (AssertActualExpectedException exception)
            {
                Assert.Equal("(No exception was thrown)", exception.Actual);
            }
        }

        [Fact]
        public void Test_GetMedianValue_Returns_DoubleValue()
        {
            //Act
            var dataAccess = new DataAccess();
            var median = dataAccess.GetMedianValue(File_Path_LP);

            //Assert         
            Assert.Equal(typeof(double), median.GetType());

        }

        [Fact]
        public void Test_GetData_Returns_NoException()
        {
            //Act
            var dataAccess = new DataAccess();
            double median = 1.89;
            var res = dataAccess.GetData(File_Path_LP, median, "LP");

            //Assert         
            try
            {
                Assert.Throws<InvalidOperationException>(() => res);
            }
            catch (AssertActualExpectedException exception)
            {
                Assert.Equal("(No exception was thrown)", exception.Actual);
            }

        }

        [Fact]
        public void Test_GetData_Returns_NotNull()
        {
            //Act
            var dataAccess = new DataAccess();
            double median = 1.89;

            var res = dataAccess.GetData(File_Path_LP, median, "LP");

            //Assert         
            Assert.NotNull(res);

        }

        [Fact]
        public void Test_GetData_Returns_IsAssignable_To_CsvObject()
        {
            //Act
            var dataAccess = new DataAccess();
            double median = 1.89;

            var res = dataAccess.GetData(File_Path_LP, median, "LP");

            //Assert         
            Assert.IsAssignableFrom<IEnumerable<CsvObject>>(res);

        }

        [Fact]
        public void Test_GetData_Returns_Data_With_TOU()
        {
            //Act
            var dataAccess = new DataAccess();
            double median = 1.89;

            var res = dataAccess.GetData(File_Path_TOU, median, "Energy");

            //Assert         
            Assert.NotNull(res);
            Assert.IsAssignableFrom<IEnumerable<CsvObject>>(res);

        }

        [Fact]
        public void Test_GetData_Returns_Data_With_LP()
        {
            //Act
            var dataAccess = new DataAccess();
            double median = 1.89;
            var res = dataAccess.GetData(File_Path_LP, median, "LP");

            //Assert         
            Assert.NotNull(res);                   
            Assert.IsAssignableFrom<IEnumerable<CsvObject>>(res);

        }
    }
}
