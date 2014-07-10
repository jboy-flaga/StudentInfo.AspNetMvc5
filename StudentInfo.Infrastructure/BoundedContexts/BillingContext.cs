using System;
using StudentInfo.Domain.Model;
using System.Data.Entity;

namespace StudentInfo.Infrastructure.Data.BoundedContexts
{
    public class BillingContext : BaseContext<BillingContext>
    {
        public DbSet<StudentReference> Students { get; set; }
        public DbSet<PaymentRecord> PaymentRecords { get; set; }
    }
}
