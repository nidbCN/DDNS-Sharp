using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDNS_Sharp.Models
{
    public class Record
    {
        public string Value { get; set; }
        public Type Type { get; set; }



        public enum RecordType
        {
            A,
            AAAA
        }
    }
}
