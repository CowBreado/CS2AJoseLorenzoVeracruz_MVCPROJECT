using System.ComponentModel.DataAnnotations;

namespace CS2AJoseLorenzoVeracruz_MVCPROJECT.BusLogic.Model
{
    public class tblStudent
    {
        [Key]
        public int id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Age { get; set; }
        public string? Course { get; set; }
    }
}
