using System;
using System.Globalization;
using System.Windows;

namespace CyberpunkGameplayAssistant.Toolbox
{
    public class ImageBasedOnMessageType : ConverterMarkupExtension<ImageBasedOnMessageType>
    {
        public ImageBasedOnMessageType()
        {

        }

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string iconName = value switch
            {
                AppData.MessageInitiative => "Icon_Runner",
                AppData.MessageCoinFllip => "Icon_SilverCoin",
                AppData.MessageGmRoll => "Icon_Dice",
                AppData.MessageLoot => "Icon_Pack",
                AppData.MessageReload => "Icon_Reload",
                AppData.MessageSkillCheck => "Icon_Hand",
                AppData.MessageStandardAction => "Icon_Action",
                AppData.MessageStatCheck => "Icon_Hex_A",
                AppData.MessageWeaponAttack => "Icon_Reticle",
                _ => "Icon_Rpg_Note"
            };
            return AppData.Framework.FindResource(iconName) as Style;
        }
    }
    public class ImageBasedOnStat : ConverterMarkupExtension<ImageBasedOnStat>
    {
        public ImageBasedOnStat()
        {

        }

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string iconName = value switch
            {
                "Ability Check" => "Icon_Hex_A",
                "Attack" => "Icon_Crossed_Swords",
                "Coin Flip" => "Icon_CopperCoin",
                "DM Roll" => "Icon_Dice",
                "Fall Damage" => "Icon_Fall",
                "Initiative" => "Icon_Initiative",
                "Loot" => "Icon_Pack",
                "Rest" => "Icon_Sleep",
                "Saving Throw" => "Icon_Letter_S",
                "Skill Check" => "Icon_Hand",
                "Spell" => "Icon_Rpg_Staff",
                "Weather Change" => "Icon_Weather_PartlyCloudy",
                _ => "Icon_Rpg_Note"
            };
            return AppData.Framework.FindResource(iconName) as Style;
        }
    }
    public class ImageBasedOnSkill : ConverterMarkupExtension<ImageBasedOnSkill>
    {
        public ImageBasedOnSkill()
        {

        }

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string iconName = value switch
            {
                "Ability Check" => "Icon_Hex_A",
                "Attack" => "Icon_Crossed_Swords",
                "Coin Flip" => "Icon_CopperCoin",
                "DM Roll" => "Icon_Dice",
                "Fall Damage" => "Icon_Fall",
                "Initiative" => "Icon_Initiative",
                "Loot" => "Icon_Pack",
                "Rest" => "Icon_Sleep",
                "Saving Throw" => "Icon_Letter_S",
                "Skill Check" => "Icon_Hand",
                "Spell" => "Icon_Rpg_Staff",
                "Weather Change" => "Icon_Weather_PartlyCloudy",
                _ => "Icon_Rpg_Note"
            };
            return AppData.Framework.FindResource(iconName) as Style;
        }
    }
    public class ImageBasedOnAction : ConverterMarkupExtension<ImageBasedOnAction>
    {
        public ImageBasedOnAction()
        {

        }
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string iconName = value switch
            {
                // Standard Actions
                AppData.ActionBrawl => "Icon_Fist",
                AppData.ActionChoke => "Icon_Fist",
                AppData.ActionDeathSave => "Icon_Skull",
                AppData.ActionEvade => "Icon_Dodge",
                AppData.ActionGrab => "Icon_Fist",
                AppData.ActionInitiative => "Icon_Runner",
                AppData.ActionThrowGrapple => "Icon_Fist",
                AppData.ActionThrowObject => "Icon_Throw",

                // NET Actions
                AppData.NetActionInterface => "Icon_Network",
                AppData.NetActionJackIn => "Icon_Connected",
                AppData.NetActionJackOut => "Icon_Disconnected",
                AppData.NetActionActivateProgram => "Icon_Program",
                AppData.NetActionScanner => "Icon_Radar",
                AppData.NetActionBackdoor => "Icon_Network",
                AppData.NetActionCloak => "Icon_Network",
                AppData.NetActionControl => "Icon_Network",
                AppData.NetActionEyeDee => "Icon_Network",
                AppData.NetActionPathfinder => "Icon_Search",
                AppData.NetActionSlide => "Icon_Dodge",
                AppData.NetActionVirus => "Icon_Network",
                AppData.NetActionZap => "Icon_Zap",

                // Default
                _ => "Icon_Rpg_Note"
            };
            return AppData.Framework.FindResource(iconName) as Style;
        }
    }
    public class ImageBasedOnCombatantType : ConverterMarkupExtension<ImageBasedOnCombatantType>
    {
        public ImageBasedOnCombatantType()
        {

        }
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string iconName = value switch
            {
                AppData.ActiveDefense => "Icon_Turret",
                AppData.BlackIce => "Icon_Program",
                AppData.Demon => "Icon_Program",
                AppData.EmplacedDefense => "Icon_Turret",
                AppData.ComClassLightCorpo => "Icon_Briefcase",
                AppData.ComClassMediumCorpo => "Icon_Briefcase",
                AppData.ComClassHeavyCorpo => "Icon_Briefcase",
                AppData.ComClassLightPolice => "Icon_Badge",
                AppData.ComClassMediumPolice => "Icon_Badge",
                AppData.ComClassHeavyPolice => "Icon_Badge",
                _ => "Icon_Fist"
            };
            return AppData.Framework.FindResource(iconName) as Style;
        }
    }
}
