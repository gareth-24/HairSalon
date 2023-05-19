using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Stylist
    {
      public int StylistId { get; set; }  //Primary Key
      public string StylistName { get; set; }
      public string Specialties { get; set; }
      public int YearsEmployed { get; set; }
      public List<Client> Clients { get; set; }
    }
}