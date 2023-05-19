
namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; } //Primary Key
    public string ClientName { get; set; }
    public string Description { get; set; }
    public int StylistId { get; set; }  //Foreign Key
    public Stylist Stylist { get; set; }  //Navigation Property
  }
}