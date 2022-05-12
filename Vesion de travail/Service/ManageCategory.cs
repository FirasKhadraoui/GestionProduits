using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Service
{
    public class ManageCategory
    {
        private List<Category> categories;
        public ManageCategory(List<Category> categories)
        {
            this.categories = categories;
        }
    }
}
