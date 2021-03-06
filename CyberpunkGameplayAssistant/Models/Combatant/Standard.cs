using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.Toolbox.ExtensionMethods;
using CyberpunkGameplayAssistant.ViewModels;
using CyberpunkGameplayAssistant.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Models
{
    [Serializable]
    public partial class Combatant : BaseModel
    {
        // Constructors
        public Combatant()
        {
            InitializeLists();
        }
        public Combatant(string name, string type, string @class, string imagePath, string armor)
        {
            InitializeLists();
            Type = type;
            Name = name;
            ComClass = @class;
            PortraitFilePath = imagePath;
            ArmorType = armor;
        }

        // Databound Properties
        private string _Name;
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private string _Variant;
        public string Variant
        {
            get => _Variant;
            set => SetAndNotify(ref _Variant, value);
        }
        private string _ComClass;
        public string ComClass
        {
            get => _ComClass;
            set => SetAndNotify(ref _ComClass, value);
        }
        private string _TrackerIndicator;
        public string TrackerIndicator
        {
            get => _TrackerIndicator;
            set => SetAndNotify(ref _TrackerIndicator, value);
        }
        private string _DisplayName;
        public string DisplayName
        {
            get => _DisplayName;
            set => SetAndNotify(ref _DisplayName, value);
        }
        private string _PortraitFilePath;
        public string PortraitFilePath
        {
            get => _PortraitFilePath;
            set => SetAndNotify(ref _PortraitFilePath, value);
        }
        private int _Initiative;
        public int Initiative
        {
            get => _Initiative;
            set => SetAndNotify(ref _Initiative, value);
        }
        private string _Type;
        public string Type
        {
            get => _Type;
            set => SetAndNotify(ref _Type, value);
        }
        private bool _IsActive;
        public bool IsActive
        {
            get => _IsActive;
            set => SetAndNotify(ref _IsActive, value);
        }
        private bool _IsAlly;
        public bool IsAlly
        {
            get => _IsAlly;
            set => SetAndNotify(ref _IsAlly, value);
        }
        private ObservableCollection<Stat> _BaseStats;
        public ObservableCollection<Stat> BaseStats
        {
            get => _BaseStats;
            set => SetAndNotify(ref _BaseStats, value);
        }
        private ObservableCollection<Stat> _CalculatedStats;
        public ObservableCollection<Stat> CalculatedStats
        {
            get => _CalculatedStats;
            set => SetAndNotify(ref _CalculatedStats, value);
        }
        private ObservableCollection<Skill> _Skills;
        public ObservableCollection<Skill> Skills
        {
            get => _Skills;
            set => SetAndNotify(ref _Skills, value);
        }
        private ObservableCollection<Skill> _AwarenessSkills;
        public ObservableCollection<Skill> AwarenessSkills
        {
            get => _AwarenessSkills;
            set => SetAndNotify(ref _AwarenessSkills, value);
        }
        private ObservableCollection<Skill> _BodySkills;
        public ObservableCollection<Skill> BodySkills
        {
            get => _BodySkills;
            set => SetAndNotify(ref _BodySkills, value);
        }
        private ObservableCollection<Skill> _ControlSkills;
        public ObservableCollection<Skill> ControlSkills
        {
            get => _ControlSkills;
            set => SetAndNotify(ref _ControlSkills, value);
        }
        private ObservableCollection<Skill> _PerformanceSkills;
        public ObservableCollection<Skill> PerformanceSkills
        {
            get => _PerformanceSkills;
            set => SetAndNotify(ref _PerformanceSkills, value);
        }
        private ObservableCollection<Skill> _EducationSkills;
        public ObservableCollection<Skill> EducationSkills
        {
            get => _EducationSkills;
            set => SetAndNotify(ref _EducationSkills, value);
        }
        private ObservableCollection<Skill> _FightingSkills;
        public ObservableCollection<Skill> FightingSkills
        {
            get => _FightingSkills;
            set => SetAndNotify(ref _FightingSkills, value);
        }
        private ObservableCollection<Skill> _RangedWeaponSkills;
        public ObservableCollection<Skill> RangedWeaponSkills
        {
            get => _RangedWeaponSkills;
            set => SetAndNotify(ref _RangedWeaponSkills, value);
        }
        private ObservableCollection<Skill> _SocialSkills;
        public ObservableCollection<Skill> SocialSkills
        {
            get => _SocialSkills;
            set => SetAndNotify(ref _SocialSkills, value);
        }
        private ObservableCollection<Skill> _TechniqueSkills;
        public ObservableCollection<Skill> TechniqueSkills
        {
            get => _TechniqueSkills;
            set => SetAndNotify(ref _TechniqueSkills, value);
        }
        private string _WoundState;
        public string WoundState
        {
            get => _WoundState;
            set => SetAndNotify(ref _WoundState, value);
        }

        private ObservableCollection<CombatantWeapon> _Weapons;
        public ObservableCollection<CombatantWeapon> Weapons
        {
            get => _Weapons;
            set => SetAndNotify(ref _Weapons, value);
        }

        private string _ShieldType;
        public string ShieldType
        {
            get => _ShieldType;
            set => SetAndNotify(ref _ShieldType, value);
        }
        private int _ShieldHp;
        public int ShieldHp
        {
            get => _ShieldHp;
            set => SetAndNotify(ref _ShieldHp, value);
        }

        private int _MaximumHitPoints;
        public int MaximumHitPoints
        {
            get => _MaximumHitPoints;
            set => SetAndNotify(ref _MaximumHitPoints, value);
        }
        private int _CurrentHitPoints;
        public int CurrentHitPoints
        {
            get => _CurrentHitPoints;
            set => SetAndNotify(ref _CurrentHitPoints, value);
        }
        private int _SeriouslyWoundedThreshold;
        public int SeriouslyWoundedThreshold
        {
            get => _SeriouslyWoundedThreshold;
            set => SetAndNotify(ref _SeriouslyWoundedThreshold, value);
        }
        private int _QuantityToAdd;
        public int QuantityToAdd
        {
            get => _QuantityToAdd;
            set => SetAndNotify(ref _QuantityToAdd, value);
        }
        private string _ArmorType;
        public string ArmorType
        {
            get => _ArmorType;
            set => SetAndNotify(ref _ArmorType, value);
        }
        private int _MaximumHeadStoppingPower;
        public int MaximumHeadStoppingPower
        {
            get => _MaximumHeadStoppingPower;
            set => SetAndNotify(ref _MaximumHeadStoppingPower, value);
        }
        private int _MaximumBodyStoppingPower;
        public int MaximumBodyStoppingPower
        {
            get => _MaximumBodyStoppingPower;
            set => SetAndNotify(ref _MaximumBodyStoppingPower, value);
        }
        private int _CurrentHeadStoppingPower;
        public int CurrentHeadStoppingPower
        {
            get => _CurrentHeadStoppingPower;
            set => SetAndNotify(ref _CurrentHeadStoppingPower, value);
        }
        private int _CurrentBodyStoppingPower;
        public int CurrentBodyStoppingPower
        {
            get => _CurrentBodyStoppingPower;
            set => SetAndNotify(ref _CurrentBodyStoppingPower, value);
        }
        private bool _WeaponMenuOpen;
        public bool WeaponMenuOpen
        {
            get => _WeaponMenuOpen;
            set => SetAndNotify(ref _WeaponMenuOpen, value);
        }
        private bool _StatSkillMenuOpen;
        public bool StatSkillMenuOpen
        {
            get => _StatSkillMenuOpen;
            set => SetAndNotify(ref _StatSkillMenuOpen, value);
        }
        private bool _ActionMenuOpen;
        public bool ActionMenuOpen
        {
            get => _ActionMenuOpen;
            set => SetAndNotify(ref _ActionMenuOpen, value);
        }
        private bool _InjuryMenuOpen;
        public bool InjuryMenuOpen
        {
            get => _InjuryMenuOpen;
            set => SetAndNotify(ref _InjuryMenuOpen, value);
        }
        private bool _ActiveWeaponMenuOpen;
        public bool ActiveWeaponMenuOpen
        {
            get => _ActiveWeaponMenuOpen;
            set => SetAndNotify(ref _ActiveWeaponMenuOpen, value);
        }
        private bool _ActiveStatSkillMenuOpen;
        public bool ActiveStatSkillMenuOpen
        {
            get => _ActiveStatSkillMenuOpen;
            set => SetAndNotify(ref _ActiveStatSkillMenuOpen, value);
        }
        private bool _ActiveActionMenuOpen;
        public bool ActiveActionMenuOpen
        {
            get => _ActiveActionMenuOpen;
            set => SetAndNotify(ref _ActiveActionMenuOpen, value);
        }
        private bool _ActiveInjuryMenuOpen;
        public bool ActiveInjuryMenuOpen
        {
            get => _ActiveInjuryMenuOpen;
            set => SetAndNotify(ref _ActiveInjuryMenuOpen, value);
        }
        private ObservableCollection<Ammo> _AmmoInventory;
        public ObservableCollection<Ammo> AmmoInventory
        {
            get => _AmmoInventory;
            set => SetAndNotify(ref _AmmoInventory, value);
        }
        private ObservableCollection<Gear> _GearInventory;
        public ObservableCollection<Gear> GearInventory
        {
            get => _GearInventory;
            set => SetAndNotify(ref _GearInventory, value);
        }
        private ObservableCollection<Cyberware> _InstalledCyberware;
        public ObservableCollection<Cyberware> InstalledCyberware
        {
            get => _InstalledCyberware;
            set => SetAndNotify(ref _InstalledCyberware, value);
        }
        private bool _IsDead;
        public bool IsDead
        {
            get => _IsDead;
            set => SetAndNotify(ref _IsDead, value);
        }
        private ObservableCollection<Action> _StandardActions;
        public ObservableCollection<Action> StandardActions
        {
            get => _StandardActions;
            set => SetAndNotify(ref _StandardActions, value);
        }
        
        private ObservableCollection<CriticalInjury> _CriticalInjuries;
        public ObservableCollection<CriticalInjury> CriticalInjuries
        {
            get => _CriticalInjuries;
            set => SetAndNotify(ref _CriticalInjuries, value);
        }
        public int MoveSpeed
        {
            get
            {
                int move = CalculatedStats.GetValue(AppData.StatMovement);
                int penalty = 0;
                if (WoundState == AppData.WoundStateMortallyWounded) { penalty += 6; }
                penalty += CriticalInjuries.GetMovePenaltyTotal();
                move -= penalty;
                if (move < 1) { move = 1; }
                return move;
            }
        }
        public int DeathSave
        {
            get
            {
                int death = CalculatedStats.GetValue(AppData.StatBody);
                return death;
            }
        }
        private int _DeathSavePasses;
        public int DeathSavePasses
        {
            get => _DeathSavePasses;
            set => SetAndNotify(ref _DeathSavePasses, value);
        }

        // Dropdown Sources
        public List<string> ShieldTypes
        {
            get
            {
                return new()
                {
                    AppData.ShieldTypeNone,
                    AppData.ShieldTypeBulletproofShield,
                    AppData.ShieldTypeCorpse,
                    AppData.ShieldTypeHumanShield
                };
            }
        }

        // Commands
        public ICommand AdjustHitPoints => new RelayCommand(DoAdjustHitPoints);
        private void DoAdjustHitPoints(object param)
        {
            int hitPointChange = Convert.ToInt32(param);
            CurrentHitPoints += hitPointChange;
            if (CurrentHitPoints < 0) { CurrentHitPoints = 0; }
            if (CurrentHitPoints > MaximumHitPoints) { CurrentHitPoints = MaximumHitPoints; }
            UpdateWoundState();
        }
        public ICommand AdjustShieldHp => new RelayCommand(DoAdjustShieldHp);
        private void DoAdjustShieldHp(object param)
        {
            int hitPointChange = Convert.ToInt32(param);
            ShieldHp += hitPointChange;
            if (ShieldHp < 0) { ShieldHp = 0; ShieldType = AppData.ShieldTypeNone; }
        }
        public ICommand AdjustStoppingPower => new RelayCommand(DoAdjustStoppingPower);
        private void DoAdjustStoppingPower(object param)
        {
            string[] parts = param.ToString().Split(',');
            string area = parts[0];
            int amount = Convert.ToInt32(parts[1]);
            if (area == "Head")
            {
                CurrentHeadStoppingPower += amount;
                if (CurrentHeadStoppingPower < 0) { CurrentHeadStoppingPower = 0; }
                if (CurrentHeadStoppingPower > MaximumHeadStoppingPower) { CurrentHeadStoppingPower = MaximumHeadStoppingPower; }
            }
            if (area == "Body")
            {
                CurrentBodyStoppingPower += amount;
                if (CurrentBodyStoppingPower < 0) { CurrentBodyStoppingPower = 0; }
                if (CurrentBodyStoppingPower > MaximumBodyStoppingPower) { CurrentBodyStoppingPower = MaximumBodyStoppingPower; }
            }
        }
        public ICommand ToggleDeath => new RelayCommand(DoToggleDeath);
        private void DoToggleDeath(object param)
        {
            IsDead = !IsDead;
            UpdateWoundState();
        }
        public ICommand ToggleAlly => new RelayCommand(DoToggleAlly);
        private void DoToggleAlly(object param)
        {
            IsAlly = !IsAlly;
        }
        public ICommand AddCriticalInjury => new RelayCommand(DoAddCriticalInjury);
        private void DoAddCriticalInjury(object param)
        {
            MultiObjectSelectionDialog selectionDialog = new(AppData.AllCriticalInjuries.ToNamedRecordList(), AppData.MultiModeCriticalInjuries);

            if (selectionDialog.ShowDialog() == true)
            {
                foreach (NamedRecord record in (selectionDialog.DataContext as MultiObjectSelectionViewModel).SelectedRecords)
                {
                    if (CriticalInjuries.FirstOrDefault(c => c.Name == record.Name) != null) { continue; }
                    else
                    {
                        CriticalInjuries.Add(record.ToCriticalInjury());
                    }
                }
                NotifyPropertyChanged(nameof(MoveSpeed));
            }
        }
        public ICommand MakeActive => new RelayCommand(DoMakeActive);
        private void DoMakeActive(object param)
        {
            IsActive = true;
            AppData.MainModelRef.CampaignView.ActiveCampaign.MarkCombatantsInactiveExcept(this);
            AppData.MainModelRef.CampaignView.ActiveCampaign.UpdateActiveCombatant();
        }
        public ICommand DeletePlayer => new RelayCommand(DoDeletePlayer);
        private void DoDeletePlayer(object param)
        {
            AppData.MainModelRef.CampaignView.ActiveCampaign.Players.Remove(this);
        }
        public ICommand SelectPortraitImage => new RelayCommand(DoSelectPortraitImage);
        private void DoSelectPortraitImage(object param)
        {
            PortraitFilePath = HelperMethods.GetFile(AppData.FilterImageFiles, AppData.PlayerImageDirectory);
        }
        public ICommand RemoveFromFirefight => new RelayCommand(DoRemoveFromFirefight);
        private void DoRemoveFromFirefight(object param)
        {
            AppData.MainModelRef.CampaignView.ActiveCampaign.AllCombatants.Remove(this);
            AppData.MainModelRef.CampaignView.ActiveCampaign.SortCombatants.Execute(null);
        }

        // Public Methods
        public void InitializeLoadedCombatant()
        {
            SetCalculatedStats();
            SetHitPoints(false);
            SetStoppingPower(false);
            UpdateWoundState();
            UpdateGearDescriptions();
            UpdateCyberwareDescriptions();
            OrganizeSkillsToCategories();
            SetStandardActions();
            GetCriticalInjuryDescriptions();
        }
        public void InitializeNewCombatant()
        {
            SetCalculatedStats();
            SetHitPoints(true);
            SetStoppingPower(true);
            ReloadAllWeapons();
            SetStandardActions();
        }
        public void SetStats(int INT, int REF, int DEX, int TECH, int COOL, int WILL, int LUCK, int MOVE, int BODY, int EMP)
        {
            BaseStats = new();
            BaseStats.Add(new(AppData.StatIntelligence, INT));
            BaseStats.Add(new(AppData.StatReflexes, REF));
            BaseStats.Add(new(AppData.StatDexterity, DEX));
            BaseStats.Add(new(AppData.StatTechnique, TECH));
            BaseStats.Add(new(AppData.StatCool, COOL));
            BaseStats.Add(new(AppData.StatWillpower, WILL));
            BaseStats.Add(new(AppData.StatLuck, LUCK));
            BaseStats.Add(new(AppData.StatMovement, MOVE));
            BaseStats.Add(new(AppData.StatBody, BODY));
            BaseStats.Add(new(AppData.StatEmpathy, EMP));
            SetBaseSkills();
            SetClassSkills();
        }
        public void SetBlackIceStats(string role, int PER, int SPD, int ATK, int DEF, int REZ, string effect)
        {
            PlayerRole = role;
            BaseStats = new();
            BaseStats.Add(new(AppData.NetPerception, PER));
            BaseStats.Add(new(AppData.NetSpeed, SPD));
            BaseStats.Add(new(AppData.NetAttack, ATK));
            BaseStats.Add(new(AppData.NetDefense, DEF));
            MaximumHitPoints = REZ;
            CurrentHitPoints = REZ;
            Notes = effect;
        }
        public void SetDemonStats(int REZ, int INT, int netActions, int combatNumber)
        {
            Type = AppData.Demon;
            PlayerRole = AppData.Demon;
            Notes = netActions.ToString();
            BaseStats = new();
            BaseStats.Add(new(AppData.SkillInterface, INT));
            BaseStats.Add(new(AppData.SkillCombatNumber, combatNumber));
            MaximumHitPoints = REZ;
            CurrentHitPoints = REZ;
        }
        public void SetActiveDefenseStats(int MOVE, int HP, int DV)
        {
            Type = AppData.ActiveDefense;
            Notes = MOVE.ToString();
            PlayerRole = DV.ToString();
            MaximumHitPoints = HP;
            CurrentHitPoints = HP;
        }
        public void SetEmplacedDefenseStats(int combatNumber, int HP, int DV, string note = "")
        {
            Type = AppData.EmplacedDefense;
            PlayerRole = DV.ToString();
            Notes = note;
            BaseStats = new();
            BaseStats.Add(new(AppData.SkillCombatNumber, combatNumber));
            MaximumHitPoints = HP;
            CurrentHitPoints = HP;
        }
        public void SetCalculatedStats()
        {
            CalculatedStats = new();
            List<string> statsAffectedByArmorPenalty = new() { AppData.StatReflexes, AppData.StatDexterity, AppData.StatMovement };
            foreach (Stat stat in BaseStats)
            {
                Stat statToAdd = stat.DeepClone();
                if (statsAffectedByArmorPenalty.Contains(stat.Name)) { statToAdd.Value -= AppData.ArmorTable.GetPenalty(ArmorType); }
                CalculatedStats.Add(statToAdd);
            }
        }

        public void SetBaseSkills()
        {
            Skills = new();
            foreach (SkillLinkReference skill in AppData.SkillLinks)
            {
                if (skill.SkillName == AppData.SkillLanguage) { continue; }
                if (skill.SkillName == AppData.SkillLocalExpert) { continue; }
                if (skill.SkillName == AppData.SkillScience) { continue; }
                if (skill.SkillName == AppData.SkillPlayInstrument) { continue; }
                Skills.Add(new(skill.SkillName));
            }
        }
        public void SetClassSkills()
        {
            if (string.IsNullOrEmpty(ComClass)) { HelperMethods.WriteToLogFile($"No ComClass set for {Name}"); return; }
            if (ComClass == AppData.ComClassCivilian)
            {
                // Should civies have extra skills?
            }
            if (ComClass.IsIn(AppData.ComClassLightPolice, AppData.ComClassMediumPolice, AppData.ComClassHeavyPolice))
            {
                SetSkillLevels(2, AppData.SkillConcealRevealObject, AppData.SkillTracking, AppData.SkillStealth, AppData.SkillCriminology, AppData.SkillBasicTech, AppData.SkillWeaponstech, AppData.SkillLandVehicleTech);
                SetSkillLevels(3, AppData.SkillAthletics, AppData.SkillResistTortureDrugs, AppData.SkillTactics, AppData.SkillInterrogation, AppData.SkillFirstAid);
                SetSkillLevels(4, AppData.SkillPerception, AppData.SkillEndurance, AppData.SkillDriveLandVehicle);
                SetSkillLevels(5, AppData.SkillBrawling, AppData.SkillEvasion);
                SetSkillLevels(6, AppData.SkillHandgun, AppData.SkillShoulderArms);
            }
            if (ComClass.IsIn(AppData.ComClassLightCorpo, AppData.ComClassMediumCorpo, AppData.ComClassHeavyCorpo))
            {
                // TODO - Corpo Skills and Ganger Skills
            }
        }
        public void AddWeapons(params string[] types)
        {
            foreach (string type in types)
            {
                AddWeapon(type);
            }
        }
        public void AddWeapon(string type, string quality = "", string name = "")
        {
            if (string.IsNullOrEmpty(quality)) { quality = AppData.WeaponQualityStandard; }
            Weapons.Add(new(type, quality, name));
        }
        public void AddBasicAmmoForAllWeapons(int numberOfClips)
        {
            foreach (CombatantWeapon weapon in Weapons)
            {
                if (!weapon.UsesAmmo) { continue; }
                Weapon weaponData = AppData.WeaponRepository.FirstOrDefault(w => w.Type == weapon.Type)!;
                RangedWeaponClip clipData = AppData.ClipChart.FirstOrDefault(c => c.WeaponType == weapon.Type)!;
                AddAmmo(weaponData.AmmoType, clipData.Standard * numberOfClips);
            }
        }
        public void AddAmmo(string type, int quantity, string variant = "")
        {
            if (string.IsNullOrEmpty(variant)) { variant = AppData.AmmoVarBasic; }
            AmmoInventory.Add(new(type, quantity, variant));
        }
        public void AddGearSet(params string[] names)
        {
            AddGearSet(names.ToList());
        }
        public void AddGearSet(List<string> names)
        {
            foreach (string name in names)
            {
                AddGear(name);
            }
        }
        public void AddCyberdeckPrograms(params string[] names)
        {
            foreach (string name in names)
            {
                AddCyberdeckProgram(name);
            }
        }
        public void AddCyberwareSet(params string[] names)
        {
            foreach (string name in names)
            {
                AddCyberware(name);
            }
        }

        public void AddShield()
        {
            ShieldType = AppData.ShieldTypeBulletproofShield;
            ShieldHp = 10;
        }
        
        public void SetDisplayName(string letter = "")
        {
            if (!letter.IsNullOrEmpty()) { TrackerIndicator = letter; }
            DisplayName = $"{Name} {TrackerIndicator}";
        }
        
        public int GetSkillTotal(string skill)
        {
            if (Type == AppData.ActiveDefense) { return GetDemonCombatNumber(); }
            if (Type == AppData.EmplacedDefense) { return BaseStats.GetValue(AppData.SkillCombatNumber); }
            int skillLevel = Skills.FirstOrDefault(s => s.Name == skill).Level;
            int statLevel = CalculatedStats.GetValue(AppData.SkillLinks.First(s => s.SkillName == skill).StatName);
            return skillLevel + statLevel;
        }
        public void UpdateGearDescriptions()
        {
            foreach (Gear gear in GearInventory)
            {
                gear.Description = AppData.MasterGearList[gear.Name];
            }
        }
        public void UpdateCyberwareDescriptions()
        {
            foreach (Cyberware cyberware in InstalledCyberware)
            {
                cyberware.Description = AppData.MasterCyberwareList[cyberware.Name];
            }
        }
        public int GetInitiative()
        {
            if (Type == AppData.Player) { return Initiative; }
            int reflex = CalculatedStats.GetValue(AppData.StatReflexes);
            reflex -= AppData.ArmorTable.GetPenalty(ArmorType);
            return HelperMethods.RollD10() + reflex;
        }
        public void UpdateWoundState()
        {
            if (Type == AppData.BlackIce || Type == AppData.Demon) { UpdateBlackIceWoundState(); return; }
            if (Type == AppData.ActiveDefense || Type == AppData.EmplacedDefense) { UpdateDefenseWoundState(); return; }
            string woundState = AppData.WoundStateUnharmed;
            if (CurrentHitPoints < MaximumHitPoints) { woundState = AppData.WoundStateLightlyWounded; }
            if (CurrentHitPoints <= (MaximumHitPoints / 2)) { woundState = AppData.WoundStateSeriouslyWounded; }
            if (CurrentHitPoints < 1) { woundState = AppData.WoundStateMortallyWounded; }
            if (IsDead) { woundState = AppData.WoundStateDead; }
            WoundState = woundState;
            NotifyPropertyChanged(nameof(MoveSpeed));
        }
        public void UpdateBlackIceWoundState()
        {
            string woundState = AppData.ProgramStateRezzed;
            if (CurrentHitPoints == 0) { woundState = AppData.ProgramStateDerezzed; }
            WoundState = woundState;
        }
        public void UpdateDefenseWoundState()
        {
            string woundState = AppData.DefenseStateOperational;
            if (CurrentHitPoints == 0) { woundState = AppData.DefenseStateDestroyed; IsDead = true; }
            WoundState = woundState;
        }
        public void ReadyUpActiveDefense(int count)
        {
            SetDisplayName(HelperMethods.GetAlphabetLetter(count));
            Initiative = 60; // Top(er) of the order force
            UpdateWoundState();
            ReloadAllWeapons();
        }
        public int GetSkillPenalty(string skillName)
        {
            int penalty = GetAllActionInjuryAndWoundStatePenalty();
            if (skillName == AppData.SkillPerception && CriticalInjuries.Contains(AppData.CriticalInjuryLostEye)) { penalty += 4; }
            if (skillName == AppData.SkillPerception && CriticalInjuries.Contains(AppData.CriticalInjuryDamagedEye)) { penalty += 2; }
            if (skillName == AppData.SkillPersuasion && CriticalInjuries.Contains(AppData.CriticalInjuryBrokenJaw)) { penalty += 4; }
            if (skillName == AppData.SkillBribery && CriticalInjuries.Contains(AppData.CriticalInjuryBrokenJaw)) { penalty += 4; }
            if (skillName == AppData.SkillConversation && CriticalInjuries.Contains(AppData.CriticalInjuryBrokenJaw)) { penalty += 4; }
            if (skillName == AppData.SkillPerception && CriticalInjuries.Contains(AppData.CriticalInjuryLostEar)) { penalty += 4; }
            // TODO - add question for if perception involves sight, smell, or sound
            return penalty;
        }
        public int GetStatPenalty(string statName)
        {
            int penalty = GetAllActionInjuryAndWoundStatePenalty();
            if (statName == AppData.StatMovement && CriticalInjuries.Contains(AppData.CriticalInjuryCollapsedLung)) { penalty += 2; }
            if (statName == AppData.StatMovement && CriticalInjuries.Contains(AppData.CriticalInjuryBrokenLeg)) { penalty += 4; }
            if (statName == AppData.StatMovement && CriticalInjuries.Contains(AppData.CriticalInjuryDismemberedLeg)) { penalty += 6; }
            return penalty;
        }
        public int GetAttackInjuryPenalty(string weaponType)
        {
            int penalty = GetAllActionInjuryAndWoundStatePenalty();
            if (weaponType.Contains("Melee")) { penalty += GetMeleeWeaponInjuryPenalty(); }
            else { penalty += GetRangedWeaponInjuryPenalty(); }
            return penalty;
        }
        private int GetMeleeWeaponInjuryPenalty()
        {
            int penalty = 0;
            if (CriticalInjuries.Contains(AppData.CriticalInjuryTornMuscle)) { penalty += 2; }
            return penalty;
        }
        private int GetRangedWeaponInjuryPenalty()
        {
            int penalty = 0;
            if (CriticalInjuries.Contains(AppData.CriticalInjuryLostEye)) { penalty += 4; }
            if (CriticalInjuries.Contains(AppData.CriticalInjuryDamagedEye)) { penalty += 2; }
            return penalty;
        }
        private int GetAllActionInjuryAndWoundStatePenalty()
        {
            int penalty = 0; 
            if (CriticalInjuries.Contains(AppData.CriticalInjuryBrainInjury)) { penalty += 2; }
            if (CriticalInjuries.Contains(AppData.CriticalInjuryConcussion)) { penalty += 2; }
            if (WoundState == AppData.WoundStateSeriouslyWounded) { penalty += 2; }
            if (WoundState == AppData.WoundStateMortallyWounded) { penalty += 4; }
            return penalty;
        }
        public void SetNetActions()
        {
            NetActions.Clear();
            NetActions.Add(new(AppData.NetActionInterface));
            NetActions.Add(new(AppData.NetActionJackIn));
            NetActions.Add(new(AppData.NetActionJackOut));
            NetActions.Add(new(AppData.NetActionActivateProgram));
            NetActions.Add(new(AppData.NetActionScanner));
            NetActions.Add(new(AppData.NetActionBackdoor));
            NetActions.Add(new(AppData.NetActionCloak));
            NetActions.Add(new(AppData.NetActionControl));
            NetActions.Add(new(AppData.NetActionEyeDee));
            NetActions.Add(new(AppData.NetActionSlide));
            NetActions.Add(new(AppData.NetActionVirus));
            NetActions.Add(new(AppData.NetActionZap));
        }
        public void ResetWeaponsAndAmmo()
        {
            Weapons.Clear();
            AmmoInventory.Clear();
        }

        // Private Methods
        private void InitializeLists()
        {
            BaseStats = new();
            CalculatedStats = new();
            Skills = new();
            Weapons = new();
            AwarenessSkills = new();
            BodySkills = new();
            ControlSkills = new();
            PerformanceSkills = new();
            EducationSkills = new();
            FightingSkills = new();
            RangedWeaponSkills = new();
            SocialSkills = new();
            TechniqueSkills = new();
            AmmoInventory = new();
            GearInventory = new();
            InstalledCyberware = new();
            StandardActions = new();
            NetActions = new();
            CriticalInjuries = new();
            CyberdeckPrograms = new();
            ActivePrograms = new();
        }
        private void AddGear(string name)
        {
            if (GearInventory.FirstOrDefault(g => g.Name == name) != null)
            {
                GearInventory.First(g => g.Name == name).Quantity++;
                return;
            }
            GearInventory.Add(new(name));
        }
        private void AddCyberdeckProgram(string name)
        {
            CyberdeckProgram matchedProgram = AppData.CyberdeckPrograms.FirstOrDefault(p => p.Name == name)!;
            if (matchedProgram == null) { return; }
            CyberdeckPrograms.Add(matchedProgram.DeepClone());
        }
        private void AddCyberware(string name)
        {
            InstalledCyberware.Add(new(name));
        }
        private void SetStoppingPower(bool setCurrentToMax)
        {
            MaximumHeadStoppingPower = AppData.ArmorTable.GetStoppingPower(ArmorType);
            MaximumBodyStoppingPower = AppData.ArmorTable.GetStoppingPower(ArmorType);
            if (setCurrentToMax)
            {
                CurrentHeadStoppingPower = MaximumHeadStoppingPower;
                CurrentBodyStoppingPower = MaximumBodyStoppingPower;
            }
        }
        public void ReloadAllWeapons()
        {
            foreach (CombatantWeapon weapon in Weapons)
            {
                weapon.DoReloadWeapon(this);
            }
        }
        private void SetHitPoints(bool setCurrentToMax)
        {
            int body = CalculatedStats.GetValue(AppData.StatBody);
            int willpower = CalculatedStats.GetValue(AppData.StatWillpower);
            MaximumHitPoints = 10 + (5 * ((body + willpower) / 2));
            if (setCurrentToMax)
            {
                CurrentHitPoints = MaximumHitPoints;
            }
        }
        private void OrganizeSkillsToCategories()
        {
            foreach (Skill skill in Skills)
            {
                if (AppData.SkillsToSkipForCombatants.Contains(skill.Name)) { continue; }
                if (skill.Name == AppData.SkillSurgery) { TechniqueSkills.Add(skill); continue; }
                if (skill.Name == AppData.SkillMedicalTech) { TechniqueSkills.Add(skill); continue; }
                switch (AppData.SkillLinks.GetCategory(skill.Name))
                {
                    case AppData.SkillCategoryAwareness:
                        AwarenessSkills.Add(skill);
                        break;
                    case AppData.SkillCategoryBody:
                        BodySkills.Add(skill);
                        break;
                    case AppData.SkillCategoryControl:
                        ControlSkills.Add(skill);
                        break;
                    case AppData.SkillCategoryPerformance:
                        PerformanceSkills.Add(skill);
                        break;
                    case AppData.SkillCategoryEducation:
                        EducationSkills.Add(skill);
                        break;
                    case AppData.SkillCategoryFighting:
                        FightingSkills.Add(skill);
                        break;
                    case AppData.SkillCategoryRangedWeapon:
                        RangedWeaponSkills.Add(skill);
                        break;
                    case AppData.SkillCategorySocial:
                        SocialSkills.Add(skill);
                        break;
                    case AppData.SkillCategoryTechnique:
                        TechniqueSkills.Add(skill);
                        break;
                    default: break;
                }
            }
        }
        private void GetCriticalInjuryDescriptions()
        {
            foreach (CriticalInjury injury in CriticalInjuries)
            {
                CriticalInjury bodyInjury = AppData.CriticalInjuriesToBody.FirstOrDefault(i => i.Name == injury.Name)!;
                CriticalInjury headInjury = AppData.CriticalInjuriesToHead.FirstOrDefault(i => i.Name == injury.Name)!;
                if (bodyInjury != null) { injury.Description = bodyInjury.Description; }
                if (headInjury != null) { injury.Description = headInjury.Description; }
            }
        }
        private void SetStandardActions()
        {
            StandardActions.Clear();
            StandardActions.Add(new(AppData.ActionBrawl));
            StandardActions.Add(new(AppData.ActionChoke));
            StandardActions.Add(new(AppData.ActionDeathSave));
            StandardActions.Add(new(AppData.ActionEvade));
            StandardActions.Add(new(AppData.ActionGrab));
            StandardActions.Add(new(AppData.ActionInitiative));
            StandardActions.Add(new(AppData.ActionThrowGrapple));
            StandardActions.Add(new(AppData.ActionThrowObject));
        }
        private int GetDemonCombatNumber()
        {
            Combatant demon = AppData.MainModelRef.CampaignView.ActiveCampaign.AllCombatants.FirstOrDefault(c => c.Type == AppData.Demon);
            if (demon == null) { RaiseError(AppData.ErrorNoDemonAvailableForActiveDefense); return 0; }
            else
            {
                return demon.BaseStats.GetValue(AppData.SkillCombatNumber);
            }
        }

    }
}
