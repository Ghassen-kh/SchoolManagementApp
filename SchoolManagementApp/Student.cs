//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagementApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int id { get; set; }
        public string studentFirstName { get; set; }
        public string studentLastName { get; set; }
        public Nullable<System.DateTime> dateOfBirth { get; set; }
        public Nullable<decimal> lastYearAverage { get; set; }
        public Nullable<int> studentLevelId { get; set; }
    
        public virtual Level Level { get; set; }
    }
}