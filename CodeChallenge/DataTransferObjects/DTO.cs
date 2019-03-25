using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using MathNet.Numerics.Statistics;

namespace CodeChallenge
{
    public class CsvObject
    {
        public string Name { get; set; }
        public double MedianValue { get; set; }
        public string Value { get; set; }
        public string DateTime { get; set; }
    }

    [DataContract]
    public class DTO
    {
        public string Name { get; set; }
        [DataMember(Name = "MeterPoint Code")]
        public string MeterPointCode { get; set; }
        [DataMember(Name = "Serial Number")]
        public string SerialNumber { get; set; }
        [DataMember(Name = "Plant Code")]
        public string PlantCode { get; set; }
        [DataMember(Name = "Date/Time")]
        public string DateTime { get; set; }
        [DataMember(Name = "Data Type")]
        public string DataType { get; set; }
        [DataMember(Name = "Data Value")]
        public string DataValue { get; set; }
        [DataMember(Name = "Units")]
        public string Units { get; set; }
        [DataMember(Name = "Status")]
        public string Status { get; set; }
        [DataMember(Name = "Energy")]
        public String Energy { get; set; }
        [DataMember(Name = "Maximum Demand")]
        public string MaximumDemand { get; set; }
        [DataMember(Name = "Time of Max Demand")]
        public string TimeOfMaxDemand { get; set; }
        [DataMember(Name = "Period")]
        public string Period { get; set; }
        [DataMember(Name = "DLS Active")]
        public string DLSActive { get; set; }
        [DataMember(Name = "Billing Reset Count")]
        public string BillingResetCount { get; set; }
        [DataMember(Name = "Billing Reset Date/Time")]
        public string BillingResetDateTime { get; set; }
        [DataMember(Name = "Rate")]
        public string Rate { get; set; }
    }


}
