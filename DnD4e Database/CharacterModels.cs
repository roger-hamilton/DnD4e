using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD4e_Database
{
    public class DnDDatabase:DbContext
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
    public class CharacterClass
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Role {get;set;}
        public PowerSource PowerSource { get; set; }
        public virtual List<Ability> KeyAbilities { get; set; }
        public virtual List<Equipment> Implements { get; set; }
        public virtual List<DefenceBonus> DefenceBonuses { get; set; }
        public int StartingHP { get; set; }
        public int HPPerLevel { get; set; }
        public HealingSurge HealingSurge { get; set; }
        public virtual List<Skill> TrainedSkills { get; set; }
    }

    public class HealingSurge
    {
        [Key]
        public int Id { get; set; }
        public Ability Ability { get; set; }
        public int Bonus { get; set; }
    }

    

    public abstract class Stat
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
    }

    public class PowerSource
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
    
    public class Ability:Stat
    { }
    public class Defence:Stat
    {
        public Ability Ability { get; set; }
    }

    public class DefenceBonus
    {
        [Key]
        public int Id { get; set; }
        public Defence Defence { get; set; }
        public int Bonus { get; set; }
    }
    public class AbilityBonus
    {
        [Key]
        public int Id { get; set; }
        public Ability Ability { get; set; }
        public int Bonus { get; set; }
    }

    public class Skill
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Ability Ability { get; set; }
        public bool ArmorCheck { get; set; }
    }

    public class SkillBonus
    {
        [Key]
        public int Id { get; set; }
        public Skill Skill { get; set; }
        public int Bonus { get; set; }
    }

    public class Feat
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    
}
