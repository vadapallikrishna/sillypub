using Microsoft.AspNetCore.Identity;
namespace sillypub.Models {
    public class User: IdentityUser {
        public string email {get; set;}
        public string password {get; set;}
        public string username {get; set;}
        public string city {get; set;}
        public string country {get; set;}
        public string address {get; set;}        
    }    
}