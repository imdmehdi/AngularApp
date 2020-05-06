using EntitiesLibrary.Interface;
using System;
using EntitiesLibrary.DTO;
using EntitiesLibrary.DbCont;
using IdentityServer4.EntityFramework.Options;
using Microsoft.Extensions.Options;

namespace EntitiesLibrary
{
    public class RegisterDetails:IRegisterDetails
    {
        private readonly IOptions<OperationalStoreOptions> operationalStoreOptions = null;

        public DTO.DTORegisterDetails SaveRegisterDetails(DTO.DTORegisterDetails registerDetails)
        {
            using (DboContext obj = new DboContext(new Microsoft.EntityFrameworkCore.DbContextOptions<DboContext>(), operationalStoreOptions))
                {
                obj.DTORegisterDetails.Add(registerDetails);
                obj.SaveChanges();
                return registerDetails;
            }
        }

       

        
    }
}
