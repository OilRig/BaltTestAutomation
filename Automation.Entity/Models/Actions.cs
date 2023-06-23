namespace Automation.Entity.Models
{
    public class Actions
    {
        public int Id { get; set; } 
        public int CaseId { get; set; }
        public int Order { get; set; }
        public DateTime DateTimeStarting { get; set; }
        public DateTime DateTimeFinishing { get; set;}
        public string Action { get; set; } 
        public bool Result { get; set; }

        public Case Case { get; set; }
    }
}
