﻿
namespace PFCharacterSheetEditor.Models
{
    public class CharacterSheet
    {
        public string CharacterName { get; set; }
        public int CharacterLevel { get; set; }
        public string CharacterClass { get; set; }
        public string Alignment { get; set; }
        public string PlayerName { get; set; }
        public string Deity { get; set; }
        public string Homeland { get; set; }
        public string Race { get; set; }
        public string Size { get; set; }
        public char Gender { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Hair { get; set; }
        public string Eyes { get; set; }
        public int BaseSpeed { get; set; }
        public int BaseSpeedWithArmor { get; set; }
        public int? BaseFlySpeed { get; set; }
        public int? FlyManuverability { get; set; }
        public int? BaseSwimSpeed { get; set; }
        public int? BaseClimbSpeed { get; set; }
        public int? BaseBurrowSpeed { get; set; }
        public bool ClassSkillAcrobatics { get; set; }
        public bool ClassSkillAppraise { get; set; }
        public bool ClassSkillBluff { get; set; }
        public bool ClassSkillCraft { get; set; }
        public bool ClassSkillDiplomacy { get; set; }
        public bool ClassSkillDisableDevice { get; set; }
        public bool ClassSkillDisguise { get; set; }
        public bool ClassSkillEscapeArtist { get; set; }
        public bool ClassSkillFly { get; set; }
        public bool ClassSkillHandleAnimal { get; set; }
        public bool ClassSkillHeal { get; set; }
        public bool ClassSkillIntimidate { get; set; }
        public bool ClassSkillKnowledgeArcana { get; set; }
        public bool ClassSkillKnowledgeDungeoneering { get; set; }
        public bool ClassSkillKnowledgeEngineering { get; set; }
        public bool ClassSkillKnowledgeGeography { get; set; }
        public bool ClassSkillKnowledgeHistory { get; set; }
        public bool ClassSkillKnowledgeLocal { get; set; }
        public bool ClassSkillKnowledgeNature { get; set; }
        public bool ClassSkillKnowledgeNobility { get; set; }
        public bool ClassSkillKnowledgePlanes { get; set; }
        public bool ClassSkillLingusitics { get; set; }
        public bool ClassSkillPerception { get; set; }
        public bool ClassSkillPerform { get; set; }
        public bool ClassSkillProfession { get; set; }
        public bool ClassSkillRide { get; set; }
        public bool ClassSkillSenseMotive { get; set; }
        public bool ClassSkillSleightOfHand { get; set; }
        public bool ClassSkillSpellcraft { get; set; }
        public bool ClassSkillStealth { get; set; }
        public bool ClassSkillSurvival { get; set; }
        public bool ClassSkillSwim { get; set; }
        public bool ClassSkillUseMagicDevice { get; set; }
        public int StrengthScore { get; set; }
        public int DexterityScore { get; set; }
        public int ConstitutionScore { get; set; }
        public int IntelligenceScore { get; set; }
        public int WisdomScore { get; set; }
        public int CharismaScore { get; set; }
    }
}