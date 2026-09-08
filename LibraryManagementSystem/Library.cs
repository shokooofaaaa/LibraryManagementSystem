using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Library
    {
        public List<Object> items = new List<Object>();
        public void AddItem<T>(LibraryItem<T> item)
        {
           
            items.Add(item);


        }
        public List<Object> GetItems()
        {
            return items;

        }
    }
}
