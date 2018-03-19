using System;
using System.Collections.Generic;
using System.Text;

namespace GottaGo.Shared.Models
{
    public class Facility : DomainEntity
    {
        public string Name { get; set; }
        public bool OpenToPublic { get; set; }
    }
}
