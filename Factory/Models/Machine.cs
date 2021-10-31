using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
      {
        this.EngineerMachineJointEntity = new HashSet<EngineerMachine>();
      }

      public int MachineId { get; set; }
      public string MachineName { get; set; }
      public virtual ICollection<EngineerMachine> EngineerMachineJointEntity { get; set; }
    }
}