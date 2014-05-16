using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD4e_Database
{
    public class Power
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
        public PowerUsage Usage { get; set; }
        public PowerType Type { get; set; }
        public string FlavorText { get; set; }
        public PowerSource PowerSource { get; set; }
        public virtual List<DamageType> DamageTypes { get; set; }
        public virtual List<EffectType> EffectTypes { get; set; }
        public virtual List<PowerAccessories> Accessories { get; set; }
        public AttackType AttackType { get; set; }
        public string Prerequisite { get; set; }
        public string Requirement { get; set; }
    }
    public class ActionType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Trigger { get; set; }
    }
    public class AttackType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FormatString { get; set; }
        public int Range1 { get; set; }
        public int Range2 { get; set; }
    }
    public class DamageType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class EffectType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    } 
    public class PowerAccessories
    {
        public int Id { get; set; }
    }
    public class PowerType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class PowerUsage
    {
        [Key]
        public int Id { get;set;}
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class ClassPower : Power
    {
        public CharacterClass Class { get; set; }
    }
}
