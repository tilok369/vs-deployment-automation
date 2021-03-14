using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsDeploymentAutomation.Library.Interfaces
{
    public interface IGitCommandManager
    {
        bool Pull(string command, out string output, out string error);
    }
}
