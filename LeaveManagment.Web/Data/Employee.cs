using Microsoft.AspNetCore.Identity;

namespace LeaveManagment.Web.Data
{
    public class Employee :  IdentityUser
    {
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
     public  string? TaxId { get; set; }
     public DateTime BirthDate { get; set; }
     public DateTime DateJoined { get; set; }
    }
}
