using System.ComponentModel.DataAnnotations;

namespace BookingApp.Models {
    public class BookingModel {
        //Properties
         public int Id { get; set; }
        [Required]
        public string? Service {get; set;}
        [Required]
        public string? Firstname {get; set;}
        [Required]
        public string? Lastname {get; set;}
        [Required]
        public string? Number {get; set;}
         public string? Minutes {get; set;}
         [Required]
         public DateTime? Date {get; set;}
         public bool APIKey { get; set;} = false;
    }
}