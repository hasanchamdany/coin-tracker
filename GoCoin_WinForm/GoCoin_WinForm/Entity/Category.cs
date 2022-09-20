using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace GoCoin_WinForm.Entity
{
    class Category
    {
        // properties
        public int Id { get; set; }
        public string Category_name { get; set; }

        //constructor
        public Category() { }
        public Category(int id, string category_name)
        {
            Id = id;
            Category_name = category_name;
        }
    }
}
