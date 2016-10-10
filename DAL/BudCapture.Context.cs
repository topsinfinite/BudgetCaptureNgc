﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BudgetCaptureDBEntities : DbContext
    {
        public BudgetCaptureDBEntities()
            : base("name=BudgetCaptureDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BudgetYear> BudgetYears { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Directorate> Directorates { get; set; }
        public DbSet<ExistingStaff> ExistingStaffs { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<ListedSecurity> ListedSecurities { get; set; }
        public DbSet<MonthOfYear> MonthOfYears { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<ExpenseProjection> ExpenseProjections { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetBudget> AssetBudgets { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<BudgetSummaryView> BudgetSummaryViews { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
        public DbSet<BudgetMenuItem> BudgetMenuItems { get; set; }
        public DbSet<DepartmentBudgetMenu> DepartmentBudgetMenus { get; set; }
        public DbSet<GradeSalaryElement> GradeSalaryElements { get; set; }
        public DbSet<SalaryElement> SalaryElements { get; set; }
        public DbSet<SalBenCategory> SalBenCategories { get; set; }
        public DbSet<IndirectType> IndirectTypes { get; set; }
        public DbSet<IndirectBudgetItem> IndirectBudgetItems { get; set; }
        public DbSet<IndirectBudget> IndirectBudgets { get; set; }
        public DbSet<DirectBudget> DirectBudgets { get; set; }
        public DbSet<DirectExpenseItem> DirectExpenseItems { get; set; }
        public DbSet<DirectType> DirectTypes { get; set; }
        public DbSet<CapexBudget> CapexBudgets { get; set; }
        public DbSet<CapexExpenseItem> CapexExpenseItems { get; set; }
        public DbSet<CapexType> CapexTypes { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<RevenueProjection> RevenueProjections { get; set; }
        public DbSet<TrackApproval> TrackApprovals { get; set; }
        public DbSet<ATCRequestHeader> ATCRequestHeaders { get; set; }
        public DbSet<GSS_Invoice> GSS_Invoice { get; set; }
        public DbSet<GSS_PipelineSection> GSS_PipelineSection { get; set; }
        public DbSet<GSS_SalesTbl> GSS_SalesTbl { get; set; }
        public DbSet<GSS_Customer> GSS_Customer { get; set; }
        public DbSet<IndirectBudgetATC> IndirectBudgetATCs { get; set; }
        public DbSet<DirectBudgetATC> DirectBudgetATCs { get; set; }
        public DbSet<AssetBudgetATC> AssetBudgetATCs { get; set; }
        public DbSet<CapexBudgetATC> CapexBudgetATCs { get; set; }
        public DbSet<ExistingStaffBudgetATC> ExistingStaffBudgetATCs { get; set; }
    }
}