using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.VaccinationCenter
{
    public class VaccinationCenterDto
    {
    public int Id { get; set; } // Primary Key

    public string Name { get; set; } = String.Empty;

    public string Address { get; set; } = String.Empty;

    public string ContactInfo { get; set; } = String.Empty;

    public int AdminId { get; set; } // Foreign Key to Users Table

    }
}