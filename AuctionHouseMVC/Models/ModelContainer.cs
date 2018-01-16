using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionHouseMVC.Models
{
    public class ModelContainer
    {
        public List<Category> cat { get; set; }
        private Dictionary<Type, object> models = new Dictionary<Type, object>();
        public ModelContainer()
        {
            cat = new List<Category>();
        }
        public void AddModel<T>(T t)
        {
            models.Add(t.GetType(), t);
        }
        public T GetModel<T>()
        {
            return (T)models[typeof(T)];
        }
    }
}