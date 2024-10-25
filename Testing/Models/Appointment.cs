namespace Testing.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }

        public string? FullName { get; set; }
        public string? SurName { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public string? ServiceType { get; set; }

        public DateTime PreferredDate { get; set; }

        public TimeSpan PreferredTime { get; set; }

        public string? AdditionalNotes { get; set; }
    }
}
