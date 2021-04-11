using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telerik_SampleProject.Model;

namespace Telerik_SampleProject.Repository.Registration
{
    public interface IRegistrationRepository
    {
        public Task<Boolean> Registration(RegistrationModel Model);
    }
}
