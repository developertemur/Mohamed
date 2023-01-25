using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mohamed.Models
{
    public class User
    {
        public int Id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public Gender gender { get; set; }
        public int age { get; set; }
        public string phone_number { get; set; }
        public string area { get; set; }
        public string full_address { get; set; }
        public string education_status { get; set; }
        public string note { get; set; }
    }
    public enum Gender{
        Female,Male
    }
}