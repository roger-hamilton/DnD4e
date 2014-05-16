using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD4e_Database
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ItemGroup Group { get; set; }
    }

    public class ItemGroup
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Equipment : Item
    {

    }

    public class Armor : Equipment
    {

    }

    public class Weapon : Equipment
    {

    }
}
