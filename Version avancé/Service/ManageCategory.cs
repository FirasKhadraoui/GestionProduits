using System;
using System.Collections.Generic;
using System.Text;
using Domain.entities;
namespace Service
{
    class ManageCategory
    {
        private IList<Categorie> categories;
        ManageCategory(IList<Categorie> categories)
        {
            this.categories = categories;
        }
    }
}
