using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;

namespace Cineplus.Services
{
    public class SettingsService: ISettingsService
    {
        private IRepository<Settings> _repository;
        
        public SettingsService(IRepository<Settings> repository) {
            _repository = repository;
        }

        
        public IEnumerable<Settings> GetAll()
        {
            return _repository.Data().AsEnumerable();
        }

        public Settings SetActiveDisplay(Settings setting)
        {
            var settings = new List<Settings>(GetAll());
            for (var i = 0; i < settings.Count; i++)
                settings[i].Active = settings[i].Id == setting.Id;
            _repository.UpdateAll(settings);
            setting.Active = true;
            return setting;
        }

        public Settings GetActiveDisplay()
        {
            return _repository.Data().FirstOrDefault(setting => setting.Active && setting.Type == "Display");
        }
    }
}