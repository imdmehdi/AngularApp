using EntitiesLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesLibrary.Interface
{
    public interface IRegisterDetails
    {
        DTO.DTORegisterDetails SaveRegisterDetails(DTO.DTORegisterDetails registerDetails);
        
    }
}
