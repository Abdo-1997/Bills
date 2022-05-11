using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Models
{
    public class ReceivingSide
    {
        public int id { get; set; }
        public string name { get; set; }
        IEnumerable<ReceivedSamples> samples { set; get; }
    }
}
