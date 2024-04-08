// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace api.models
// {
//     public class Vaccine
//     {
//     public int Id { get; set; } // Primary Key

//     public string Name { get; set; } = String.Empty;

//     public string Precautions { get; set; } = String.Empty;

//     public int VaccinationCenterId { get; set; } // Foreign Key to VaccinationCenters Table

//     public TimeSpan TimeGapFirstSecondDose { get; set; }

//     // Navigation properties
//     public VaccinationCenter? VaccinationCenter { get; set; } // Navigation property for Vaccination Center
//     public ICollection<Reservation>? Reservations { get; set; } // For Vaccine
//     // public ICollection<Certificate>? Certificates { get; set; } // For Vaccine

//     }
// }