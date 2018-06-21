﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resourceEdge.Domain.Entities
{
    public class SystemController
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string  ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public ICollection<ActionMethod> Action { get; set; }
    }
}