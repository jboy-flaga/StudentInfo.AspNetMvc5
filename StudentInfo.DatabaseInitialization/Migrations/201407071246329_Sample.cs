//namespace StudentInfo.DatabaseInitialization.Migrations
//{
//    using System;
//    using System.Data.Entity.Migrations;
    
//    /// <summary>
//    /// JBOY: This is just a sample migration
//    /// </summary>
//    public partial class Sample : DbMigration
//    {
//        public override void Up()
//        {
//        }

//        public override void Down()
//        {
//        }
        
//        /// JBOY: You commented the code below because you will be using automatic migrations
//        ///         You commented them instead of deleting them becase you might want to use them as reference in the future
//        ///         
//        //public override void Up()
//        //{
//        //    CreateTable(
//        //        "dbo.GradeRecords",
//        //        c => new
//        //            {
//        //                RegistrationId = c.Int(nullable: false),
//        //                SubjectId = c.Int(nullable: false),
//        //                Grade = c.Decimal(nullable: false, precision: 18, scale: 2),
//        //            })
//        //        .PrimaryKey(t => new { t.RegistrationId, t.SubjectId })
//        //        .ForeignKey("dbo.Registrations", t => t.RegistrationId, cascadeDelete: true)
//        //        .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
//        //        .Index(t => t.RegistrationId)
//        //        .Index(t => t.SubjectId);
            
//        //    CreateTable(
//        //        "dbo.Registrations",
//        //        c => new
//        //            {
//        //                RegistrationId = c.Int(nullable: false, identity: true),
//        //                StudentId = c.Int(nullable: false),
//        //                DateOfRegistration = c.DateTime(nullable: false),
//        //                DegreeId = c.Int(nullable: false),
//        //                SchoolYearFrom = c.Int(nullable: false),
//        //                SchoolYearTo = c.Int(nullable: false),
//        //                Semester = c.Int(nullable: false),
//        //            })
//        //        .PrimaryKey(t => t.RegistrationId);
            
//        //    CreateTable(
//        //        "dbo.Subjects",
//        //        c => new
//        //            {
//        //                Id = c.Int(nullable: false, identity: true),
//        //                SubjectCode = c.String(),
//        //                Name = c.String(),
//        //                NumberOfUnits = c.Int(nullable: false),
//        //            })
//        //        .PrimaryKey(t => t.Id);
            
//        //    CreateTable(
//        //        "dbo.PaymentRecords",
//        //        c => new
//        //            {
//        //                Id = c.Int(nullable: false, identity: true),
//        //                RegistrationId = c.Int(nullable: false),
//        //                DateAndTimeOfPayment = c.DateTime(nullable: false),
//        //                Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
//        //            })
//        //        .PrimaryKey(t => t.Id)
//        //        .ForeignKey("dbo.Registrations", t => t.RegistrationId, cascadeDelete: true)
//        //        .Index(t => t.RegistrationId);
            
//        //    CreateTable(
//        //        "dbo.Students",
//        //        c => new
//        //            {
//        //                Id = c.Int(nullable: false, identity: true),
//        //                FirstName = c.String(),
//        //                LastName = c.String(),
//        //                DateOfBirth = c.DateTime(nullable: false),
//        //                Address = c.String(),
//        //                Email = c.String(),
//        //            })
//        //        .PrimaryKey(t => t.Id);
            
//        //}
        
//        //public override void Down()
//        //{
//        //    DropForeignKey("dbo.PaymentRecords", "RegistrationId", "dbo.Registrations");
//        //    DropForeignKey("dbo.GradeRecords", "SubjectId", "dbo.Subjects");
//        //    DropForeignKey("dbo.GradeRecords", "RegistrationId", "dbo.Registrations");
//        //    DropIndex("dbo.PaymentRecords", new[] { "RegistrationId" });
//        //    DropIndex("dbo.GradeRecords", new[] { "SubjectId" });
//        //    DropIndex("dbo.GradeRecords", new[] { "RegistrationId" });
//        //    DropTable("dbo.Students");
//        //    DropTable("dbo.PaymentRecords");
//        //    DropTable("dbo.Subjects");
//        //    DropTable("dbo.Registrations");
//        //    DropTable("dbo.GradeRecords");
//        //}
//    }
//}
