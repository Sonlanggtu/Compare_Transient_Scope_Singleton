using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare_Transient_Scope_Singleton.IService
{
    public interface IScopeService
    {
        Guid? GetGuild();
    }
}
