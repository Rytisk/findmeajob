//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobMatch
{
    using System;
    using System.Collections.Generic;
    
    public partial class Job
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Job()
        {
            this.RequiredSkill = new HashSet<RequiredSkill>();
            this.JobSeeker = new HashSet<JobSeeker>();
        }
    
        public int Id { get; set; }
        public int Employer_Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string JobDescription { get; set; }
        public string EducationRequirements { get; set; }
        public string AditionalRequirements { get; set; }
    
        public virtual Employer Employer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequiredSkill> RequiredSkill { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobSeeker> JobSeeker { get; set; }
    }
}
