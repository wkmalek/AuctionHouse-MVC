using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AuctionHouseMVC.Models
{
    public class CategoriesContext : DbContext
    {
        public DbSet<Category> categories { get; set; }

        public CategoriesContext()
        {
            
        }

        public List<string> GetCategoriesWithChildrens(string id)
        {
            //returns list of categories with their childrens
            //DbSet<Categories> categories = new DbSet<Categories>();
            Category cat = categories.Where(x => x.ID == id).SingleOrDefault();
            List<string> categoryList = new List<string>();
            categoryList = FindAllChildrens(categoryList, cat, cat.ID);
            categoryList.Add(id);

            return categoryList;
        }

        private List<string> FindAllChildrens(List<string> categoryList, Category cat, string parentId)
        {
            List<Category> catList = categories.ToList();
            foreach(var item in catList)
            {
                if(item.Pid == parentId)
                {
                    categoryList.Add(item.ID);
                    categoryList.AddRange(FindAllChildrens(categoryList, cat, item.ID));
                }
            }
            return categoryList;
        }
    }
}