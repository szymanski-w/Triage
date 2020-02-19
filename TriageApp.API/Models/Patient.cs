namespace TriageApp.API.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public int RespRate { get; set; }
        public string PatientName { get; set; }
        public bool IsWalking { get; set; }
        public bool IsBreathing { get; set; }        
        public bool CapRecurrence { get; set; }
        public bool Consciousness { get; set; }
        public int RescueOrder { get; set; }
    }
}