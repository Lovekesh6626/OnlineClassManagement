//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace database
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentCart
    {
        public Nullable<int> StudentId { get; set; }
        public Nullable<int> CourseID { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public int sno { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual CreateCourse CreateCourse { get; set; }
    }
}
