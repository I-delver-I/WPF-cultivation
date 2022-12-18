using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestLogic
{
    public class CowModel
    {
        public Guid ID { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public byte[] DnaData { get; set; }
    }
}