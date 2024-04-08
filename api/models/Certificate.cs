// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace api.models
// {
//     public class Certificate
//     {
//     public int Id { get; set; } // Primary Key

//     public int PatientId { get; set; } // Foreign Key to Users Table

//     public int VaccinationCenterId { get; set; } // Foreign Key to VaccinationCenters Table

//     public int VaccineId { get; set; } // Foreign Key to Vaccines Table

//     public string CertificateFile { get; set; } =  String.Empty;

//     public DateTime IssueDate { get; set; }

//     // Navigation properties
//     public User? Patient { get; set; } // Navigation to the patient who received the certificate
//     public VaccinationCenter? VaccinationCenter { get; set; } // Navigation to the vaccination center that issued the certificate
//     public Vaccine? Vaccine { get; set; } // Navigation to the vaccine for which the certificate was issued

//     }
// }