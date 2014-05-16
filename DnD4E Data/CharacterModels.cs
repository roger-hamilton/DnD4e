using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD4E_Data
{
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
        public ClassHealingSurge HealingSurge { get; set; }
        public virtual List<Skill> TrainedSkills { get; set; }
    }

    public class ClassHealingSurge
    {
        [Key]
        public int Id { get; set; }
        public Ability Ability { get; set; }
        public int Bonus { get; set; }
    }

    public class Power
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
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
    { }

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
    public class Equipment:Item
    {

    }
    public class Armor:Equipment
    {

    }
    public class Weapon:Equipment
    {

    }
}
