
using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.models
{
    public class User
    {
    public int Id { get; set; } // Primary Key

    public string Username { get; set; } = String.Empty;

    public string Password { get; set; } = String.Empty;

    public string Role { get; set; }  = String.Empty;// Admin, Patient, Vaccination Center

    public string Status { get; set; } = String.Empty;// Accepted, Rejected, Pending

    // Navigation properties
    public ICollection<VaccinationCenter>? AdministeredVaccinationCenters { get; set; } // For Admin
    // public ICollection<Reservation>? Reservations { get; set; } // For Patient
    // public ICollection<Certificate>? Certificates { get; set; } // For Patient and Vaccination Center
    }
}