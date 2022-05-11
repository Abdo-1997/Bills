
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DomainLayer.Models
{
    public class ReceivedSamples
    {
        public int id { get; set; }

        public int receivingSideId { get; set; }
        public int clientId { get; set; }
        public DateTime recevingDate { get; set; }
        
        [Required()]
        public string  describtion { get; set; }
        public int numberOfSamples { get; set; }
        public string  attachments { get; set; }
        public string  clienAttachments { set; get; }
        public decimal sampleCost { set; get; }
        public bool status { set; get; }
        public virtual Client client { set; get; }
        public virtual ReceivingSide side { set; get; }


    }
}
