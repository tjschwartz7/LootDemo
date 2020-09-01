using System;
using System.Collections.Generic;
using System.Text;

namespace LootDemo
{

    class LegendaryDrops
    {
        public static GunPulled PullLegendaryGuns(player newPlayer)
        {
            GunPulled Gun = new GunPulled();

            Random rand = new Random();
            int legendaryPull = rand.Next(69);

            if (legendaryPull == 0)
            {
               
                GunPulled Clanker = new GunPulled("MarsWares", "Minigun", "Clanker", 6, 52, 65, 3, 5 );
                Gun = Clanker;
            }
            else if(legendaryPull == 1)
            {
                GunPulled DeathRay = new GunPulled("Ultra", "Laser Ray Series", "Death Ray", 3, 50, 87, 50, 3);
                Gun = DeathRay;
            }
            else if (legendaryPull == 2)
            {
                GunPulled ForceBlaster = new GunPulled("Ultra", "Laser Ray Series", "Force Blaster", 27, 3, 90, 30, 3);
                Gun = ForceBlaster;
            }
            else if (legendaryPull == 3)
            {
                GunPulled ColtOcto = new GunPulled("Inum", "Pistol", "Colt Octo", 8, 8, 88, 88, 8);
                Gun = ColtOcto;
            }
            else if (legendaryPull == 4)
            {
                GunPulled Missfire = new GunPulled("JelTech", "Assault Rifle", "Missfire", 15, 17, 45, 45, 4);
                Gun = Missfire;
            }
            else if (legendaryPull == 5)
            {
                GunPulled PlasmaImploder = new GunPulled("Ultra", "Plasma Series", "Plasma Imploder", 30, 3, 83, 10, 10);
                Gun = PlasmaImploder;
            }
            else if (legendaryPull == 6)
            {
                GunPulled MasterBlaster = new GunPulled("TopNotch", "RPG", "Master Blaster", 40, 1, 85, 10, 5);
                Gun = MasterBlaster;
            }
            else if (legendaryPull == 7)
            {
                GunPulled ColtOcto = new GunPulled("TopNotch", "Doom Series Shotgun", "Hell Shotgun", 27, 4, 84, 5, 5);
                Gun = ColtOcto;
            }
            else if (legendaryPull == 8)
            {
                GunPulled PlasmaCannon = new GunPulled("TopNotch", "Doom Series Cannon", "Plasma Cannon", 45, 1, 81, 10, 2);
                Gun = PlasmaCannon;
            }
            else if (legendaryPull == 9)
            {
                GunPulled BigGun = new GunPulled("BoomCo", "RPG", "Big Gun", 70, .1, 45, 11, 2);
                Gun = BigGun;
            }
            else if (legendaryPull == 10)
            {
                GunPulled RocketGun = new GunPulled("BoomCo", "Pistol", "Rocket Gun", 20, 6, 77, 7, 4);
                Gun = RocketGun;
            }
            else if (legendaryPull == 11)
            {
                GunPulled MRE = new GunPulled("BoomCo", "RPG", "Missile Rocket Explosioneer", 105, .0001, 95, 20, 2);
                Gun = MRE;
            }
            else if (legendaryPull == 12)
            {
                GunPulled DeathActivist = new GunPulled("JelTech", "Assault Rifle", "Death Activist", 9, 12, 88, 17, 4);
                Gun = DeathActivist;
            }
            else if (legendaryPull == 13)
            {
                GunPulled CrossFire = new GunPulled("Inum", "SMG", "CrossFire!", 4, 77, 50, 10, 12);
                Gun = CrossFire;
            }
            else if (legendaryPull == 14)
            {
                GunPulled Pepsifier = new GunPulled("PepsiCo", "Pistol", "Pepsifier", 1, 1000, 99, 2, 1000);
                Gun = Pepsifier;
            }
            else if (legendaryPull == 15)
            {
                GunPulled DigiHom = new GunPulled("STUDIO Homicide", "Pistol", "Digital Suicide", 3, 5, 83, 50, 666);
                Gun = DigiHom;
            }
            else if (legendaryPull == 16)
            {
                GunPulled DigiHom = new GunPulled("JelTech", "Assault Rifle", "Polybius", 21, 7, 80, 3, 10);
                Gun = DigiHom;
            }
            else if (legendaryPull == 17)
            {
                GunPulled DigiHom = new GunPulled("MarsWares", "Pistol", "Treasure Master", 6, 14, 78, 25, 25);
                Gun = DigiHom;
            }
            else if (legendaryPull == 18)
            {
                GunPulled SHS = new GunPulled("TopNotch", "SMG", "Super Hyper Scanner", 5, 65, 83, 15, 12);
                Gun = SHS;
            }
            else if (legendaryPull == 19)
            {
                GunPulled ALF = new GunPulled("Ultra", "SMG", "Alpha Loop Fighter", 10, 25, 87, 3, 6);
                Gun = ALF;
            }
            else if (legendaryPull == 20)
            {
                GunPulled BigRig = new GunPulled("JelTech", "Melee", "Biggest Rig", 46, 1, 83, 3, 66);
                Gun = BigRig;
            }
            else if (legendaryPull == 21)
            {
                GunPulled BubbleWand = new GunPulled("MarsWares", "Melee", "Bubble Wand", 3, 1, 25, 75, 1000);
                Gun = BubbleWand;
            }
            else if (legendaryPull == 22)
            {
                GunPulled DigiHom = new GunPulled("MarsWares", "Pistol", "Plankton's Chum Ray", 21, 12, 83, 15, 7);
                Gun = DigiHom;
            }
            else if (legendaryPull == 23)
            {
                GunPulled SSOL = new GunPulled("Ultra", "Melee", "Supreme Lance Of Light", 40, 1, 87, 20, 2);
                Gun = SSOL;
            }
            else if (legendaryPull == 24)
            {
                GunPulled WOG = new GunPulled("CDI Incorporated", "Melee", "Wand of Gamelon", 14, 1, 50, 50, 9);
                Gun = WOG;
            }
            else if (legendaryPull == 25)
            {
                GunPulled BOK = new GunPulled("CDI Incorporated", "Melee", "Book of Koridai", 1, 1, 1, 100, 9999);
                Gun = BOK;
            }
            else if (legendaryPull == 26)
            {
                GunPulled MasterChu = new GunPulled("Inum", "Assault Rifle", "Master Chu", 25, 5, 80, 5, 2);
                Gun = MasterChu;
            }
            else if (legendaryPull == 27)
            {
                GunPulled Bimmy = new GunPulled("MarsWares", "Pistol", "Bimmy Device", 9, 22, 67, 10, 3);
                Gun = Bimmy;
            }
            else if (legendaryPull == 28)
            {
                GunPulled Jimmy = new GunPulled("MarsWares", "Pistol", "Jimmy Device", 10, 21, 70, 5, 6);
                Gun = Jimmy;
            }
            else if (legendaryPull == 29)
            {
                GunPulled Freedom = new GunPulled("JelTech", "Shotgun", "Freedom", 13, 50, 50, 50, 2);
                Gun = Freedom;
            }
            else if (legendaryPull == 30)
            {
                GunPulled GalaxyRevolver = new GunPulled("TopNotch", "Galaxy Series - Pistol", "Galaxy Revolver", 23, 6, 98, 25, 3);
                Gun = GalaxyRevolver;
            }
            else if (legendaryPull == 31)
            {
                GunPulled GalaxyBoomStick = new GunPulled("TopNotch", "Galaxy Series - Shotgun", "Galaxy BoomStick", 36, 2, 97, 35, 2);
                Gun = GalaxyBoomStick;
            }
            else if (legendaryPull == 32)
            {
                GunPulled GalaxyAR = new GunPulled("TopNotch", "Galaxy Series - Assault Rifle", "Galaxy AR", 10, 13, 97, 20, 3);
                Gun = GalaxyAR;
            }
            else if (legendaryPull == 33)
            {
                GunPulled GalaxyLauncher = new GunPulled("TopNotch", "Galaxy Series - RPG", "Galaxy Launcher", 42, 1, 95, 45, 6);
                Gun = GalaxyLauncher;
            }
            else if (legendaryPull == 34)
            {
                GunPulled GalaxySMG = new GunPulled("TopNotch", "Galaxy Series - SMG", "Galaxy SMG", 8, 24, 98, 15, 4);
                Gun = GalaxySMG;
            }
            else if (legendaryPull == 35)
            {
                GunPulled ManRay = new GunPulled("Ultra", "Laser Ray Series", "Man Ray", 2, 999, 45, 50, 2);
                Gun = ManRay;
            }
            else if (legendaryPull == 36)
            {
                GunPulled UDDER = new GunPulled("ULTIMATE", "ULTIMATE Single - Shotgun", "Ultimate Death Device Enticer Revamped - UDDER", 1, 10, 2, 100, 99999);
                Gun = UDDER;
            }
            else if (legendaryPull == 37)
            {
                GunPulled DMO = new GunPulled("ULTIMATE", "ULTIMATE Single - RPG", "Death Machina Omega - Alpha Version", 999, 1, 50, 95, 0);
                Gun = DMO;
            }
            else if (legendaryPull == 38)
            {
                GunPulled Bloxor = new GunPulled("Inum", "Assault Rifle", "Bloxor", 21, 6, 87, 10, 2);
                Gun = Bloxor;
            }
            else if (legendaryPull == 39)
            {
                GunPulled ChainsawRifle = new GunPulled("MarsWares", "Chainsaw Rifle", "Lancer", 12, 22, 86, 1, 2);
                Gun = ChainsawRifle;
            }
            else if (legendaryPull == 40)
            {
                GunPulled KinglyHook = new GunPulled("Ultra", "Melee", "Kingly Hook", 65, .0001, 90, 1, 20);
                Gun = KinglyHook;
            }
            else if (legendaryPull == 41)
            {
                GunPulled GlitchGun = new GunPulled("Binary Systems", "P1st01", "Gl1tch Gun", 10, 10, 32, 32, 101);
                Gun = GlitchGun;
            }
            else if (legendaryPull == 42)
            {
                GunPulled GlitchGun2 = new GunPulled("Binary Systems", "Assault R1fle", "Gl1tch Gun Version 000010", 25, 2, 86, 32, 4);
                Gun = GlitchGun2;
            }
            else if (legendaryPull == 43)
            {
                GunPulled GlitchGun3 = new GunPulled("Binary Systems", "Sh0tgun", "Gl1tch Gun Vers1on 000011", 32, 1, 86, 32, 4);
                Gun = GlitchGun3;
            }
            else if (legendaryPull == 44)
            {
                GunPulled GlitchBoom = new GunPulled("Binary Systems", "RPG", "Gl1tch B00m", 50, 2, 101, 15, 5);
                Gun = GlitchBoom;
            }
            else if (legendaryPull == 45)
            {
                GunPulled MeatWagon = new GunPulled("Unknown Brand", "Minigun", "Meat Wagon", 11, 202, 44, 2, 4);
                Gun = MeatWagon;
            }
            else if (legendaryPull == 46)
            {
                GunPulled TheApple = new GunPulled("JelTech", "Launcher", "The Apple", 37, 2, 70, 5, 5);
                Gun = TheApple;
            }
            else if (legendaryPull == 47)
            {
                GunPulled PeaShooter = new GunPulled("JelTech", "Pistol", "The Pea Shooter", 12, 17, 100, 3, 3);
                Gun = PeaShooter;
            }
            else if (legendaryPull == 48)
            {
                GunPulled MasterCrossbow = new GunPulled("Inum", "Crossbow", "Master Crossbow", 24, 1, 75, 40, 3);
                Gun = MasterCrossbow;
            }
            else if (legendaryPull == 49)
            {
                GunPulled CriticalCrossbow = new GunPulled("Inum", "Crossbow", "Critical Crossbow", 13, 3, 75, 95, 5);
                Gun = CriticalCrossbow;
            }
            else if (legendaryPull == 50)
            {
                GunPulled RapidCrossbow = new GunPulled("Inum", "Crossbow", "Rapid Crossbow", 5, 65, 50, 25, 2);
                Gun = RapidCrossbow;
            }
            else if (legendaryPull == 51)
            {
                GunPulled CriticalConferenceCall = new GunPulled("TopNotch", "Shotgun", "Critical Conference Call", 24, 8, 84, 20, 4);
                Gun = CriticalConferenceCall;
            }
            else if (legendaryPull == 52)
            {
                GunPulled GaussRifle = new GunPulled("Ultra", "Rifle", "Gauss Rifle", 40, 2, 90, 80, 2);
                Gun = GaussRifle;
            }
            else if (legendaryPull == 53)
            {
                GunPulled Maria = new GunPulled("MarsWares", "Pistol", "Maria", 16, 13, 82, 8, 3);
                Gun = Maria;
            }
            else if (legendaryPull == 54)
            {
                GunPulled Supernova = new GunPulled("BoomCo", "RPG", "Supernova", 65, 1, 95, 50, 2);
                Gun = Supernova;
            }
            else if (legendaryPull == 55)
            {
                GunPulled Hypernova = new GunPulled("BoomCo", "RPG", "Hypernova", 95, .01, 90, 10, 3);
                Gun = Hypernova;
            }
            else if (legendaryPull == 56)
            {
                GunPulled Nova = new GunPulled("BoomCo", "RPG", "Nova", 48, 3, 97, 25, 2);
                Gun = Nova;
            }
            else if (legendaryPull == 57)
            {
                GunPulled KitchenGun = new GunPulled("Baum LTD", "Pistol", "Kitchen Gun!", 10, 3, 95, 52, 15);   
                Gun = KitchenGun;
            }
            else if (legendaryPull == 58)
            {
                GunPulled GalacticConsequences = new GunPulled("Unknown Brand", "RPG", "Galactic Consequences", 30, 10, 75, 60, 2);
                Gun = GalacticConsequences;
            }
            else if (legendaryPull == 59)
            {
                GunPulled DeadlySins = new GunPulled("Ultra", "Pistol", "7 Sins", 7, 7, 100, 95, 7);
                Gun = DeadlySins;
            }
            else if (legendaryPull == 60)
            {
                GunPulled Plague = new GunPulled("JelTech", "Shotgun", "Plague", 4, 300, 80, 1, 2);
                Gun = Plague;
            }
            else if (legendaryPull == 61)
            {
                GunPulled DPFD = new GunPulled("Ultra", "Laser Ray Series", "Directed Particle Fusion Device", 200, .000000001, 5, 100, 500);
                Gun = DPFD;
            }
            else if (legendaryPull == 62)
            {
                GunPulled Stardust = new GunPulled("JelTech", "Assault Rifle", "Stardust", 15, 8, 85, 10, 2);
                Gun = Stardust;
            }
            else if (legendaryPull == 63)
            {
                GunPulled Darkspawn = new GunPulled("Inum", "SMG", "Darkspawn", 12, 20, 80, 5, 5);
                Gun = Darkspawn;
            }
            else if (legendaryPull == 64)
            {
                GunPulled Nebulae = new GunPulled("TopNotch", "SMG", "Nebulae", 10, 15, 75, 30, 5);
                Gun = Nebulae;
            }
            else if (legendaryPull == 65)
            {
                GunPulled BlackHole = new GunPulled("TopNotch", "Shotgun", "Black Hole", 80, 3, 50, 15, 0);
                Gun = BlackHole;
            }
            else if (legendaryPull == 66)
            {
                GunPulled SpaceTime = new GunPulled("Inum", "SMG", "Space-Time", 5, 100, 80, 90, 5);
                Gun = SpaceTime;
            }
            else if (legendaryPull == 67)
            {
                GunPulled Revolution = new GunPulled("MarsWares", "Assault Rifle", "Revolution", 11, 23, 60, 4, 2);
                Gun = Revolution;
            }
            else if (legendaryPull == 68)
            {
                GunPulled SmartShopper = new GunPulled("S-Mart", "Boomstick", "The Smart Shopper", 53 , 2, 80, 4, 5);
                Gun = SmartShopper;
            }
            else if (legendaryPull == 69)
            {
                GunPulled NuclearOption = new GunPulled("BoomCo", "MiniNuker", "The Nuclear Option", 90, .0001, 99, 100, 2);
                Gun = NuclearOption;
            }
            else if (legendaryPull == 70)
            {
                GunPulled DynaSpatula = new GunPulled("JelTech", "Melee", "Hydro-Dynamic Spatula with Port and Starboard Attachments and TurboDrive", 9, 27, 91, 3, 2);
                Gun = DynaSpatula;
            }


            Gun.weaponDam *= (Gun.weaponDam * newPlayer.level);
            

            return Gun;
        }


        public static armor PullLegendaryArmor(player newPlayer)
        {
            armor Armor = new armor();
            Random rand = new Random();
            int armorRNG = rand.Next(20);
            if (armorRNG == 0)
            {
                //Chance to reflect bullets, nothing
                armor PowerArmor = new armor("T51-B Power Armor", "Reflect", 6, 1, 130);
                Armor = PowerArmor;
            }
            else if (armorRNG == 1)
            {
                //Critical percent, critical multiplier
                armor ShadowShroud = new armor("Shadow Shroud", "Critical Boost", 5, 1, 25);
                Armor = ShadowShroud;
            }
            else if (armorRNG == 2)
            {
                //RPG Damage, RPG Accuracy
                armor Astro = new armor("The Astro", "RPG Specialist", 10, 5, 45);
                Armor = Astro;
            }
            else if (armorRNG == 3)
            {
                //Pistol damage, pistol accuracy
                armor Cowboy = new armor("The Cowboy", "Pistol Specialist", 4, 10, 35);
                Armor = Cowboy;
            }
            else if (armorRNG == 4)
            {
                //Shotgun damage, shotgun accuracy
                armor Enforcer = new armor("The Enforcer", "Shotgun Specialist", 6, 4, 30);
                Armor = Enforcer;
            }
            else if (armorRNG == 5)
            {
                //Assault Rifle damage, accuracy
                armor Mercenary = new armor("The Mercenary", "Assault Rifle Specialist", 3, 3, 40);
                Armor = Mercenary;
            }
            else if (armorRNG == 6)
            {
                //SMG damage, SMG Accuracy
                armor Mobster = new armor("The Mobster", "SMG Specialist", 2, 4, 45);
                Armor = Mobster;
            }
            else if (armorRNG == 7)
            {
                //Melee Damage, melee accuracy
                armor Gladiator = new armor("The Gladiator", "Melee Specialist", 8, 3, 55);
                Armor = Gladiator;
            }
            else if (armorRNG == 8)
            {
                armor MartianSpaceSuit = new armor("Martian Space Suit", "Laser Specialist", 8, 25, 45);
                Armor = MartianSpaceSuit;
            }
            else if (armorRNG == 9)
            {
                armor MirrorGear = new armor("Mirror Gear", "Reflect", 12, 1, 120);
                Armor = MirrorGear;
            }
            else if (armorRNG == 10)
            {
                armor MasterSet = new armor("Master Set", "Universal Specialist", 2, 2, 35);
                Armor = MasterSet;
            }
            else if (armorRNG == 11)
            {
                armor NovaArmor = new armor("Nova Armor", "Stun", 15, 1, 95);
                Armor = NovaArmor;
            }
            else if (armorRNG == 12)
            {
                armor HellArmor = new armor("Hell Armor", "Damage Boost", 3, 1, 125);
                Armor = HellArmor;
            }
            else if (armorRNG == 13)
            {
                armor SniperOutfit = new armor("Sniper's Outfit", "Accuracy Boost", 15, 1, 110);
                Armor = SniperOutfit;
            }
            else if (armorRNG == 14)
            {
                armor TitanArmor = new armor("Titan Armor", "", 1, 1, 185);
                Armor = TitanArmor;
            }



            return Armor;
        }
    }
}
