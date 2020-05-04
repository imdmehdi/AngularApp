using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntitiesLibrary.DTO
{
    public class DTORegisterDetails
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string firstName { get; set; }
        [StringLength(255)]
        public string  lastName { get; set; }
        [StringLength(255)]
        public string  emailAddress { get; set; }
        public string  brave { get; set; }
    }
}
