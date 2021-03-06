using System.Collections.Generic;
using System.ComponentModel;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
      {
        this.EngineerMachineJoinEntity = new HashSet<EngineerMachine>();
      }

      public int MachineId { get; set; }

      [DisplayName("Machine Name")]
      public string MachineName { get; set; }
      public virtual ICollection<EngineerMachine> EngineerMachineJoinEntity { get; set; }
    }
}