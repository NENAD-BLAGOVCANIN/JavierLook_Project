namespace JavierLook.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string BookedBy { get; set; }
        public string Status { get; set; }
    }
}
