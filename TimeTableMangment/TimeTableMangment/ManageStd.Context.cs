//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimeTableMangment
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TimeTablemanagementdbEntities1 : DbContext
    {
        public TimeTablemanagementdbEntities1()
            : base("name=TimeTablemanagementdbEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ManageStdTB> ManageStdTBs { get; set; }
        public virtual DbSet<ManageStdTimeTB> ManageStdTimeTBs { get; set; }
    }
}
