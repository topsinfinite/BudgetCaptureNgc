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
    
    public partial class IndirectBudgetItem
    {
        public IndirectBudgetItem()
        {
            this.IndirectBudgets = new HashSet<IndirectBudget>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Nullable<int> IndirectTypeID { get; set; }
        public string DelFlg { get; set; }
    
        public virtual IndirectType IndirectType { get; set; }
        public virtual ICollection<IndirectBudget> IndirectBudgets { get; set; }
    }
}
