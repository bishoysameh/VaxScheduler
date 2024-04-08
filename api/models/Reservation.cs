// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace api.models
// {
//     public class Reservation
//     {
//     public int Id { get; set; } // Primary Key

//     public int PatientId { get; set; } // Foreign Key to Users Table

//     public int VaccineId { get; set; } // Foreign Key to Vaccines Table

//     public string DoseNumber { get; set; } = String.Empty;// First Dose, Second Dose

//     public DateTime ReservationDate { get; set; }

//     public string Status { get; set; } = String.Empty; // Pending, Approved, Rejected

//     public int VaccinationCenterId { get; set; } // Foreign Key to VaccinationCenters Table

//     // Navigation properties
//     public User? Patient { get; set; } // Navigation property for Patient
//     public Vaccine? Vaccine { get; set; } // Navigation property for Vaccine
//     public VaccinationCenter? VaccinationCenter { get; set; } // Navigation property for Vaccination Center

//     }
// }