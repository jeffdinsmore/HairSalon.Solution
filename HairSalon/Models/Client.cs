namespace HairSalon.Models
{
  public class Client
  {

    public int ClientId { get; set; }
    public int Name { get; set; }
    public int PhoneNumber { get; set; }
    public int Address { get; set; }
    public int Email { get; set; }
    public int StylingNotes { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}