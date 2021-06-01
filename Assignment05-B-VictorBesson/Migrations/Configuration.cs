namespace Assignment05_B_VictorBesson.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using Assignment05_B_VictorBesson.DataTables;
    internal sealed class Configuration : DbMigrationsConfiguration<Assignment05_B_VictorBesson.DAL.SuperModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Assignment05_B_VictorBesson.DAL.SuperModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var specialties = new List<_IT_Specialty>
            {
                new _IT_Specialty{Specialty="Software"},
                new _IT_Specialty{Specialty="Hardware"},
                new _IT_Specialty{Specialty="Software/Hardware"}
            };
            specialties.ForEach(specialty => context.IT_Specialties.AddOrUpdate(s => new { s.Specialty }, specialty));
            context.SaveChanges();
            var requestTypes = new List<_RequestType>
            {
                new _RequestType{RequestType="Software Problem", SpecialtyID=1},
                new _RequestType{RequestType="Hardware Problem", SpecialtyID=2},
                new _RequestType{RequestType="Other", SpecialtyID=3}
            };
            requestTypes.ForEach(type => context.RequestTypes.AddOrUpdate(s => new { s.RequestType }, type));
            context.SaveChanges();
            var requestStatus = new List<_RequestStatus>
            {
                new _RequestStatus{RequestStatus="Available"},
                new _RequestStatus{RequestStatus="Accepted"},
                new _RequestStatus{RequestStatus="BeingWorkedOn"},
                new _RequestStatus{RequestStatus="Closed"}
            };
            requestStatus.ForEach(status => context.RequestStatuses.AddOrUpdate(s => new { s.RequestStatus }, status));
            context.SaveChanges();
            var priorities = new List<_Priority>
            {
                new _Priority{Description="Top"},
                new _Priority{Description="Above Average" },
                new _Priority{Description="Medium"},
                new _Priority{Description="Low"}
            };
            priorities.ForEach(priority => context.Priorities.AddOrUpdate(s => new { s.Description }, priority));
            context.SaveChanges();
            var Staff = new List<_IT_Member>
            {
                new _IT_Member{FirstName="griffin", LastName="vince", SpecialtyID=1, Admin=false, Country="canada", City="medicine hat", Email="griffin.vince@mymhc.ca", Password=md5hasher.GetMd5Hash("Pass123"), HiredDate = DateTime.Now, UserName="biffin"},
                new _IT_Member{FirstName="jon", LastName="latimer", SpecialtyID=1, Admin=false, Country="canada", City="medicine hat", Email="jon.latimer@mymhc.ca", Password=md5hasher.GetMd5Hash("AnimeLover"), HiredDate = DateTime.Now, UserName="jonchan"},
                new _IT_Member{FirstName="victor", LastName="Besson", SpecialtyID=1, Admin=true, Country="canada", City="medicine hat", Email="victor.besson@mymhc.ca", Password=md5hasher.GetMd5Hash("Kappa123"), HiredDate = DateTime.Now, UserName="bayson"},
                new _IT_Member{FirstName="zack", LastName="greenstein", SpecialtyID=3, Admin=false, Country="canada", City="medicine hat", Email="zack.greenstein@mymhc.ca", Password=md5hasher.GetMd5Hash("Pass123"), HiredDate = DateTime.Now, UserName="dergen"},
                new _IT_Member{FirstName="jordan", LastName="belfort", SpecialtyID=2, Admin=false, Country="canada", City="medicine hat", Email="jordan.belfort@mymhc.ca", Password=md5hasher.GetMd5Hash("Cars123"), HiredDate = DateTime.Now, UserName="jordy"},
                new _IT_Member{FirstName="louis", LastName="bai", SpecialtyID=2, Admin=false, Country="china", City="beijing", Email="louis.bai@mymhc.ca", Password=md5hasher.GetMd5Hash("Number1"), HiredDate = DateTime.Now, UserName="louis"}
            };
            Staff.ForEach( member => context.IT_Staff.AddOrUpdate(s => new { s.UserName }, member));
            context.SaveChanges();
        }
    }
}
