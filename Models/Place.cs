using System.Collections.Generic;

namespace sillypub.Models {
    public class Place {
        public string Name{get; set;}
        public string About{get; set;}
        public int PhoneNumber{get; set;}
        public bool Open{get; set;}
        public List<Review> Reviews{get; set;}
    }
}