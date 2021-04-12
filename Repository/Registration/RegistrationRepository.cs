using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telerik_SampleProject.Database;
using Telerik_SampleProject.Model;

namespace Telerik_SampleProject.Repository.Registration
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private readonly DatabaseConntext _Context;
        private readonly ILogger<RegistrationRepository> _Logger;

        public RegistrationRepository(DatabaseConntext Context,ILogger<RegistrationRepository> Logger)
        {
            _Context = Context;
            _Logger = Logger;
        }
        public Task<bool> Registration(RegistrationModel Model)
        {
            try
            {
                _Context.Add(Model);
                _Context.SaveChanges();
            }
            catch (Exception ErrorMessage)
            {
                _Logger.LogWarning("Problem in data Insertion of Registration");
                _Logger.LogError(ErrorMessage.StackTrace);
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }
    }
}
