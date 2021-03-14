using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsDeploymentAutomation.Library.Interfaces
{
    public interface IMsBuildManager
    {
        bool Build(string arguments, out string output, out string error);
        bool Publish(string arguments, out string output, out string error);
    }
}
