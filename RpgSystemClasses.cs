using System;

namespace RpgSystemLib
{
    public class RpgSystem
    {
        private RpgSystemSheet Sheet;
        private List<RpgSystemRule> Rules;
    }

    public class RpgSystemSheet
    {
        public string CharacterName;
        public string CharacterDescription;
        public int Level;      
        public List<RpgSystemAttribute> Attributes;
        public List<RpgSystemPerk> Perks;
        public List<RpgSystemCapability> Capabilities;
        public List<RpgSystemAction> Actions;
    }

    public class RpgSystemCapability
    {
        public string Name;
        public string Description;
        public string CostName;
        public int Cost;
    }

    public class RpgSystemPerk
    {
        public string Name;
        public string AttributeName;
        public string PerkDescription;
        public int Modifier;
        public string CostName;
        public int Cost;
    }

    public class RpgSystemRule
    {
        public string Formula;
        public string Tag;
    }

    public class RpgSystemAttribute
    {
        public string Description;
        public string Name;
        public bool IsSecundary;
        public RpgSystemRule Rule;
    }

    public class RpgSystemAction
    {
        public bool IsCombatAction;
        public bool HasTarget;
        public string Name;
        public RpgSystemRule Rule;
        public int Cost;
    }  
}
