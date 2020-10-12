using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
    public int StylistId { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string ExpertiseNotes { get; set; }
    public string HireDate { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}