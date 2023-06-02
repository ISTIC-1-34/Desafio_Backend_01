namespace SChallenge.Models.Event
{
    public class Event
    {
        public long Id { get; set; }
        public string? EventName { get; set; }
        public int? NumberParticipans { get; set; }
        public DateTime? EventDate { get; set; }
        public int? EventDuration { get; set; }
        public string? Creator { get; set; }
    }
}
