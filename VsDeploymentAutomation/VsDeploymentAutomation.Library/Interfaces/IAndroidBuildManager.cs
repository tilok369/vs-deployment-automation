using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsDeploymentAutomation.Library.Interfaces
{
    public interface IAndroidBuildManager
    {
        bool Build(string env, string entity, string path, out string output, out string error);
    }
}
