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
    public int Name { get; set; }
    public int phoneNumber { get; set; }
    public int ExpertiseNotes { get; set; }
    public int DaysOff { get; set; }
    public virtual ICollection<Client> Clients { get; set; }

  }
}