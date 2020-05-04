using EntitiesLibrary.Interface;
using System;
using EntitiesLibrary.DTO;
using EntitiesLibrary.DbCont;

namespace EntitiesLibrary
{
    public class RegisterDetails:IRegisterDetails
    {
        public DTO.DTORegisterDetails SaveRegisterDetails(DTO.DTORegisterDetails registerDetails)
        {
            using (DboContext obj = new DboContext(new Microsoft.EntityFrameworkCore.DbContextOptions<DboContext>()))
                {
                obj.DTORegisterDetails.Add(registerDetails);
                obj.SaveChanges();
                return registerDetails;
            }
        }

       

        
    }
}
