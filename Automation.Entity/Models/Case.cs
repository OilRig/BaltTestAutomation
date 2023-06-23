namespace Automation.Entity.Models
{
    public class Case
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Contents { get; set; }

        public ICollection<Actions> Actions { get; set; }
    }
}
