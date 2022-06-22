using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_web_app.Models
{
    public class Archive
    {
        public int ID { get; set;}
        public string Description { get; set;}
        
        public decimal Size { get; set;}

    }
}
