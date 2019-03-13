using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfToDB
{
    [DataContract]
    public class Lagervare
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public int price { get; set; }

        [DataMember]
        public int quantity { get; set; }
    }
}
