using System;
namespace reqrestRefitRazorA.Models
{

    
   
        
    public class ResponseUser
        {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public List<Data> data { get; set; } = new List<Data>();
        public Support support { get; set; }

    }
   
}

