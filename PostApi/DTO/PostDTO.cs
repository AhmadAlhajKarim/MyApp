using System;
using System.ComponentModel.DataAnnotations;

namespace PostApi.DTO
{
    public class PostDTO
    {

        [Required]
        public string Title { set; get; }
        [Required]
        public string Location { set; get; }
        public DateTime Date { get; set; }
        public string Picture { get; set; }
        public bool Reserved { get; set; }
    }
}
