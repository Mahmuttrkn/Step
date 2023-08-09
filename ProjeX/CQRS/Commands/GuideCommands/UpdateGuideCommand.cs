using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.CQRS.Commands.GuideCommands
{
    public class UpdateGuideCommand
    {
        public int GuideID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
