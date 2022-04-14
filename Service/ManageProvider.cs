using System;
using System.Collections.Generic;
using System.Text;
using Domain.entities;
using System.Linq;
namespace Service
{
    public class ManageProvider
    {
        private IList<Provider> providers;
        ManageProvider(IList<Provider> providers)
        {
            this.providers = providers;
        }
        public IEnumerable<Provider> GetProviderByName(string name)
        {
            var query = from Provider in providers
                        where Provider.UserName.Contains(name)
                        select Provider;
            return query; 

        }
        public Provider GetFirstProviderByName(string name)
        {
            var query = (from Provider in providers
                        where Provider.UserName.StartsWith(name)
                        select Provider).FirstOrDefault();

            return query; 
        }
        public Provider GetProviderById(int id)
        {
            var query = (from Provider in providers
                         where Provider.Id == id
                         select Provider).SingleOrDefault();

            return query; 
        }
    }
}
