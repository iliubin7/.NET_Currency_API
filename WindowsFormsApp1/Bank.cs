using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Rate
    {
        public int? ID { set; get; }
        public float mid { get; set; }
        public string no { get; set; }
        public string effectiveDate { get; set; }
    }
    internal class Bank
    {
        public string table { get; set; }
        public string currency { get; set; }
        public string code { get; set; }
        public List<Rate> rates { get; set; }
        //public override string ToString()
        //{
        //    return $"{this.rates.mid}";
        //}
    }
}
