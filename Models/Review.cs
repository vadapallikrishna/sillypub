
namespace sillypub.Models {
    public class Review {
        public int Rating {get; set;}
        public string Title {get; set;}
        public string Content {get; set;}
        public int UserId{get;set;}
        public User User {get; set;}
    }
}