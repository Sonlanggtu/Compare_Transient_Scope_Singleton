using Compare_Transient_Scope_Singleton.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare_Transient_Scope_Singleton.ImplementService
{
    public class ImplementDependencyService : IScopeService, ISingletonService, ITransientService
    {
        Guid? _id;
        public ImplementDependencyService() => _id = Guid.NewGuid();
        public Guid? GetGuild() => _id;

    }
}
