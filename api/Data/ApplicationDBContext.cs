using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
        // public ApplicationDBContext(DbContextOptions dbContextOptions)
        // :base (dbContextOptions)
        // {

        // }

    public ApplicationDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions )
    {
    }




            public DbSet<User> Users {get; set;}
            public DbSet<VaccinationCenter> VaccinationCenters {get; set;}
            // public DbSet<Vaccine> Vaccines {get; set;}
            // public DbSet<Reservation> Reservations {get; set;}
            // public DbSet<Certificate> Certificates {get; set;}

    }

}