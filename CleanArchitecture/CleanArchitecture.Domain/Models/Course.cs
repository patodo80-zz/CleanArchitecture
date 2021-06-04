using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Models
{
    class Course
    {
        public int ID { get; set; }
        public string Name { get; set;  }
        public string Description { get; set;  }
        public string ImageURL { get; set; }

    }
}
