using Microsoft.AspNetCore.Mvc;

namespace DemoWEB2.Models
{
    public class StudentInfo
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public double? Marks { get; set; }

        
        public StudentInfo()
        {
            Id = "CT01";
            Name = "Thanh Nam";
            Marks = 7.5;
        }
    }
}
