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
    
    public partial class coursecontent
    {
        public Nullable<int> content_id { get; set; }
        public string CourseThumbnail { get; set; }
        public string ImagesUrl { get; set; }
    
        public virtual CreateCourse CreateCourse { get; set; }
    }
}
