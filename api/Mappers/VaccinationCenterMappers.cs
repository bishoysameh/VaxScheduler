using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.VaccinationCenter;
using api.models;

namespace api.Mappers
{
    public static class VaccinationCenterMappers
    {
        public static VaccinationCenterDto ToVaccinationCenterDto(this VaccinationCenter vaccinationCenterModel){
            return new VaccinationCenterDto {
                Id = vaccinationCenterModel.Id,
                Name = vaccinationCenterModel.Name,
                Address = vaccinationCenterModel.Address,
                ContactInfo = vaccinationCenterModel.ContactInfo,
                AdminId = vaccinationCenterModel.AdminId
            };
        }

        public static VaccinationCenter ToVaccinationCenterFromCreateDto(this CreateVaccinationCenterRequestDto VaccinationCenterDto){
            return new VaccinationCenter{
                Name = VaccinationCenterDto.Name,
                Address = VaccinationCenterDto.Address,
                ContactInfo = VaccinationCenterDto.ContactInfo,
                AdminId = VaccinationCenterDto.AdminId
            };
        }
    }
}