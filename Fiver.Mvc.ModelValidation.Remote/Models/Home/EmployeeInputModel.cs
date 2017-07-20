using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Fiver.Mvc.ModelValidation.Remote.Models.Home
{
    public class EmployeeInputModel
    {
        [Required]
        [Remote(action: "ValidateEmployeeNo", controller: "Home")]
        public string EmployeeNo { get; set; }
    }
}
