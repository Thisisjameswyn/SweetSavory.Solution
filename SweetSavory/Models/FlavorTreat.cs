namespace SweetSavory.Models
{
  public class FlavorTreat
  {       
    public int FlavorTreatId { get; set; }
    public int TreatId { get; set; }
    public int FlaovrId { get; set; }
    public virtual Treat Treat { get; set; }
    public virtual Flavor Flavor { get; set; }
  }
}