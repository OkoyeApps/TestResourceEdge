﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resourceEdge.Domain.Entities
{
   public class Requisition
    {
        public int id { get; set; }
        public string RequisitionCode { get; set; }
        public Nullable<System.DateTime> OnboardDate { get; set; }
        public Nullable<int> PositionId { get; set; }
        public string ReportingId { get; set; }
        public Nullable<int> BusinessunitId { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public Nullable<int> JobTitle { get; set; }
        public string ReqNoPositions { get; set; }
        public string SelectedMembers { get; set; }
        public string FilledPositions { get; set; }
        public string JobDescription { get; set; }
        public string ReqSkills { get; set; }
        public string ReqQualification { get; set; }
        public string ReqExpYears { get; set; }
        public string EmpType { get; set; }
        public string ReqPriority { get; set; }
        public string AdditionalInfo { get; set; }
        public string ReqStatus { get; set; }
        public string Approver1 { get; set; }
        public string Approver2 { get; set; }
        public string Approver3 { get; set; }
        public string AppStatus1 { get; set; }
        public string AppStatus2 { get; set; }
        public string AppStatus3 { get; set; }
        public string Recruiters { get; set; }
        public string ClientId { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> modifiedDate { get; set; }
        public string Isactive { get; set; }
    }
}
