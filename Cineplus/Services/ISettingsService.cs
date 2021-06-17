using System.Collections.Generic;
using Cineplus.Models;

namespace Cineplus.Services
{
    public interface ISettingsService
    {
        public IEnumerable<Settings> GetAllDisplay();

        public Settings SetActiveDisplay(Settings setting);

        public Settings GetActiveDisplay();

    }
}