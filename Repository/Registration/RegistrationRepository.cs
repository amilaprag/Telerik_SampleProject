using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telerik_SampleProject.Model;

namespace Telerik_SampleProject.Repository.Registration
{
    public class RegistrationRepository : IRegistrationRepository
    {
        public RegistrationRepository()
        {

        }
        public Task<bool> Registration(RegistrationModel Model)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            return Task.FromResult(true);
        }
    }
}
