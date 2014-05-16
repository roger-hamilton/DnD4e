using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD4e_Database
{
    public class DnD4eDatabaseContext : DbContext
    {
        public DbSet<CharacterClass> CharacterClasses { get; set; }
        public DbSet<Power> Powers { get; set; }
        public DbSet<PowerSource> PowerSources { get; set; }
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<Defence> Defences { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Feat> Feats { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Armor> Armor { get; set; }
    }
}
