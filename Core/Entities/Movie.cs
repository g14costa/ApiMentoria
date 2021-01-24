using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Movie : BaseEntity
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
    }
}
