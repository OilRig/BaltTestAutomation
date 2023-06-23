

using Automation.Entity.Models;
using Microsoft.EntityFrameworkCore.Storage;

namespace ForTestHost.Models
{
    public class CaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Contents { get; set; }

    }
}
