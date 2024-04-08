using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.models
{
    public class VaccinationCenter
    {
    public int Id { get; set; } // Primary Key

    public string Name { get; set; } = String.Empty;

    public string Address { get; set; } = String.Empty;

    public string ContactInfo { get; set; } = String.Empty;

    public int AdminId { get; set; } // Foreign Key to Users Table

    // Navigation properties
    public User? Admin { get; set; } // Navigation property for Admin
    // public ICollection<Vaccine>? Vaccines { get; set; } // For Vaccination Center
    // public ICollection<Reservation>? Reservations { get; set; } // For Vaccination Center
    // public ICollection<Certificate>? Certificates { get; set; } // For Vaccination Center

    }
}