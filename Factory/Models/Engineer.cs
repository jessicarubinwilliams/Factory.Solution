using System.Collections.Generic;
using System.ComponentModel;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.EngineerMachineJoinEntity = new HashSet<EngineerMachine>();
    }
    public int EngineerId { get; set; }

    [DisplayName("Engineer Name `Last, First` ")]
    public string EngineerName { get; set; }
    
    public virtual ICollection<EngineerMachine> EngineerMachineJoinEntity { get;}
  }
}