//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BudgetCapture.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class GSS_PipelineSection
    {
        public GSS_PipelineSection()
        {
            this.GSS_Customer = new HashSet<GSS_Customer>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> TotalCapacity { get; set; }
        public Nullable<bool> isActive { get; set; }
    
        public virtual ICollection<GSS_Customer> GSS_Customer { get; set; }
    }
}