﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resourceEdge.Domain.Entities
{
   public  class Question
    {
        public int Id { get; set; }
        public string  UserIdForQuestion { get; set; }
        public string UserFullName { get; set; }
        public string EmpQuestion { get; set; }
        public string Description { get; set; }
        public int GroupId { get; set; }
        public int LocationId { get; set; }
        public int BusinessUnitId { get; set; }
        public int DepartmentId { get; set; }
        public Nullable<bool> Isactive { get; set; }
        public bool? Approved { get; set; }
        public string Createdby { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Nullable<bool> Isused { get; set; }
        public Group Group { get; set; }
        public BusinessUnit BusinessUnit { get; set; }
        public Location Location { get; set; }
    }
}