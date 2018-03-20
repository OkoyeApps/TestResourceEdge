﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resourceEdge.Domain.Entities
{
 public class EmployeeLeaveType
    {
        public int id { get; set; }
        public string leavetype { get; set; }
        public Nullable<int> numberofdays { get; set; }
        public string leavecode { get; set; }
        public string description { get; set; }
        public string leavepreallocated { get; set; }
        public Nullable<int> leavepredeductable { get; set; }
        public string createdby { get; set; }
        public string modifiedby { get; set; }
        public Nullable<System.DateTime> createddate { get; set; }
        public Nullable<System.DateTime> modifieddate { get; set; }
        public Nullable<bool> isactive { get; set; }
    }
}