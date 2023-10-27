namespace AwesomeDevEvents.API.Entities
{
    public class DevEvent
    {
        public DevEvent() 
        {
            Speakers = new List<DevEventSpeaker> { };// lista se inicia vazia
            IsDeleted = false; // se inicia como false 
        }   
        public Guid Id { get; set; }    
        public string Title { get; set; }

        public string Description { get; set; } 

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<DevEventSpeaker> Speakers { get; set; }

        public bool IsDeleted { get; set; }

        // Metodos
        public void Update(string title, string description, DateTime startDate, DateTime enDate)
        {
            
        }



    }
}
