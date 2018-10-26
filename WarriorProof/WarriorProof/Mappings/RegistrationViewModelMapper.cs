using System;
using WarriorProof.Contacts.Models;
using WarriorProof.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WarriorProof.Mappings
{
    public static class RegistrationViewModelMapper
    {
        public static WarriorUser ToWarriorUser(this RegistrationViewModel model)
        {
            var warriorUser = new WarriorUser
            {
                Password = model.LoginInfo.Password,
                UserName = model.LoginInfo.UserName,
                PersonalInfo = new PersonalInfo
                {
                    FirstName = model.PersonalInfo.FirstName,
                    LastName = model.PersonalInfo.LastName,
                    EmailAddress = model.PersonalInfo.EmailAddress,
                    PhoneNumber = model.PersonalInfo.PhoneNumber
                },
                CompanyInfo = new CompanyInfo
                {
                    CompanyName = model.CompanyInfo.CompanyName,
                    EmailAddress = model.CompanyInfo.EmailAddress,
                    PhoneNumber = model.CompanyInfo.PhoneNumber,
                    Address = new Address
                    {
                        AddressLine1 = model.CompanyInfo.AddressLine1,
                        AddressLine2 = model.CompanyInfo.AddressLine2,
                        City = model.CompanyInfo.City,
                        State = model.CompanyInfo.State,
                        ZipCode = model.CompanyInfo.ZipCode
                    },
                    Trucks = new Trucks
                    {
                        NumberOfTrucks = model.TrucksInfo.NumberOfTrucks,
                        TrucksLineOfBusinesses = model.TrucksInfo.LineOfBusinesses.ToList()
                                                      .Select(x => new TrucksLineOfBusiness { LineOfBusiness_Id = Int32.Parse(x) }).ToList()
               
                    }
                }
            };
            return warriorUser;
        }


    }

}
