using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.EngineerMachineJoinEntity = new HashSet<EngineerMachine>();
    }
    public int EngineerId { get; set; }
    public string EngineerFirstName { get; set; }
    public string EngineerLastName { get; set; }
    
    public virtual ICollection<EngineerMachine> EngineerMachineJoinEntity { get;}
  }
}