
using System;
using csharp_vacations.Interfaces;

namespace csharp_vacations.Models
{
    public class Cruise : IVacation
    {
        public int Id { get; set; }
        public float Price { get; set; }
        public string Destination { get; set; }
        public string Type { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime SailDate { get; set; }
    }
}