#include "types.h"
#include "constants.h"
#include "intrinsics.h"
#include "natives.h"
#include "common.h"

enum Subs
{
	Closed,
	Main_Menu,
	Cyber_Menu, 
	Self_Mods, Anim_Menu, 
	Models_Menu,
	Vehicle_Mods, Veh_Spawn, Veh_MostUsed, Veh_Super, Veh_Sport, Veh_ModShop, Wheels_Type, Veh_Paint,
	Most_used_veh, Super_Car, Sportive_Car, SportiveC_Car, Muscle_Car, Sedans_Car, Coupes_Car, Compact_Car, 
	SUVTrucks_Car, OFFRoad_Car, Vans_Car, Emergency_Car, Service_Car, Commercial_Car, Military_Car, Moto_Car, 
	Helicopters_Car, Bicycles, Planes_Car, Boats_Car, Snow_Car,
	Teleport_Mods, 
	Online_Players, OP_Mods, All_Players_Mods,
	Map_Mods,
	Misc_Mods,
	Main_Scripts,
	Other_Scripts,
	Recovery_Scripts,
	Protections_Scripts,
	Custom_Scripts
};

#pragma region def
float 
 CenterDraw = 0.26f,
 CenterDrawOP = 0.17f,
 Menu_X = 0.758,
 Title_X = 0.7570,
 Menu_OPX = 0.516,
 Title_OPX = 0.5160,
 CuntOP = 0.434,
 Cunt = 0.632,
 CuntPl = 0.656;
 
char Title[10];
int gGlareHandle = 0;
float gGlareDir;
float GlareX = 1.1449, GlareY = 0.4550, GlareXs = 1.1449, GlareYs = 0.8350;

bool g_bKeyBoardDisplayed2;
bool g_bKeyBoardDisplayed3;
bool notifok;

char *buttonCircle = "button_31";
char *buttonX = "button_30";
char *buttonUp = "button_4";
char *buttonL3 = "button_16";
char *buttonRight = "button_7";
char *buttonR1 = "button_36";
char *buttonL2 = "button_35";
char *buttonTriangle = "button_33";
char *buttonL1 = "button_34";
char *buttonSquare = "button_32";
char *buttonR2 = "button_37";
char *buttonDown = "button_5";
char *buttonLeft = "button_6";
char *buttonR3 = "button_25";

#pragma region lists
char* vehicleClass[] = { "Compact", "Sedans", "SUVs", "Coupes", "Muscle", "Sports-Classics", "Sports", "Super", "Motorcycles", "Off-Road", "Industrial", "Utility", "Vans", "Cycles", "Boats", "Helicopters", "Planes", "Service", "Emergency", "Military", "Commercial", "Trains" };
int WeaponsHash[] = { 0xaf113f99, 0x13579279, 0xf9fbaebe, 0x22d8fe39, 0xbfefff6d, 0xe284c527, 0xefe7e2df, 0x23c9f95c, 0xf9e6aa4b, 0x88c78eb7, 0x1b79f17, 0x7f229f94, 0x9d61e50f, 0xa0973d5e, 0x83bf0278, 0x7fd62962, 0xa3d4d34, 0x5ef9fec4, 0x8d4be52, 0x84bd7bfd, 0x92a27487, 0xfdbadced, 0x60ec506, 0x7f7497e5, 0x497facc3, 0x47757124, 0x440e4788, 0x93e220bd, 0xa284510b, 0x4dd2dc56, 0x61012683, 0x4e875f73, 0xd205520e, 0x3aabbbaa, 0xc472fe2, 0x63ab0442, 0x99b507ea, 0xc734385a, 0x13532244, 0x42bf8a85, 0x24b17070, 0xa89cb99e, 0x678b81b1, 0x34a67b97, 0x1b06d571, 0x99aeeb3b, 0xab564b93, 0x1d073a89, 0x7846a318, 0xfdbc8a50, 0x5fc3c11, 0x787f0bb, 0xbfd21232, 0xc0a3098d, 0x2c3731d9, 0x687652ce, 0x3656c8c1, 0x958a4a8f, 0x9d07f764, 0xb1ca77b1, 0x2be6766b, 0xa2719263, 0x83839c4 };
RGB NeonsCl[] = { { 0, 0, 0 }, { 255, 255, 255 }, { 255, 0, 0 }, { 255, 130, 0 }, { 0, 255, 0 }, { 0, 0, 255 }, { 0, 220, 255 }, { 255, 255, 0 }, { 137, 0, 210 }, { 255, 48, 230 } };
RGB TyreColors[] = { { 0xFE, 0xFE, 0xFE }, { 1, 1, 1 }, { 0, 0, 0xFF }, { 0xFF, 0, 0 }, { 0xFF, 0xFF, 0 }, { 0x96, 0, 0xFF }, { 0xFF, 0xAF, 0 }, { 0, 0xFF, 0 }, { 0xFF, 0, 0xFF } };
char* engineList[] = { "Stock", "Level 1", "Level 2", "Level 3", "Level 4" };
char* NeonList[] = { "Disabled", "White", "Red", "Orange", "Green", "Blue", "Light Blue", "Yellow", "Purple", "Pink" };
char* transmissionList[] = { "Stock", "Street", "Sport", "Race" };
char* armorList[] = { "Stock", "20 %", "40 %", "60 %", "80 %", "100 %" };
char* suspensionList[] = { "Stock", "Lowered", "Street", "Sport", "Competition" };
char* fbumperList[] = { "Stock", "Type 1", "Type 2", "Type 3", "Type 4" };
char* rbumperList[] = { "Stock", "Type 1", "Type 2", "Type 3", "Type 4" };
char* exhaustList[] = { "Stock", "Type 1", "Type 2", "Type 3", "Type 4", "Type 5", "Type 6" };
char* spoilerList[] = { "Stock", "Type 1", "Type 2", "Type 3", "Type 4", "Type 5", "Type 6", "Type 7" };
char* brakesList[] = { "Stock", "Street", "Sport", "Race" };
char* skirtList[] = { "Stock", "Type 1", "Type 2", "Type 3", "Type 4", "Type 5", "Type 6" };
char* hoodList[] = { "Stock", "Type 1", "Type 2", "Type 3", "Type 4", "Type 5" };
char* roofList[] = { "Stock", "Type 1", "Type 2", "Type 3", "Type 4", "Type 5" };
char* hornList[] = { "Stock", "Type 1", "Type 2", "Type 3", "Type 4", "Type 5", "Type 6", "Type 7", "Type 8", "Type 9", "Type 10", "Type 11", "Type 12", "Type 13", "Type 14", "Type 15", "Type 16", "Type 17", "Type 18", "Type 19", "Type 20", "Type 21", "Type 22", "Type 23", "Type 24", "Type 25", "Type 26", "Type 27", "Type 28", "Type 29", "Type 30", "Type 31", "Type 32", "Type 33", "Type 34", "Type 35", "Type 36", "Type 37" };
char* frameList[] = { "Stock", "Type 1", "Type 2", "Type 3", "Type 4" };
char* windowsList[] = { "Stock", "Light", "Dark", "Extra Dark", "Fume", "Green" };
char* headlightsList[] = { "Stock", "Xenon" };
char* tiresmokeList[] = { "Stock", "Black", "Blue", "Red", "Yellow", "Purple", "Orange", "Green", "Pink" };
char* rollcageList[] = { "Stock", "Type 1", "Type 2", "Type 3", "Type 4", "Type 5" };
char* grilleList[] = { "Stock", "Type 1", "Type 2", "Type 3", "Type 4", "Type 5" };
char* platetypeList[] = { "Stock", "Type 1", "Type 2", "Type 3", "Type 4", "Type 5", "Type 6" };
char* sportwList[] = { "Stock", "Inferno", "Lozspeed Mk.V", "Diamond Cut", "Chrono", "Feroci RR", "FiftyNine", "Mercie", "Synthetic Z", "Organic Type 0", "Endo v.1", "GT One", "Duper 7", "Uzer", "GroundRide", "S Racer", "Venum", "Dash VIP", "Ice Kid", "Ruff Weld", "Wangan Master", "Super Five", "Endo v.2", "Split Six" };
char* musclewList[] = { "Stock", "Classic Five", "Dukes", "Muscle Freak", "Kracka", "Azreal", "Mecha", "Black Top", "Drag SPL", "Revolver", "Classic Rod", "Fairlie", "Spooner", "Five Star", "Old School", "El Jefe", "Dodman", "Six Gun", "Mercenary" };
char* lowriderwList[] = { "Stock", "Flare", "Wired", "Triple Golds", "Big Worm", "Seven Fives", "Split Six", "Fresh Mesh", "Lead Sled", "Turbine", "Super Fin", "Classic Rod", "Dollar", "Dukes", "Low Five", "Gooch" };
char* suvwList[] = { "Stock", "VIP", "Benefactor", "Cosmo", "Fagorme", "Deluxe", "Iced Out", "Cognoscenti", "LozSpeed Ten", "Extravaganzo", "Split Six", "Empowered", "Sunrise", "Dash VIP", "Cutter" };
char* offroadwList[] = { "Stock", "Raider", "Mudslinger", "Nevis", "Cairngorm", "Amazon", "Challenger", "Dune Basher", "Five Star", "Rock Crawler", "Mil Spec Steelie" };
char* tunerwList[] = { "Stock", "Cosmo", "Super Mesh", "Outsider", "Rollas", "Driftmeister", "Slicer", "El Quatro", "Dubbed", "Five Star", "Slideways", "Apex", "Stanced EG", "Countersteer", "Endo v.1", "Endo v.2 Dish", "Gruppe Z", "Choku-Dori", "Chicane", "Saisoku", "Dished Eight", "Fujiwara", "Zokusha", "Battle VIII", "Rally Master" };
char* highendwList[] = { "Stock", "Shadow", "Hypher", "Blade", "Diamond ", "Supa Gee", "Chromatic Z", "Mercie Ch.Lip", "Obey RS", "GT Chrome", "Cheetah RR", "Solar", "Split Ten", "Dash VIP", "LozSpeed Ten", "Carbon Inferno", "Carbon Shadow", "Carbon Solar", "Cheetah Carbon R", "Carbon S Racer" };
char* ColorsList[] = { "Black",
"Graphite",
"Black Steel",
"Dark Steel",
"Silver",
"Bluish Silver",
"Rolled Steel",
"Shadow Silver",
"Stone Silver",
"Midnight Silver",
"Cast Iron Silver",
"Anthracite Black",
"Matte Black",
"Matte Gray",
"Light Gray",
"Util Black",
"Util Black Poly",
"Util Dark silver",
"Util Silver",
"Util Gun Metal",
"Util Shadow Silver",
"Worn Black",
"Worn Graphite",
"Worn Silver Grey",
"Worn Silver",
"Worn Blue Silver",
"Worn Shadow Silver",
"Red",
"Torino Red",
"Formula Red",
"Blaze Red",
"Grace Red",
"Garnet Red",
"Sunset Red",
"Cabernet Red",
"Candy Red",
"Sunrise Orange",
"Gold",
"Orange",
"Red",
"Dark Red",
"Matte Orange",
"Yellow",
"Util Red",
"Util Bright Red",
"Util Garnet Red",
"Worn Red",
"Worn Golden Red",
"Worn Dark Red",
"Dark Green",
"Metallic Racing Green",
"Sea Green",
"Olive Green",
"Bright Green",
"Metallic Gasoline Blue Green",
"Matte Lime Green",
"Dark Green",
"Worn Green",
"Worn SeWash",
"Metallic Midnight Blue",
"Metallic Dark Blue",
"Galaxy Blue",
"Dark Blue",
"Saxon Blue",
"Blue",
"Mariner Blue",
"Harbor Blue",
"Diamond Blue",
"Surf Blue",
"Nautical Blue",
"Ultra Blue",
"Schafter Purple",
"Metallic UltraBlue",
"Racing Blue",
"Light Blue",
"Util Midnight Blue",
"Util Blue",
"Util SeaFoam Blue",
"Util Lightning blue",
"Util Maui Blue Poly",
"Util Bright Blue",
"Slate Blue",
"Dark Blue",
"Blue",
"Matte Midnight Blue",
"Worn Dark blue",
"Worn Blue",
"Baby Blue",
"Yellow",
"Race Yellow",
"Bronze",
"Yellow Bird",
"Metallic Lime",
"Metallic Champagne",
"Feltzer Brown",
"Creek Brown",
"Chocolate Brown",
"Maple Brown",
"Saddle Brown",
"Straw Brown",
"Moss Brown",
"Bison Brown",
"WoodBeech Brown",
"BeechWood Brown",
"Straw Brown",
"Sandy Brown",
"Bleached Brown",
"Cream",
"Util Brown",
"Util Medium Brown",
"Util Light Brown",
"Ice White",
"Frost White",
"Worn Honey Beige",
"Worn Brown",
"Dark Brown",
"Worn straw beige",
"Brushed Steel",
"Brushed Black steel",
"Brushed Aluminium",
"Chrome",
"Worn Off White",
"Util Off White",
"Worn Orange",
"Worn Light Orange",
"PeGreen",
"Worn Taxi Yellow",
"Police Blue",
"Green",
"Matte Brown",
"Worn Orange",
"Ice White",
"Worn White",
"Worn Olive Army Green",
"Pure White",
"Hot Pink",
"Salmon Pink",
"Pfister Pink",
"Bright Orange",
"Green",
"Flourescent Blue",
"Midnight Blue",
"Midnight Purple",
"Wine Red",
"Hunter Green",
"Bright Purple",
"Midnight Purple",
"Carbon Black",
"Matte Purple",
"Matte Dark Purple",
"Metallic LavaRed",
"Olive Green",
"Matte Olive Drab",
"Dark Earth",
"Desert Tan",
"Matte Foilage Green",
"DEFAULT ALLOY COLOR",
"Epsilon Blue",
"Pure Gold",
"Brushed Gold",
"Secret Gold" };

Hash Knife = 0x99B507EA, Nightstick = 0x678B81B1, Hammer = 0x4E875F73, Bat = 0x958A4A8F, GolfClub = 0x440E4788,
Crowbar = 0x84BD7BFD, Pistol = 0x1B06D571, CombatPistol = 0x5EF9FEC4, APPistol = 0x22D8FE39, Pistol50 = 0x99AEEB3B,
MicroSMG = 0x13532244, SMG = 0x2BE6766B, AssaultSMG = 0xEFE7E2DF, CombatPDW = 0x0A3D4D34, AssaultRifle = 0xBFEFFF6D,
CarbineRifle = 0x83BF0278, AdvancedRifle = 0xAF113F99, MG = 0x9D07F764, CombatMG = 0x7FD62962, PumpShotgun = 0x1D073A89,
SawnOffShotgun = 0x7846A318, AssaultShotgun = 0xE284C527, BullpupShotgun = 0x9D61E50F, StunGun = 0x3656C8C1,
SniperRifle = 0x5FC3C11, HeavySniper = 0xC472FE2, GrenadeLauncher = 0xA284510B, GrenadeLauncherSmoke = 0x4DD2DC56,
RPG = 0xB1CA77B1, Minigun = 0x42BF8A85, Grenade = 0x93E220BD, StickyBomb = 0x2C3731D9, SmokeGrenade = 0xFDBC8A50,
BZGas = 0xA0973D5E, Molotov = 0x24B17070, FireExtinguisher = 0x60EC506, PetrolCan = 0x34A67B97, SNSPistol = 0xBFD21232,
SpecialCarbine = 0xC0A3098D, HeavyPistol = 0xD205520E, BullpupRifle = 0x7F229F94, HomingLauncher = 0x63AB0442,
ProximityMine = 0xAB564B93, Snowball = 0x787F0BB, VintagePistol = 0x83839C4, Dagger = 0x92A27487, Firework = 0x7F7497E5,
Musket = 0xA89CB99E, MarksmanRifle = 0xC734385A, HeavyShotgun = 0x3AABBBAA, Gusenberg = 0x61012683, Hatchet = 0xF9DCBF2D,
Railgun = 0x6D544C99, Unarmed = 0xA2719263;
#pragma endregion

//scripts & mods
bool Apii, KK, NYD, ConsoleTrainer, Revolution, HelperMenu, Arabic, Unrestrained, Illuminate, ProjCL, FunnyCar, App7e, 
muchRecovery, DaniiRecovery, JRRecovery, Maggot, Antraxx, UltimateTelep, Limox, GarageEditor, FrzProtex, modderprotex, Fuel,
SocksOnline, AntiCheater, CustomCam, HudEditor, MiniMenyoo, OnlineCheats, 
ParticleMenu, SlinkyMenu, SlinkyRecovery, SlinkyAnim, TheDonBro, Unknown, White, ZeroMenu, superman, scriptloader, 
scriptloader2, godmode, invisible, jump, ijump, supman, run, nocop, radio, unlimitedammo, bossmode, ohk, simplemoneydrop, godmodeveh, nfs, 
ghostveh, speedom, stickground, reducegrip, tiresmokeloop, doorsloop, doorsok, 
resprayloop, neonloop, vehjump, nosbind, stopbind, forcefield, TeleportWPLoop, 
ContinueWP, TelepinFrontLoop, ContinueTPIF, poolparty, oasis, boxring, lakebridge, lscjungle, tgshouse, northy, ufomap, 
oneil, pornya, finbank, jewelry, cargo, sunkencargo, aircraft, mbd, bigrampmazebank, bus, exparkour, exwallride, highhalf, 
loopzancudo, loopcity, loopcasino, monstersrunners, motoparkour, parkour, rampmaze, rolldevil, runnerzentorno, skytrack, 
rampplaza, stunterssnipers, superhalf, trackairport, trackdesert, trackcity, trackmap, twisterairport, basket, twister, gp, 
bigramp1, bigramp2, bigramp3, allplayersexplode, includeself, supunch, spawncardesign, 
expammo, fireammo, frztime, fpscount, ragdollmod, noragd, neonon, lightn;

bool playersforcefield[] = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
Ped pedforcefield[] = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
bool playershostile[] = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
Ped pedhostile[] = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

bool
SelectedItem,
 PressX = false,
 rightPress = false,
 leftPress = false,
 fastRPress = false,
 fastLPress = false;

 int lastButtonPress = 0,
 buttonPressDelay = 200,
 NumMenu = 0,
 NumMenuLevel,
 lastNumMenu[20],
 lastOption[20],
 currentOption,
 optionCount,
 maxOptions = 13;

#pragma region other def
 int fps;
 int frameCache_new;
 int frameCache_old;
 int frameCache_time;
 int peds[20];
 float savedx;
 float savedy;
 float savedz;
 int selfwanted = 0;
 int selected_player = 0;
 int selSpeedom = 0;
 int iperj = 1;
 int superr = 1;
 int supermanmultip = 1;
 int nfsm = 1;
 int vehj = 1;
 int vehnos = 1;
 int pstars = 0;
 int givemoney = 0;
 int moneyrmultip = 1;
 int selneon = 0;
 int engine = 0;
 int transmission = 0;
 int armor = 0;
 int suspension = 0;
 int fbumper = 0;
 int rbumper = 0;
 int exhaust = 0;
 int spoiler = 0;
 int brakes = 0;
 int skirt = 0;
 int hood = 0;
 int roof = 0;
 int horn = 0;
 int frame = 0;
 int windows = 0;
 int headlights = 0;
 bool turbo;
 int tiresmoke = 0;
 int rollcage = 0;
 int platetype = 0;
 int grille = 0;
 bool customtires;
 bool bulletprooftires;
 int patriotsmoke = 0;
 int wheeltype = 0;
 int wheel = 0;
 int primcolor = 0;
 int seccolor = 0;
 int pearlcolor = 0;
 int rimcolor = 0;
 int rimpearlcolor = 0;
 const char *platetext;
 int sportwheel = 0;
 int musclewheel = 0;
 int lowriderwheel = 0;
 int suvwheel = 0;
 int offroadwheel = 0;
 int tunerwheel = 0;
 int highendwheel = 0;
 int allplayersmoneyrainmultip = 1;
 int opmoneyrainmultip = 1;
 Ped OPswat;
 Ped OPswat2;
 Ped OPswat3;
 Ped OPswat4;
 Ped swatBuzz;
#pragma endregion

#pragma region functionsss
 const char *GET_WEAPON_NAME_FROM_HASH(Hash hash)
 {
	 const char *name;
	 switch (hash)
	 {
	 case 0x99B507EA:
		 name = "Knife";
		 break;
	 case 0x678B81B1:
		 name = "Nightstick";
		 break;
	 case 0x4E875F73:
		 name = "Hammer";
		 break;
	 case 0x958A4A8F:
		 name = "Bat";
		 break;
	 case 0x440E4788:
		 name = "GolfClub";
		 break;
	 case 0x84BD7BFD:
		 name = "Crowbar";
		 break;
	 case 0x1B06D571:
		 name = "Pistol";
		 break;
	 case 0x5EF9FEC4:
		 name = "CombatPistol";
		 break;
	 case 0x22D8FE39:
		 name = "APPistol";
		 break;
	 case 0x99AEEB3B:
		 name = "Pistol50";
		 break;
	 case 0x13532244:
		 name = "MicroSMG";
		 break;
	 case 0x2BE6766B:
		 name = "SMG";
		 break;
	 case 0xEFE7E2DF:
		 name = "AssaultSMG";
		 break;
	 case 0x0A3D4D34:
		 name = "CombatPDW";
		 break;
	 case 0xBFEFFF6D:
		 name = "AssaultRifle";
		 break;
	 case 0x83BF0278:
		 name = "CarbineRifle";
		 break;
	 case 0xAF113F99:
		 name = "AdvancedRifle";
		 break;
	 case 0x9D07F764:
		 name = "MG";
		 break;
	 case 0x7FD62962:
		 name = "CombatMG";
		 break;
	 case 0x1D073A89:
		 name = "PumpShotgun";
		 break;
	 case 0x7846A318:
		 name = "SawnOffShotgun";
		 break;
	 case 0xE284C527:
		 name = "AssaultShotgun";
		 break;
	 case 0x9D61E50F:
		 name = "BullpupShotgun";
		 break;
	 case 0x3656C8C1:
		 name = "StunGun";
		 break;
	 case 0x5FC3C11:
		 name = "SniperRifle";
		 break;
	 case 0xC472FE2:
		 name = "HeavySniper";
		 break;
	 case 0xA284510B:
		 name = "GrenadeLauncher";
		 break;
	 case 0x4DD2DC56:
		 name = "GrenadeLauncherSmoke";
		 break;
	 case 0xB1CA77B1:
		 name = "RPG";
		 break;
	 case 0x42BF8A85:
		 name = "Minigun";
		 break;
	 case 0x93E220BD:
		 name = "Grenade";
		 break;
	 case 0x2C3731D9:
		 name = "StickyBomb";
		 break;
	 case 0xFDBC8A50:
		 name = "SmokeGrenade";
		 break;
	 case 0xA0973D5E:
		 name = "BZGas";
		 break;
	 case 0x24B17070:
		 name = "Molotov";
		 break;
	 case 0x60EC506:
		 name = "FireExtinguisher";
		 break;
	 case 0x34A67B97:
		 name = "PetrolCan";
		 break;
	 case 0xBFD21232:
		 name = "SNSPistol";
		 break;
	 case 0xC0A3098D:
		 name = "SpecialCarbine";
		 break;
	 case 0xD205520E:
		 name = "HeavyPistol";
		 break;
	 case 0x7F229F94:
		 name = "BullpupRifle";
		 break;
	 case 0x63AB0442:
		 name = "HomingLauncher";
		 break;
	 case 0xAB564B93:
		 name = "ProximityMine";
		 break;
	 case 0x787F0BB:
		 name = "Snowball";
		 break;
	 case 0x83839C4:
		 name = "VintagePistol";
		 break;
	 case 0x92A27487:
		 name = "Dagger";
		 break;
	 case 0x7F7497E5:
		 name = "Firework";
		 break;
	 case 0xA89CB99E:
		 name = "Musket";
		 break;
	 case 0xC734385A:
		 name = "MarksmanRifle";
		 break;
	 case 0x3AABBBAA:
		 name = "HeavyShotgun";
		 break;
	 case 0x61012683:
		 name = "Gusenberg";
		 break;
	 case 0xF9DCBF2D:
		 name = "Hatchet";
		 break;
	 case 0x6D544C99:
		 name = "Railgun";
		 break;
	 case 0xA2719263:
		 name = "Unarmed";
		 break;
	 }
	 return name;
 }
 float PosP(float input)
 {
	 return input / GET_SAFE_ZONE_SIZE();
 }
#pragma endregion
#pragma endregion
 
int SetGlobal(unsigned int globalId, int value, int wouldRead) 
{
	static unsigned int** arr = (unsigned int**)0x1E70370;
	switch (wouldRead)
	{
	case 0: arr[(globalId >> 18) & 0x3F][globalId & 0x3FFFF] = value; /*arr[globalId / 0x40000][globalId % 0x40000] = value;*/ break; //write
	case 1: return arr[(globalId >> 18) & 0x3F][globalId & 0x3FFFF]; /*return arr[globalId / 0x40000][globalId % 0x40000];*/ break; //read
	case 2: /*&arr[(globalId >> 18) & 0x3F][globalId & 0x3FFFF];*/ /*&return &arr[globalId / 0x40000][globalId % 0x40000];*/ break; //to address //returns int *
	}
	return 0;
}

void DRAW_TEXT_OPTION(char * text, int Font, float x, float y, float scalex, float scaley, int a, bool center, bool UseEdge, int RD, int GD, int BD)
{
	SET_TEXT_FONT(Font);
	SET_TEXT_SCALE(scalex, scaley);
	if(SelectedItem)
	    SET_TEXT_COLOUR(0, 0, 0, 255);
    else
	{
		SET_TEXT_COLOUR(255, 255, 255, 255);
		SET_TEXT_OUTLINE();
	}
	SET_TEXT_WRAP(0.0f, 1.0f);
	SET_TEXT_CENTRE(center);
	BEGIN_TEXT_COMMAND_DISPLAY_TEXT("STRING");
	ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME(text);
	END_TEXT_COMMAND_DISPLAY_TEXT(x, y);
}

void DRAW_TEXT(char * text, int Font, float x, float y, float scalex, float scaley, int r, int g, int b, int a, bool center, bool UseEdge, int RD, int GD, int BD)
{
	SET_TEXT_FONT(Font);
	SET_TEXT_SCALE(scalex, scaley);
	SET_TEXT_COLOUR(r, g, b, a);
	SET_TEXT_WRAP(0.0f, 1.0f);
	SET_TEXT_CENTRE(center);
	SET_TEXT_DROPSHADOW(0, 0, 0, 0, 0);
	SET_TEXT_OUTLINE();
	BEGIN_TEXT_COMMAND_DISPLAY_TEXT("STRING");
	ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME(text);
	END_TEXT_COMMAND_DISPLAY_TEXT(x, y);
}

void DRAW_TEXT2(char * text, int Font, float x, float y, float scalex, float scaley, int r, int g, int b, int a, bool center)
{
	SET_TEXT_FONT(Font);
	SET_TEXT_SCALE(scalex, scaley);
	SET_TEXT_COLOUR(r, g, b, a);
	SET_TEXT_WRAP(0.0f, 1.0f);
	SET_TEXT_CENTRE(center);
	SET_TEXT_DROPSHADOW(0, 0, 0, 0, 0);
	SET_TEXT_OUTLINE();
	BEGIN_TEXT_COMMAND_DISPLAY_TEXT("STRING");
	ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME(text);
	END_TEXT_COMMAND_DISPLAY_TEXT(x, y);
}

void DRAW_TEXT2_RIGHT(char * text, int Font, float x, float y, float scalex, float scaley, int r, int g, int b, int a, bool center)
{
	SET_TEXT_FONT(Font);
	SET_TEXT_SCALE(scalex, scaley);
	SET_TEXT_COLOUR(r, g, b, a);
	SET_TEXT_WRAP(0.0f, 1.0f);
	if (center)
	{
		SET_TEXT_CENTRE(center);
	}
	else
	{
		SET_TEXT_RIGHT_JUSTIFY(true);
		SET_TEXT_WRAP(0, x);
	}
	SET_TEXT_DROPSHADOW(0, 0, 0, 0, 0);
	SET_TEXT_OUTLINE();
	BEGIN_TEXT_COMMAND_DISPLAY_TEXT("STRING");
	ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME(text);
	END_TEXT_COMMAND_DISPLAY_TEXT(x, y);
}

void DRAW_TEXT2_F(float val, int Font, float x, float y, float scalex, float scaley, int r, int g, int b, int a, bool center)
{
	SET_TEXT_FONT(Font);
	SET_TEXT_SCALE(scalex, scaley);
	SET_TEXT_COLOUR(r, g, b, a);
	SET_TEXT_WRAP(0.0f, 1.0f);
	SET_TEXT_CENTRE(center);
	SET_TEXT_DROPSHADOW(0, 0, 0, 0, 0);
	SET_TEXT_OUTLINE();
	BEGIN_TEXT_COMMAND_DISPLAY_TEXT("NUMBER");
	ADD_TEXT_COMPONENT_FLOAT(val, 2);
	END_TEXT_COMMAND_DISPLAY_TEXT(x, y);
}

void DRAW_TEXT2_I(int val, int Font, float x, float y, float scalex, float scaley, int r, int g, int b, int a, bool center)
{
	SET_TEXT_FONT(Font);
	SET_TEXT_SCALE(scalex, scaley);
	SET_TEXT_COLOUR(r, g, b, a);
	SET_TEXT_WRAP(0.0f, 1.0f);
	SET_TEXT_CENTRE(center);
	SET_TEXT_DROPSHADOW(0, 0, 0, 0, 0);
	SET_TEXT_OUTLINE();
	BEGIN_TEXT_COMMAND_DISPLAY_TEXT("NUMBER");
	ADD_TEXT_COMPONENT_INTEGER(val);
	END_TEXT_COMMAND_DISPLAY_TEXT(x, y);
}

void SPRITE(char* TextOne, char* TextTwo, float X, float Y, float Width, float Height, float Rotation, int R, int G, int B, int A)
{
	 while (!HAS_STREAMED_TEXTURE_DICT_LOADED(TextOne)) 
	 {
        REQUEST_STREAMED_TEXTURE_DICT(TextOne, false);
        WAIT(0);
    }
	DRAW_SPRITE(TextOne, TextTwo, X, Y, Width, Height, Rotation, R, G, B, A);
}

void draw_item_count(float x, float y, float xs, float ys)
{
	SET_TEXT_FONT(1);
	SET_TEXT_SCALE(xs,  ys);
	SET_TEXT_LEADING(2);
	SET_TEXT_COLOUR(255, 170, 0, 255);
	SET_TEXT_WRAP(0, 1);
	SET_TEXT_CENTRE(1);
	SET_TEXT_DROPSHADOW(0, 0, 0, 0, 0);
	SET_TEXT_OUTLINE(0);
	BEGIN_TEXT_COMMAND_DISPLAY_TEXT("CM_ITEM_COUNT");
	ADD_TEXT_COMPONENT_INTEGER(currentOption);
	ADD_TEXT_COMPONENT_INTEGER(optionCount);
	END_TEXT_COMMAND_DISPLAY_TEXT(x,y);
}

void draw_item_count_option(float x, float y, float xs, float ys, int ptr, int max)
{
	if (max >= 100)
	{
		SPRITE("commonmenu", "arrowleft", x - .021, y + .018, .014, .014, 0, 255, 255, 255, 255);
		SPRITE("commonmenu", "arrowright", x + .021, y + .018, .014, .014, 0, 255, 255, 255, 255);
	}
	else if (max >= 10)
	{
		SPRITE("commonmenu", "arrowleft", x - .018, y + .018, .014, .014, 0, 255, 255, 255, 255);
		SPRITE("commonmenu", "arrowright", x + .018, y + .018, .014, .014, 0, 255, 255, 255, 255);
	}
	else
	{
		SPRITE("commonmenu", "arrowleft", x - .015, y + .018, .014, .014, 0, 255, 255, 255, 255);
		SPRITE("commonmenu", "arrowright", x + .015, y + .018, .014, .014, 0, 255, 255, 255, 255);
	}

	SET_TEXT_FONT(4);
	SET_TEXT_SCALE(xs, ys);
	SET_TEXT_LEADING(2);
	SET_TEXT_COLOUR(255, 255, 255, 255);
	SET_TEXT_WRAP(0, 1);
	SET_TEXT_CENTRE(1);
	SET_TEXT_DROPSHADOW(0, 0, 0, 0, 0);
	SET_TEXT_OUTLINE(0);
	BEGIN_TEXT_COMMAND_DISPLAY_TEXT("CM_ITEM_COUNT");
	ADD_TEXT_COMPONENT_INTEGER(ptr);
	ADD_TEXT_COMPONENT_INTEGER(max);
	END_TEXT_COMMAND_DISPLAY_TEXT(x, y);
}

void AddTitle(char* Text)
{
	DRAW_TEXT2(Text, 1, Title_X, 0.0930, 0.9000, 0.9000, 255, 170, 0, 255, true);
}

void AddSubTitle(char* Text)
{
	if (optionCount > maxOptions)
	{
	    DRAW_TEXT2(Text, 1, Title_X, ((maxOptions + 1) * 0.035f + 0.163f), 0.49000000, 0.49000000, 255, 170, 0, 255, true); 
	}
	else
	{
		DRAW_TEXT2(Text, 1, Title_X, ((optionCount + 1) * 0.035f + 0.163f), 0.49000000, 0.49000000, 255, 170, 0, 255, true);
	}
}

void AddSubTitleOP(char* Text)
{
	DRAW_TEXT2(Text, 1, Title_OPX, ((12) * 0.033f + 0.116f + 0.002), 0.48000000, 0.48000000, 255, 170, 0, 255, true);
}

void AddTitleOP(char* Text)
{
	DRAW_TEXT2(Text, 1, Title_OPX, 0.0945, 0.7000, 0.7000, 255, 170, 0, 255, true);
}

void addOption(char *option)
{
	optionCount++;
	SET_TEXT_OUTLINE();
	float sel;
	if (currentOption == optionCount)
		sel = .012;
	else
		sel = 0;
	
	if (currentOption <= maxOptions && optionCount <= maxOptions)
	{
		DRAW_TEXT_OPTION(option, 4, Cunt + sel, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);
	}
	else if ((optionCount > (currentOption - maxOptions)) && optionCount <= currentOption)
	{
		DRAW_TEXT_OPTION(option, 4, Cunt + sel, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);
	}
}

void addOptionMultip(char *option, int *mult, int min, int max)
{
	optionCount++;
	SET_TEXT_OUTLINE();
	float sel;
	if (currentOption == optionCount)
	{
		sel = .012;
		if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xCC))
		{
			if (*mult <= min)
				*mult = max;
			else
				*mult = *mult - 1;
		}
		if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xCD))
		{
			if (*mult >= max)
				*mult = min;
			else
				*mult = *mult + 1;
		}
	}
	else
	{
		sel = 0;
	}
		
	if (currentOption <= maxOptions && optionCount <= maxOptions)
	{
		DRAW_TEXT_OPTION(option, 4, Cunt + sel, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);
		
		if (*mult == 1)
		    DRAW_TEXT2("< x1 >", 4, 0.8650, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		else if (*mult == 2)
			DRAW_TEXT2("< x2 >", 4, 0.8650, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		else if (*mult == 3)
			DRAW_TEXT2("< x3 >", 4, 0.8650, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		else if (*mult == 4)
			DRAW_TEXT2("< x4 >", 4, 0.8650, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		else if (*mult == 5)
			DRAW_TEXT2("< x5 >", 4, 0.8650, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
	}
	else if ((optionCount > (currentOption - maxOptions)) && optionCount <= currentOption)
	{
		DRAW_TEXT_OPTION(option, 4, Cunt + sel, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);
		
		if (*mult == 1)
			DRAW_TEXT2("< x1 >", 4, 0.8650, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		else if (*mult == 2)
			DRAW_TEXT2("< x2 >", 4, 0.8650, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		else if (*mult == 3)
			DRAW_TEXT2("< x3 >", 4, 0.8650, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		else if (*mult == 4)
			DRAW_TEXT2("< x4 >", 4, 0.8650, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		else if (*mult == 5)
			DRAW_TEXT2("< x5 >", 4, 0.8650, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
	}
}

void addOptionInt(char *option, int *ptr, int min, int max)
{
	optionCount++;
	float sel;
	if (currentOption == optionCount)
	{
		sel = .012;
		if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xCC))
		{
			if (*ptr <= min)
				*ptr = max;
			else
				*ptr = *ptr - 1;
		}
		if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xCD))
		{
			if (*ptr >= max)
				*ptr = min;
			else
				*ptr = *ptr + 1;
		}
	}
	else
	{
		sel = 0;
	}

	SET_TEXT_OUTLINE();

	if (currentOption <= maxOptions && optionCount <= maxOptions)
	{
		DRAW_TEXT_OPTION(option, 4, Cunt + sel, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);
		
		if (*ptr == 0)
		{
			DRAW_TEXT2("< 0 >", 4, 0.8700, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
		else if (*ptr == 1)
		{
			DRAW_TEXT2("< 1 >", 4, 0.8700, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
		else if (*ptr == 2)
		{
			DRAW_TEXT2("< 2 >", 4, 0.8700, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
		else if (*ptr == 3)
		{
			DRAW_TEXT2("< 3 >", 4, 0.8700, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
		else if (*ptr == 4)
		{
			DRAW_TEXT2("< 4 >", 4, 0.8700, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
		else if (*ptr == 5)
		{
			DRAW_TEXT2("< 5 >", 4, 0.8700, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
	}
	else if ((optionCount > (currentOption - maxOptions)) && optionCount <= currentOption)
	{
		DRAW_TEXT_OPTION(option, 4, Cunt + sel, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);

		if (*ptr == 0)
		{
			DRAW_TEXT2("< 0 >", 4, 0.8700, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
		else if (*ptr == 1)
		{
			DRAW_TEXT2("< 1 >", 4, 0.8700, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
		else if (*ptr == 2)
		{
			DRAW_TEXT2("< 2 >", 4, 0.8700, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
		else if (*ptr == 3)
		{
			DRAW_TEXT2("< 3 >", 4, 0.8700, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
		else if (*ptr == 4)
		{
			DRAW_TEXT2("< 4 >", 4, 0.8700, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
		else if (*ptr == 5)
		{
			DRAW_TEXT2("< 5 >", 4, 0.8700, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
	}
}

void addOptionIntList(char *option, int *ptr, char** list, int min, int max)
{
	optionCount++;
	if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xCC) && currentOption == optionCount)
	{
		if (*ptr <= min)
			*ptr = max;
		else
			*ptr = *ptr - 1;
	}
	if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xCD) && currentOption == optionCount)
	{
		if (*ptr >= max)
			*ptr = min;
		else
			*ptr = *ptr + 1;
	}

	SET_TEXT_OUTLINE();
	float sel;
	if (currentOption == optionCount)
		sel = .012;
	else
		sel = 0;

	if (currentOption <= maxOptions && optionCount <= maxOptions)
	{
		DRAW_TEXT_OPTION(option, 4, Cunt + sel, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);
		
		int len = GET_LENGTH_OF_LITERAL_STRING(list[*ptr]);
		
		if (len <= 10)
		{
			draw_item_count_option(0.8100, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, *ptr, max);
		}
		else if (len >= 10 && len <= 14)
		{
			draw_item_count_option(0.7950, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, *ptr, max);
		}
		else if (len >= 10 && len >= 14 && len <= 17)
		{
			draw_item_count_option(0.7780, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, *ptr, max);
		}
		else if (len >= 17)
		{
			draw_item_count_option(0.7650, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, *ptr, max);
		}

		DRAW_TEXT2_RIGHT(list[*ptr], 4, 0.8850, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, false);
	}
	else if ((optionCount > (currentOption - maxOptions)) && optionCount <= currentOption)
	{
		DRAW_TEXT_OPTION(option, 4, Cunt + sel, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);
		
		int len = GET_LENGTH_OF_LITERAL_STRING(list[*ptr]);

		if (len <= 10)
		{
			draw_item_count_option(0.8100, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, *ptr, max);
		}
		else if (len >= 10 && len <= 14)
		{
			draw_item_count_option(0.7950, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, *ptr, max);
		}
		else if (len >= 10 && len >= 14 && len <= 17)
		{
			draw_item_count_option(0.7780, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, *ptr, max);
		}
		else if (len >= 17)
		{
			draw_item_count_option(0.7650, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, *ptr, max);
		}
		
		DRAW_TEXT2_RIGHT(list[*ptr], 4, 0.8850, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, false);
	}
}

void addOptionMoney(char *option)
{
	optionCount++;
	SET_TEXT_OUTLINE();
	float sel;
	if (currentOption == optionCount)
	{
		sel = .012;
		if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xCC))
		{
			if (givemoney <= 0)
				givemoney = 5;
			else
				givemoney = givemoney - 1;
		}
		if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xCD))
		{
			if (givemoney >= 5)
				givemoney = 0;
			else
				givemoney = givemoney + 1;
		}
	}
	else
	{
		sel = 0;
	}

	if (currentOption <= maxOptions && optionCount <= maxOptions)
	{
		DRAW_TEXT_OPTION(option, 4, Cunt + sel, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);

		if (givemoney == 0)
		{
			DRAW_TEXT2("< 100.000 $ >", 4, 0.8520, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
		else if (givemoney == 1)
		{
			DRAW_TEXT2("< 250.000 $ >", 4, 0.8516, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
		else if (givemoney == 2)
		{
			DRAW_TEXT2("< 500.000 $ >", 4, 0.8514, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
		else if (givemoney == 3)
		{
			DRAW_TEXT2("< 1.000.000 $ >", 4, 0.8500, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
		else if (givemoney == 4)
		{
			DRAW_TEXT2("< 5.000.000 $ >", 4, 0.8488, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
		else if (givemoney == 5)
		{
			DRAW_TEXT2("< 50.000.000 $ >", 4, 0.8468, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
	}
	else if ((optionCount > (currentOption - maxOptions)) && optionCount <= currentOption)
	{
		DRAW_TEXT_OPTION(option, 4, Cunt + sel, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);

		if (givemoney == 0)
		{
			DRAW_TEXT2("< 100.000 $ >", 4, 0.8520, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
		else if (givemoney == 1)
		{
			DRAW_TEXT2("< 250.000 $ >", 4, 0.8516, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
		else if (givemoney == 2)
		{
			DRAW_TEXT2("< 500.000 $ >", 4, 0.8514, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
		else if (givemoney == 3)
		{
			DRAW_TEXT2("< 1.000.000 $ >", 4, 0.8500, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
		else if (givemoney == 4)
		{
			DRAW_TEXT2("< 5.000.000 $ >", 4, 0.8488, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
		else if (givemoney == 5)
		{
			DRAW_TEXT2("< 50.000.000 $ >", 4, 0.8468, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
	}
}

void addOptionScript(char *option, char *butt1, char *butt2)
{
	optionCount++;
	SET_TEXT_OUTLINE();
	float sel;
	if (currentOption == optionCount)
		sel = .012;
	else
		sel = 0;

	if (currentOption <= maxOptions && optionCount <= maxOptions)
	{
		DRAW_TEXT_OPTION(option, 4, Cunt + sel, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);
		if (!IS_STRING_NULL_OR_EMPTY(butt1) && !IS_STRING_NULL_OR_EMPTY(butt2))
		{
			DRAW_TEXT_OPTION("+", 4, 0.8050, (optionCount * 0.035f + 0.123f), 0.68000000, 0.49000000, 255, false, false, 0, 0, 0);
			
			if (ARE_STRINGS_EQUAL(butt1, buttonR1) || ARE_STRINGS_EQUAL(butt1, buttonL1))
			{
				SPRITE("erootiik", butt1, 0.7900, (optionCount * 0.035f + 0.140f), 0.01500000, 0.02500000, 0, 255, 255, 255, 255);
			}
			else
			{
				SPRITE("erootiik", butt1, 0.7900, (optionCount * 0.035f + 0.140f), 0.01500000, 0.02200000, 0, 255, 255, 255, 255);
			}
			if (ARE_STRINGS_EQUAL(butt2, buttonR1) || ARE_STRINGS_EQUAL(butt2, buttonL1))
			{
				SPRITE("erootiik", butt2, 0.8300, (optionCount * 0.035f + 0.140f), 0.01500000, 0.02500000, 0, 255, 255, 255, 255);
			}
			else
			{
				SPRITE("erootiik", butt2, 0.8300, (optionCount * 0.035f + 0.140f), 0.01500000, 0.02200000, 0, 255, 255, 255, 255);
			}
		}
	}
	else if ((optionCount > (currentOption - maxOptions)) && optionCount <= currentOption)
	{
		DRAW_TEXT_OPTION(option, 4, Cunt + sel, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);
		if (!IS_STRING_NULL_OR_EMPTY(butt1) && !IS_STRING_NULL_OR_EMPTY(butt2))
		{
			DRAW_TEXT_OPTION("+", 4, 0.8050, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.68000000, 0.49000000, 255, false, false, 0, 0, 0);
			
			if (ARE_STRINGS_EQUAL(butt1, buttonR1) || ARE_STRINGS_EQUAL(butt1, buttonL1))
			{
				SPRITE("erootiik", butt1, 0.7900, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.140f), 0.01500000, 0.02500000, 0, 255, 255, 255, 255);
			}
			else
			{
				SPRITE("erootiik", butt1, 0.7900, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.140f), 0.01500000, 0.02200000, 0, 255, 255, 255, 255);
			}

			if (ARE_STRINGS_EQUAL(butt2, buttonR1) || ARE_STRINGS_EQUAL(butt2, buttonL1))
			{
				SPRITE("erootiik", butt2, 0.8300, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.140f), 0.01500000, 0.02500000, 0, 255, 255, 255, 255);
			}
			else
			{
				SPRITE("erootiik", butt2, 0.8300, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.140f), 0.01500000, 0.02200000, 0, 255, 255, 255, 255);
			}
		}
	}
}

void CheckBox(char *option, bool BOOL)
{
	char buf[30];
	optionCount++;
	SET_TEXT_OUTLINE();
	float sel;
	if (currentOption == optionCount)
		sel = .012;
	else
		sel = 0;

	if (currentOption <= maxOptions && optionCount <= maxOptions)
	{
		DRAW_TEXT_OPTION(option, 4, Cunt + sel, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);
		if (BOOL)
		{
			SPRITE("commonmenu", "common_medal", 0.8700, (optionCount * 0.035f + 0.1413f), 0.03, 0.04, 0, 0, 0, 0, 255);
			SPRITE("commonmenu", "common_medal", 0.8700, (optionCount * 0.035f + 0.1413f), 0.02, 0.03, 0, 0, 255, 0, 150);
		}
		else
		{
			SPRITE("commonmenu", "common_medal", 0.8700, (optionCount * 0.035f + 0.1413f), 0.03, 0.04, 0, 0, 0, 0, 255);
			SPRITE("commonmenu", "common_medal", 0.8700, (optionCount * 0.035f + 0.1413f), 0.02, 0.03, 0, 255, 0, 0, 150);
		}
	}
	else if ((optionCount > (currentOption - maxOptions)) && optionCount <= currentOption)
	{
		DRAW_TEXT_OPTION(option, 4, Cunt + sel, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);
		if (BOOL)
		{
			SPRITE("commonmenu", "common_medal", 0.8700, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.1413f), 0.03, 0.04, 0, 0, 0, 0, 255);
			SPRITE("commonmenu", "common_medal", 0.8700, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.1413f), 0.02, 0.03, 0, 0, 255, 0, 150);
		}
		else
		{
			SPRITE("commonmenu", "common_medal", 0.8700, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.1413f), 0.03, 0.04, 0, 0, 0, 0, 255);
			SPRITE("commonmenu", "common_medal", 0.8700, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.1413f), 0.02, 0.03, 0, 255, 0, 0, 150);
		}
	}
}

void CheckBoxSpeedom(char *option, int *ptr, int min, int max, bool BOOL)
{
	char buf[30];
	if (NumMenu == Vehicle_Mods && currentOption == 6)
	{
		if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xCC))
		{
			if (*ptr <= min)
				*ptr = max;
			else
				*ptr = *ptr - 1;
		}
		if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xCD))
		{
			if (*ptr >= max)
				*ptr = min;
			else
				*ptr = *ptr + 1;
		}
	}
	optionCount++;
	SET_TEXT_OUTLINE();
	float sel;
	if (currentOption == optionCount)
		sel = .012;
	else
		sel = 0;

	if (currentOption <= maxOptions && optionCount <= maxOptions)
	{
		DRAW_TEXT_OPTION(option, 4, Cunt + sel, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);
		DRAW_TEXT2_I(selSpeedom, 4, 0.8130, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		if (selSpeedom == 0)
		{
			DRAW_TEXT2("< Km/h >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
		else if (selSpeedom == 1)
		{
			DRAW_TEXT2("< Mp/h >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
		if (BOOL)
		{
			SPRITE("commonmenu", "common_medal", 0.8700, (optionCount * 0.035f + 0.1413f), 0.03, 0.04, 0, 0, 0, 0, 255);
			SPRITE("commonmenu", "common_medal", 0.8700, (optionCount * 0.035f + 0.1413f), 0.02, 0.03, 0, 0, 255, 0, 150);
		}
		else
		{
			SPRITE("commonmenu", "common_medal", 0.8700, (optionCount * 0.035f + 0.1413f), 0.03, 0.04, 0, 0, 0, 0, 255);
			SPRITE("commonmenu", "common_medal", 0.8700, (optionCount * 0.035f + 0.1413f), 0.02, 0.03, 0, 255, 0, 0, 150);
		}
	}
	else if ((optionCount > (currentOption - maxOptions)) && optionCount <= currentOption)
	{
		DRAW_TEXT_OPTION(option, 4, Cunt + sel, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);
		DRAW_TEXT2_I(selSpeedom, 4, 0.8130, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		if (selSpeedom == 0)
		{
			DRAW_TEXT2("< Km/h >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
		else if (selSpeedom == 1)
		{
			DRAW_TEXT2("< Mp/h >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
		}
		if (BOOL)
		{
			SPRITE("commonmenu", "common_medal", 0.8700, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.1413f), 0.03, 0.04, 0, 0, 0, 0, 255);
			SPRITE("commonmenu", "common_medal", 0.8700, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.1413f), 0.02, 0.03, 0, 0, 255, 0, 150);
		}
		else
		{
			SPRITE("commonmenu", "common_medal", 0.8700, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.1413f), 0.03, 0.04, 0, 0, 0, 0, 255);
			SPRITE("commonmenu", "common_medal", 0.8700, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.1413f), 0.02, 0.03, 0, 255, 0, 0, 150);
		}
	}
}

void CheckBoxMultiplier(char *option, int *ptr, int min, int max, bool BOOL, int mod)
{
	char buf[30];
	if (NumMenu == Self_Mods && mod == 1)
	{
		if (currentOption == 4)
		{
			if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xCC))
			{
				if (iperj <= min)
					iperj = max;
				else
					iperj = iperj - 1;
			}
			if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xCD))
			{
				if (iperj >= max)
					iperj = min;
				else
					iperj = iperj + 1;
			}
		}
	}
	else if (NumMenu == Self_Mods && mod == 2)
	{
		if (currentOption == 6)
		{
			if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xCC))
			{
				if (superr <= min)
					superr = max;
				else
					superr = superr - 1;
			}
			if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xCD))
			{
				if (superr >= max)
					superr = min;
				else
					superr = superr + 1;
			}
		}
	}
	else if (NumMenu == Vehicle_Mods && mod == 3)
	{
		if (currentOption == 4)
		{
			if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xCC))
			{
				if (nfsm <= min)
					nfsm = max;
				else
					nfsm = nfsm - 1;
			}
			if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xCD))
			{
				if (nfsm >= max)
					nfsm = min;
				else
					nfsm = nfsm + 1;
			}
		}
	}
	else if (NumMenu == Vehicle_Mods && mod == 4)
	{
		if (currentOption == 13)
		{
			if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xCC))
			{
				if (vehj <= min)
					vehj = max;
				else
					vehj = vehj - 1;
			}
			if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xCD))
			{
				if (vehj >= max)
					vehj = min;
				else
					vehj = vehj + 1;
			}
		}
	}
	else if (NumMenu == Vehicle_Mods && mod == 5)
	{
		if (currentOption == 14)
		{
			if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xCC))
			{
				if (vehnos <= min)
					vehnos = max;
				else
					vehnos = vehnos - 1;
			}
			if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xCD))
			{
				if (vehnos >= max)
					vehnos = min;
				else
					vehnos = vehnos + 1;
			}
		}
	}
	else if (NumMenu == Self_Mods && mod == 6)
	{
		if (currentOption == 5)
		{
			if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xCC))
			{
				if (supermanmultip <= min)
					supermanmultip = max;
				else
					supermanmultip = supermanmultip - 1;
			}
			if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xCD))
			{
				if (supermanmultip >= max)
					supermanmultip = min;
				else
					supermanmultip = supermanmultip + 1;
			}
		}
	}

	optionCount++;
	SET_TEXT_OUTLINE();
	float sel;
	if (currentOption == optionCount)
		sel = .012;
	else
		sel = 0;

	if (currentOption <= maxOptions && optionCount <= maxOptions)
	{
		DRAW_TEXT_OPTION(option, 4, Cunt + sel, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);
		if (mod == 1)
		{
			if (iperj == 1)
			{
				DRAW_TEXT2("< x1 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (iperj == 2)
			{
				DRAW_TEXT2("< x2 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (iperj == 3)
			{
				DRAW_TEXT2("< x3 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (iperj == 4)
			{
				DRAW_TEXT2("< x4 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (iperj == 5)
			{
				DRAW_TEXT2("< x5 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
		}
		else if (mod == 2)
		{
			if (superr == 1)
			{
				DRAW_TEXT2("< x1 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (superr == 2)
			{
				DRAW_TEXT2("< x2 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (superr == 3)
			{
				DRAW_TEXT2("< x3 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (superr == 4)
			{
				DRAW_TEXT2("< x4 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (superr == 5)
			{
				DRAW_TEXT2("< x5 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
		}
		else if (mod == 3)
		{
			if (nfsm == 1)
			{
				DRAW_TEXT2("< x1 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (nfsm == 2)
			{
				DRAW_TEXT2("< x2 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (nfsm == 3)
			{
				DRAW_TEXT2("< x3 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (nfsm == 4)
			{
				DRAW_TEXT2("< x4 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (nfsm == 5)
			{
				DRAW_TEXT2("< x5 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
		}
		else if (mod == 4)
		{
			if (vehj == 1)
			{
				DRAW_TEXT2("< x1 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (vehj == 2)
			{
				DRAW_TEXT2("< x2 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (vehj == 3)
			{
				DRAW_TEXT2("< x3 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (vehj == 4)
			{
				DRAW_TEXT2("< x4 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (vehj == 5)
			{
				DRAW_TEXT2("< x5 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
		}
		else if (mod == 5)
		{
			if (vehnos == 1)
			{
				DRAW_TEXT2("< x1 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (vehnos == 2)
			{
				DRAW_TEXT2("< x2 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (vehnos == 3)
			{
				DRAW_TEXT2("< x3 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (vehnos == 4)
			{
				DRAW_TEXT2("< x4 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (vehnos == 5)
			{
				DRAW_TEXT2("< x5 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
		}
		else if (mod == 6)
		{
			if (supermanmultip == 1)
			{
				DRAW_TEXT2("< x1 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (supermanmultip == 2)
			{
				DRAW_TEXT2("< x2 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (supermanmultip == 3)
			{
				DRAW_TEXT2("< x3 >", 4, 0.8400, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
		}
		if (BOOL)
		{
			SPRITE("commonmenu", "common_medal", 0.8700, (optionCount * 0.035f + 0.1413f), 0.03, 0.04, 0, 0, 0, 0, 255);
			SPRITE("commonmenu", "common_medal", 0.8700, (optionCount * 0.035f + 0.1413f), 0.02, 0.03, 0, 0, 255, 0, 150);
		}
		else
		{
			SPRITE("commonmenu", "common_medal", 0.8700, (optionCount * 0.035f + 0.1413f), 0.03, 0.04, 0, 0, 0, 0, 255);
			SPRITE("commonmenu", "common_medal", 0.8700, (optionCount * 0.035f + 0.1413f), 0.02, 0.03, 0, 255, 0, 0, 150);
		}
	}
	else if ((optionCount > (currentOption - maxOptions)) && optionCount <= currentOption)
	{
		DRAW_TEXT_OPTION(option, 4, Cunt + sel, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);

		if (mod == 1)
		{
			if (iperj == 1)
			{
				DRAW_TEXT2("< x1 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (iperj == 2)
			{
				DRAW_TEXT2("< x2 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (iperj == 3)
			{
				DRAW_TEXT2("< x3 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (iperj == 4)
			{
				DRAW_TEXT2("< x4 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (iperj == 5)
			{
				DRAW_TEXT2("< x5 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
		}
		else if (mod == 2)
		{
			if (superr == 1)
			{
				DRAW_TEXT2("< x1 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (superr == 2)
			{
				DRAW_TEXT2("< x2 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (superr == 3)
			{
				DRAW_TEXT2("< x3 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (superr == 4)
			{
				DRAW_TEXT2("< x4 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (superr == 5)
			{
				DRAW_TEXT2("< x5 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
		}
		else if (mod == 3)
		{
			if (nfsm == 1)
			{
				DRAW_TEXT2("< x1 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (nfsm == 2)
			{
				DRAW_TEXT2("< x2 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (nfsm == 3)
			{
				DRAW_TEXT2("< x3 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (nfsm == 4)
			{
				DRAW_TEXT2("< x4 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (nfsm == 5)
			{
				DRAW_TEXT2("< x5 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
		}
		else if (mod == 4)
		{
			if (vehj == 1)
			{
				DRAW_TEXT2("< x1 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (vehj == 2)
			{
				DRAW_TEXT2("< x2 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (vehj == 3)
			{
				DRAW_TEXT2("< x3 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (vehj == 4)
			{
				DRAW_TEXT2("< x4 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (vehj == 5)
			{
				DRAW_TEXT2("< x5 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
		}
		else if (mod == 5)
		{
			if (vehnos == 1)
			{
				DRAW_TEXT2("< x1 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (vehnos == 2)
			{
				DRAW_TEXT2("< x2 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (vehnos == 3)
			{
				DRAW_TEXT2("< x3 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (vehnos == 4)
			{
				DRAW_TEXT2("< x4 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (vehnos == 5)
			{
				DRAW_TEXT2("< x5 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
		}
		else if (mod == 6)
		{
			if (supermanmultip == 1)
			{
				DRAW_TEXT2("< x1 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (supermanmultip == 2)
			{
				DRAW_TEXT2("< x2 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
			else if (supermanmultip == 3)
			{
				DRAW_TEXT2("< x3 >", 4, 0.8400, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.122f), 0.49000000, 0.49000000, 255, 255, 255, 255, true);
			}
		}
		if (BOOL)
		{
			SPRITE("commonmenu", "common_medal", 0.8700, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.1413f), 0.03, 0.04, 0, 0, 0, 0, 255);
			SPRITE("commonmenu", "common_medal", 0.8700, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.1413f), 0.02, 0.03, 0, 0, 255, 0, 150);
		}
		else
		{
			SPRITE("commonmenu", "common_medal", 0.8700, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.1413f), 0.03, 0.04, 0, 0, 0, 0, 255);
			SPRITE("commonmenu", "common_medal", 0.8700, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.1413f), 0.02, 0.03, 0, 255, 0, 0, 150);
		}
	}
}

void CheckBoxScript(char *option, bool BOOL, char *button1, char *button2)
{
	char buf[30];
	optionCount++;
	SET_TEXT_OUTLINE();
	float sel;
	if (currentOption == optionCount)
		sel = .012;
	else
		sel = 0;

	if (currentOption <= maxOptions && optionCount <= maxOptions)
	{
		DRAW_TEXT_OPTION(option, 4, Cunt + sel, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);
		if (!IS_STRING_NULL_OR_EMPTY(button1) && !IS_STRING_NULL_OR_EMPTY(button2))
		{
			DRAW_TEXT_OPTION("+", 4, 0.8050, (optionCount * 0.035f + 0.123f), 0.68000000, 0.49000000, 255, false, false, 0, 0, 0);

			if (ARE_STRINGS_EQUAL(button1, buttonR1) || ARE_STRINGS_EQUAL(button1, buttonL1))
			{
				SPRITE("erootiik", button1, 0.7900, (optionCount * 0.035f + 0.140f), 0.01500000, 0.02500000, 0, 255, 255, 255, 255);
			}
			else
			{
				SPRITE("erootiik", button1, 0.7900, (optionCount * 0.035f + 0.140f), 0.01500000, 0.02200000, 0, 255, 255, 255, 255);
			}
			if (ARE_STRINGS_EQUAL(button2, buttonR1) || ARE_STRINGS_EQUAL(button2, buttonL1))
			{
				SPRITE("erootiik", button2, 0.8300, (optionCount * 0.035f + 0.140f), 0.01500000, 0.02500000, 0, 255, 255, 255, 255);
			}
			else
			{
				SPRITE("erootiik", button2, 0.8300, (optionCount * 0.035f + 0.140f), 0.01500000, 0.02200000, 0, 255, 255, 255, 255);
			}
		}
		if (BOOL)
		{
			SPRITE("commonmenu", "common_medal", 0.8700, (optionCount * 0.035f + 0.1413f), 0.03, 0.04, 0, 0, 0, 0, 255);
			SPRITE("commonmenu", "common_medal", 0.8700, (optionCount * 0.035f + 0.1413f), 0.02, 0.03, 0, 0, 255, 0, 150);
		}
		else
		{
			SPRITE("commonmenu", "common_medal", 0.8700, (optionCount * 0.035f + 0.1413f), 0.03, 0.04, 0, 0, 0, 0, 255);
			SPRITE("commonmenu", "common_medal", 0.8700, (optionCount * 0.035f + 0.1413f), 0.02, 0.03, 0, 255, 0, 0, 150);
		}
	}
	else if ((optionCount > (currentOption - maxOptions)) && optionCount <= currentOption)
	{
		DRAW_TEXT_OPTION(option, 4, Cunt + sel, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);
		if (!IS_STRING_NULL_OR_EMPTY(button1) && !IS_STRING_NULL_OR_EMPTY(button2))
		{
			DRAW_TEXT_OPTION("+", 4, 0.8050, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.68000000, 0.49000000, 255, false, false, 0, 0, 0);

			if (ARE_STRINGS_EQUAL(button1, buttonR1) || ARE_STRINGS_EQUAL(button1, buttonL1))
			{
				SPRITE("erootiik", button1, 0.7900, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.140f), 0.01500000, 0.02500000, 0, 255, 255, 255, 255);
			}
			else
			{
				SPRITE("erootiik", button1, 0.7900, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.140f), 0.01500000, 0.02200000, 0, 255, 255, 255, 255);
			}

			if (ARE_STRINGS_EQUAL(button2, buttonR1) || ARE_STRINGS_EQUAL(button2, buttonL1))
			{
				SPRITE("erootiik", button2, 0.8300, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.140f), 0.01500000, 0.02500000, 0, 255, 255, 255, 255);
			}
			else
			{
				SPRITE("erootiik", button2, 0.8300, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.140f), 0.01500000, 0.02200000, 0, 255, 255, 255, 255);
			}
		}
		if (BOOL)
		{
			SPRITE("commonmenu", "common_medal", 0.8700, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.1413f), 0.03, 0.04, 0, 0, 0, 0, 255);
			SPRITE("commonmenu", "common_medal", 0.8700, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.1413f), 0.02, 0.03, 0, 0, 255, 0, 150);
		}
		else
		{
			SPRITE("commonmenu", "common_medal", 0.8700, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.1413f), 0.03, 0.04, 0, 0, 0, 0, 255);
			SPRITE("commonmenu", "common_medal", 0.8700, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.1413f), 0.02, 0.03, 0, 255, 0, 0, 150);
		}
	}
}

void ChangeMenu(int Menu)
{
	lastNumMenu[NumMenuLevel] = NumMenu;
	lastOption[NumMenuLevel] = currentOption;
	currentOption = 1;
	NumMenu = Menu;
	NumMenuLevel++;
}

void FolderOption(char *option, int Menu)
{
	addOption(option);
	if (currentOption == optionCount)
	{
		if (PressX == true)
		{
			ChangeMenu(Menu);
			PressX = false;
		}
	}
}

void FolderVehOption(char *option, int Menu, char *info)
{
	addOption(option);
	if (currentOption == optionCount)
	{
		if (PressX == true)
		{
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				ChangeMenu(Menu);
				PressX = false;
			}
			else
			{
				print("~r~You are not in a Vehicle..", 2000);
			}
		}
	}
}

void FolderOption2(char *option, int Menu, char *info)
{
	addOption(option);
	if (currentOption == optionCount)
	{
		if (PressX == true)
		{
			if (ARE_STRINGS_EQUAL(option, "**Not Connected**") == false)
			{
				selected_player = currentOption - 1;
				ChangeMenu(Menu);
			}
			else
			{
				print("~r~Player not Connected ..", 2000);
			}
			PressX = false;
		}
	}
}

void FolderPlayerOption(char *option, int player, int Menu)
{
	optionCount++;
	SET_TEXT_OUTLINE();
	float sel;
	if (currentOption == optionCount)
		sel = .012;
	else
		sel = 0;

	if (currentOption <= maxOptions && optionCount <= maxOptions)
	{
		if (ARE_STRINGS_EQUAL(option, "**Not Connected**") == false)
		{
			int pid = GET_PLAYER_PED(player);
			char *img = GET_PEDHEADSHOT_TXD_STRING(REGISTER_PEDHEADSHOT(pid));
			if (IS_PEDHEADSHOT_READY(REGISTER_PEDHEADSHOT(pid)) == true)
			{
				DRAW_TEXT_OPTION(option, 4, CuntPl + sel + 0.005, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);
				SPRITE(img, img, Cunt + 0.009 + sel + 0.005, (optionCount * 0.035f + 0.141f + 0.0001), 0.025f, 0.031f + 0.003f, 0, 255, 255, 255, 255);
			}
			else
			{
				DRAW_TEXT_OPTION(option, 4, Cunt + sel, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);
			}
		}
		else
		{
			DRAW_TEXT_OPTION(option, 4, Cunt + sel, (optionCount * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);
		}
	}
	else if ((optionCount > (currentOption - maxOptions)) && optionCount <= currentOption)
	{
		if (ARE_STRINGS_EQUAL(option, "**Not Connected**") == false)
		{
			int pid = GET_PLAYER_PED(player);
			char *img = GET_PEDHEADSHOT_TXD_STRING(REGISTER_PEDHEADSHOT(pid));
			if (IS_PEDHEADSHOT_READY(REGISTER_PEDHEADSHOT(pid)) == true)
			{
				DRAW_TEXT_OPTION(option, 4, CuntPl + sel + 0.005, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);
				SPRITE(img, img, Cunt + 0.009 + sel + 0.005, (optionCount * 0.035f + 0.141f + 0.0001), 0.025f, 0.031f + 0.003f, 0, 255, 255, 255, 255);
			}
			else
			{
				DRAW_TEXT_OPTION(option, 4, Cunt + sel, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);
			}
		}
		else
		{
			DRAW_TEXT_OPTION(option, 4, Cunt + sel, ((optionCount - (currentOption - maxOptions)) * 0.035f + 0.123f), 0.49000000, 0.49000000, 255, false, false, 0, 0, 0);
		}
	}

	if (currentOption == optionCount)
	{
		if (PressX == true)
		{
			if (ARE_STRINGS_EQUAL(option, "**Not Connected**") == false)
			{
				selected_player = currentOption - 2;
				ChangeMenu(Menu);
			}
			else
			{
				print("~r~Player not Connected ..", 2000);
			}
			PressX = false;
		}
	}
}

bool delayed_key_press(int control)
{
	if (GET_GAME_TIMER() - lastButtonPress < buttonPressDelay)
	{
		return false;
	}

	if (IS_DISABLED_CONTROL_PRESSED(2, control) == true) 
	{
		lastButtonPress = GET_GAME_TIMER();
		return true;
	}
	return false;
}

int GET()
{
	if (PressX == true)
	{
		return currentOption;
		PressX = false;
	}
	else return 0;
}

void SetupButtons()
{
	if (NumMenu == Closed)
	{
		if (IS_CONTROL_PRESSED(2, INPUT_SCRIPT_LS) && IS_CONTROL_PRESSED(2, INPUT_FRONTEND_ACCEPT))
		{
			WAIT(50);
			NumMenu = Main_Menu;
			NumMenuLevel = 0;
			currentOption = 1;
		}
	}
	else 
	{
		if (IS_DISABLED_CONTROL_JUST_PRESSED(2, INPUT_FRONTEND_CANCEL))
		{
			if (NumMenu == Main_Menu)
			{
				NumMenu = Closed;
			}
			else 
			{
				NumMenu = lastNumMenu[NumMenuLevel - 1];
				currentOption = lastOption[NumMenuLevel - 1];
				NumMenuLevel--;
				PLAY_SOUND_FRONTEND(-1, "BACK", "HUD_FRONTEND_DEFAULT_SOUNDSET");
			}
		}
		else if (IS_DISABLED_CONTROL_JUST_PRESSED(2, INPUT_FRONTEND_ACCEPT))
		{
			PressX = true;
			PLAY_SOUND_FRONTEND(-1, "SELECT", "HUD_FRONTEND_DEFAULT_SOUNDSET");
		}
		else if (delayed_key_press(INPUT_FRONTEND_UP) == true)
		{
			currentOption--;
			if (currentOption < 1)
			{
			    currentOption = optionCount;
			}
			PLAY_SOUND_FRONTEND(-1, "NAV_UP_DOWN", "HUD_FRONTEND_DEFAULT_SOUNDSET");
		}
		else if (delayed_key_press(INPUT_FRONTEND_DOWN) == true)
		{
			currentOption++;
			if (currentOption > optionCount)
			{
				currentOption = 1;
			}
			PLAY_SOUND_FRONTEND(-1, "NAV_UP_DOWN", "HUD_FRONTEND_DEFAULT_SOUNDSET");
		}
	}
}

void drawarrows2(bool one)
{
	int screenResolutionX, screenResolutionY;
	GET_SCREEN_RESOLUTION(&screenResolutionX, &screenResolutionY);
	vector3 textureResolution = GET_TEXTURE_RESOLUTION("CommonMenu", "shop_arrows_upANDdown");
	if (one)
	    SPRITE("CommonMenu", "shop_arrows_upANDdown", 0.734 + 0.103, ((maxOptions + 1) * 0.035f + 0.141f), (float)textureResolution.x / screenResolutionX, (float)textureResolution.y / screenResolutionY, 0, 255, 170, 0, 255);
	else
		SPRITE("CommonMenu", "shop_arrows_upANDdown", 0.734 + 0.103, ((optionCount + 1) * 0.035f + 0.141f), (float)textureResolution.x / screenResolutionX, (float)textureResolution.y / screenResolutionY, 0, 255, 170, 0, 255);
}

float conv360(float base, float min, float max) 
{
    float fVar0;
    if (min == max) return min;
    fVar0 = max - min;
    base -= ROUND(base - min / fVar0) * fVar0;
    if (base < min) base += fVar0;
    return base;
}

void drawGlare(float pX, float pY, float sX , float sY, int r, int g, int b) 
{
    gGlareHandle = REQUEST_SCALEFORM_MOVIE("MP_MENU_GLARE");
	vector3 rot = GET_GAMEPLAY_CAM_ROT(2);
	float dir = conv360(rot.z, 0, 360);
	if ((gGlareDir == 0 || gGlareDir - dir > 0.5) || gGlareDir - dir < -0.5)
	{
		gGlareDir = dir;
		_PUSH_SCALEFORM_MOVIE_FUNCTION(gGlareHandle, "SET_DATA_SLOT");
		_PUSH_SCALEFORM_MOVIE_FUNCTION_PARAMETER_FLOAT(gGlareDir);
		_POP_SCALEFORM_MOVIE_FUNCTION_VOID();
	}
    DRAW_SCALEFORM_MOVIE(gGlareHandle, pX, pY, sX, sY, r, g, b, 255, 0);
}

void UpdateOP()
{
	if (NumMenu == OP_Mods || NumMenu == Online_Players)
	{
		Ped pl;
		char *nm;
		if (NumMenu == OP_Mods)
		{
			nm = GET_PLAYER_NAME(selected_player);
		}
		else if (NumMenu == Online_Players)
		{
			nm = GET_PLAYER_NAME(currentOption - 2);
		}

		if (ARE_STRINGS_EQUAL(nm, "**Invalid**") == false)
		{
			if (NumMenu == OP_Mods)
			{
				AddTitleOP(GET_PLAYER_NAME(selected_player));
				pl = GET_PLAYER_PED(selected_player);
				DRAW_RECT(Menu_OPX, 0.1171f, CenterDrawOP, .065, 15, 15, 15, 245); //header
				DRAW_RECT(Menu_OPX, (((10 * 0.033f) / 2) + 0.150f), CenterDrawOP, (10 * 0.033f), 5, 5, 5, 220); //body
				DRAW_RECT(Menu_OPX, (((10 + 1) * 0.033f) + 0.1320f), CenterDrawOP, 0.030f, 15, 15, 15, 245); //footer
				DRAW_RECT(Menu_OPX, (((10 + 1) * 0.033f) + 0.1476f), CenterDrawOP, .001406, 255, 170, 0, 255); //footer divisor orange bar
				DRAW_RECT(Menu_OPX, (((10 + 1) * 0.033f) + 0.1682f), CenterDrawOP, 0.040f, 15, 15, 15, 245); //subfooter

				AddSubTitleOP("Player Info");
			}
			else if (NumMenu == Online_Players && currentOption != 1)
			{
				AddTitleOP(GET_PLAYER_NAME(currentOption - 2));
				pl = GET_PLAYER_PED(currentOption - 2);
				DRAW_RECT(Menu_OPX, 0.1171f, CenterDrawOP, .065, 15, 15, 15, 245); //header
				DRAW_RECT(Menu_OPX, (((10 * 0.033f) / 2) + 0.150f), CenterDrawOP, (10 * 0.033f), 5, 5, 5, 220); //body
				DRAW_RECT(Menu_OPX, (((10 + 1) * 0.033f) + 0.1320f), CenterDrawOP, 0.030f, 15, 15, 15, 245); //footer
				DRAW_RECT(Menu_OPX, (((10 + 1) * 0.033f) + 0.1476f), CenterDrawOP, .001406, 255, 170, 0, 255); //footer divisor orange bar
				DRAW_RECT(Menu_OPX, (((10 + 1) * 0.033f) + 0.1682f), CenterDrawOP, 0.040f, 15, 15, 15, 245); //subfooter

				AddSubTitleOP("Player Info");
			}

#pragma region VehInfo
			const char *vehn;
			if (IS_PED_IN_ANY_VEHICLE(pl, false))
			{
				Vehicle currv = GET_VEHICLE_PED_IS_USING(pl);
				Hash hash = GET_ENTITY_MODEL(currv);
				const char *vehnm = GET_DISPLAY_NAME_FROM_VEHICLE_MODEL(hash);
				while (ARE_STRINGS_EQUAL(vehnm, ""))
					WAIT(0);
				vehn = strcatGlobal("Vehicle - ", _GET_LABEL_TEXT(vehnm));
			}
			else
			{
				vehn = "Vehicle - No Vehicle";
			}
			DRAW_TEXT_OPTION((char*)vehn, 4, CuntOP, (1 * 0.033f + 0.116f + 0.0009), 0.44000000, 0.44000000, 255, false, false, 0, 0, 0);

			int a;
			const char *vehc;
			if (IS_PED_IN_ANY_VEHICLE(pl, false))
			{
				Vehicle currv = GET_VEHICLE_PED_IS_USING(pl);
				a = GET_VEHICLE_CLASS(currv);
				vehc = strcatGlobal("Vehicle Class - ", vehicleClass[a]);
			}
			else
			{
				vehc = "Vehicle Class - N.A.";
			}
			DRAW_TEXT_OPTION((char*)vehc, 4, CuntOP, (2 * 0.033f + 0.116f + 0.0009), 0.44000000, 0.44000000, 255, false, false, 0, 0, 0);
#pragma endregion

#pragma region PlayerInfo
			vector3 coord = GET_ENTITY_COORDS(pl, true);
			const char *zone = _GET_LABEL_TEXT(GET_NAME_OF_ZONE(coord));
			DRAW_TEXT_OPTION("Position -", 4, CuntOP, (3 * 0.033f + 0.116f + 0.0009), 0.44000000, 0.44000000, 255, false, false, 0, 0, 0);
			DRAW_TEXT_OPTION((char*)zone, 4, CuntOP + 0.04 - 0.003, (3 * 0.033f + 0.116f + 0.0009), 0.44000000, 0.44000000, 255, false, false, 0, 0, 0);

			vector3 mycoord = GET_ENTITY_COORDS(PLAYER_PED_ID(), true);
			int dist = (int)VDIST(coord, mycoord);
			const char *strdist;
			const char *distres;
			strdist = itosGlobal(dist);
			distres = strcatGlobal(strdist, " Meters");
			DRAW_TEXT_OPTION("Distance -", 4, CuntOP, (4 * 0.033f + 0.116f + 0.0009), 0.44000000, 0.44000000, 255, false, false, 0, 0, 0);
			DRAW_TEXT_OPTION((char*)distres, 4, CuntOP + 0.04 - 0.001, (4 * 0.033f + 0.116f + 0.0009), 0.44000000, 0.44000000, 255, false, false, 0, 0, 0);

			int hlt = -1;
			hlt = GET_ENTITY_HEALTH(pl);
			while (hlt == -1) WAIT(0);
			const char *hltconv;
			const char *hltres;
			hltconv = itosGlobal(hlt);
			hltres = strcatGlobal(hltconv, " / 238");
			DRAW_TEXT_OPTION("Health -", 4, CuntOP, (5 * 0.033f + 0.116f + 0.0009), 0.44000000, 0.44000000, 255, false, false, 0, 0, 0);
			DRAW_TEXT_OPTION((char*)hltres, 4, CuntOP + 0.04 - 0.009, (5 * 0.033f + 0.116f + 0.0009), 0.44000000, 0.44000000, 255, false, false, 0, 0, 0);

			int arm = -1;
			arm = GET_PED_ARMOUR(pl);
			while (arm == -1) WAIT(0);
			const char *armvalue;
			const char *armres;
			armvalue = itosGlobal((int)arm);
			armres = strcatGlobal(armvalue, " / 100");
			DRAW_TEXT_OPTION("Armour -", 4, CuntOP, (6 * 0.033f + 0.116f + 0.0009), 0.44000000, 0.44000000, 255, false, false, 0, 0, 0);
			DRAW_TEXT_OPTION((char*)armres, 4, CuntOP + 0.04 - 0.005 - 0.0003, (6 * 0.033f + 0.116f + 0.0009), 0.44000000, 0.44000000, 255, false, false, 0, 0, 0);

			const char* armed;
			if (IS_PED_ARMED(pl, 7))
				armed = "Yes";
			else armed = "No";
			const char *hasw;
			hasw = strcatGlobal("Is Armed - ", armed);

			const char *nameweapon;
			if (ARE_STRINGS_EQUAL(armed, "Yes"))
			{
				Hash weaped = GET_SELECTED_PED_WEAPON(pl);
				nameweapon = GET_WEAPON_NAME_FROM_HASH(weaped);

			}
			else
			{
				nameweapon = "Not Armed";
			}

			const char *wnamestr;
			wnamestr = strcatGlobal("Weapon - ", nameweapon);
			DRAW_TEXT_OPTION((char*)wnamestr, 4, CuntOP, (7 * 0.033f + 0.116f + 0.0009), 0.44000000, 0.44000000, 255, false, false, 0, 0, 0);

			int stars = GET_PLAYER_WANTED_LEVEL(pl);
			const char *starsvalue;
			const char *starsres;
			starsvalue = itosGlobal(stars);
			starsres = strcatGlobal(starsvalue, " / 5");
			DRAW_TEXT_OPTION("Wanted Level -", 4, CuntOP, (8 * 0.033f + 0.116f + 0.0009), 0.44000000, 0.44000000, 255, false, false, 0, 0, 0);
			DRAW_TEXT_OPTION((char*)starsres, 4, CuntOP + 0.06 - 0.004, (8 * 0.033f + 0.116f + 0.0009), 0.44000000, 0.44000000, 255, false, false, 0, 0, 0);
			
			const char *genre;
			Hash male = GET_HASH_KEY("mp_m_freemode_01");
			Hash female = GET_HASH_KEY("mp_f_freemode_01");
			if (GET_ENTITY_MODEL(pl) == male)
				genre = "Male";
			else if (GET_ENTITY_MODEL(pl) == female)
				genre = "Female";
			else
				genre = "Modded";
			const char *genreres;
			genreres = strcatGlobal("Model - ", genre);
			DRAW_TEXT_OPTION((char*)genreres, 4, CuntOP, (9 * 0.033f + 0.116f + 0.0009), 0.44000000, 0.44000000, 255, false, false, 0, 0, 0);

			int actspeed = (int)(GET_ENTITY_SPEED(pl) * 3.3) * 1.609344;
			const char *strspd;
			const char *spdres;
			strspd = itosGlobal(actspeed);
			spdres = strcatGlobal(strspd, " Km/h");
			DRAW_TEXT_OPTION("Speed -", 4, CuntOP, (10 * 0.033f + 0.116f + 0.0009), 0.44000000, 0.44000000, 255, false, false, 0, 0, 0);
			DRAW_TEXT_OPTION((char*)spdres, 4, CuntOP + 0.03, (10 * 0.033f + 0.116f + 0.0009), 0.44000000, 0.44000000, 255, false, false, 0, 0, 0);
#pragma endregion
		}
	}
	
}

void SetupActions()
{
	if (IS_HELP_MESSAGE_ON_SCREEN())
	{
		NumMenu = Closed;
		CLEAR_HELP(1);
		CLEAR_ALL_HELP_MESSAGES();
	}
	if (IS_HELP_MESSAGE_FADING_OUT())
	{
		NumMenu = Closed;
	}
	if (IS_PAUSE_MENU_ACTIVE())
	{
		NumMenu = Closed;
	}

#pragma region controls
	DISABLE_CONTROL_ACTION(0, 19);
	DISABLE_CONTROL_ACTION(0, 20);
	DISABLE_CONTROL_ACTION(0, 21);
	DISABLE_CONTROL_ACTION(0, 27);
	DISABLE_CONTROL_ACTION(0, 54);
	DISABLE_CONTROL_ACTION(0, 123);
	DISABLE_CONTROL_ACTION(0, 124);
	DISABLE_CONTROL_ACTION(0, 125);
	DISABLE_CONTROL_ACTION(0, 126);
	DISABLE_CONTROL_ACTION(0, 138);
	DISABLE_CONTROL_ACTION(0, 139);
	DISABLE_CONTROL_ACTION(0, 140);
	DISABLE_CONTROL_ACTION(0, 177);
	DISABLE_CONTROL_ACTION(0, 178);
	DISABLE_CONTROL_ACTION(0, 179);
	DISABLE_CONTROL_ACTION(0, 207);
	SET_INPUT_EXCLUSIVE(2, 166);
	SET_INPUT_EXCLUSIVE(2, 167);
	SET_INPUT_EXCLUSIVE(2, 177);
	SET_INPUT_EXCLUSIVE(2, 178);
	SET_INPUT_EXCLUSIVE(2, 193);
	SET_INPUT_EXCLUSIVE(2, 194);
	SET_INPUT_EXCLUSIVE(2, 195);
	SET_INPUT_EXCLUSIVE(2, 202);
	SET_INPUT_EXCLUSIVE(2, 203);
	SET_INPUT_EXCLUSIVE(2, 204);
	SET_INPUT_EXCLUSIVE(2, 205);
#pragma endregion

	if (IS_PAUSE_MENU_ACTIVE())
	{
		NumMenu = Closed;
    }

	DRAW_RECT(Menu_X, 0.1220f, .260, .074, 15, 15, 15, 245); //header
	drawGlare(GlareX - .059 + 0.0003f, GlareY, 0.88, 0.82, 255, 255, 255); //glare
	if (IS_GAMEPLAY_HINT_ACTIVE())
	{
		STOP_GAMEPLAY_HINT(0);
		_STOP_SCREEN_EFFECT("FocusIn");
	}
	if (optionCount > maxOptions)
	{
		DRAW_RECT(Menu_X, (((maxOptions * 0.035f) / 2) + 0.159f), CenterDraw, (maxOptions * 0.035f), 5, 5, 5, 220); //body
		if (currentOption > maxOptions)
		{
			SPRITE("timerbars", "all_white_bg", 0.8767, ((maxOptions *  0.035f) + 0.1416f), 0.5000, 0.0330f, 180, 255, 170, 0, 255); //scroller
			SPRITE("commonmenu", "arrowright", Cunt + .004, ((maxOptions *  0.035f) + 0.140f + .001), .026, .022, 0, 15, 15, 15, 255); //pointer
		}
		else
		{
			SPRITE("timerbars", "all_white_bg", 0.8767, ((currentOption *  0.035f) + 0.1416f), 0.5000, 0.0330f, 180, 255, 170, 0, 255); //scroller
			SPRITE("commonmenu", "arrowright", Cunt + .004, ((currentOption *  0.035f) + 0.140f + .001), .026, .022, 0, 15, 15, 15, 255); //pointer
		}
	}
	else
	{
		DRAW_RECT(Menu_X, (((optionCount * 0.035f) / 2) + 0.159f), CenterDraw, (optionCount * 0.035f), 5, 5, 5, 220); //body
		SPRITE("timerbars", "all_white_bg", 0.8767, ((currentOption *  0.035f) + 0.1416f), 0.5000, 0.0330f, 180, 255, 170, 0, 255); //scroller
		SPRITE("commonmenu", "arrowright", Cunt + .004, ((currentOption *  0.035f) + 0.140f + .001), .026, .022, 0, 15, 15, 15, 15); //pointer
	}
	if (NumMenu != Closed)
	{
		if (optionCount > maxOptions)
		{
			DRAW_TEXT("v2.4.4", 1, 0.714 + 0.100, ((maxOptions + 1) * 0.035f + 0.128f), 0.4f, 0.4f, 255, 170, 0, 255, false, false, 0, 0, 0);
		    DRAW_TEXT(GET_PLAYER_NAME(PLAYER_ID()), 1, 0.758 - 0.125, ((maxOptions + 1) * 0.035f + 0.122f), 0.5f, 0.5f, 255, 170, 0, 255, false, false, 0, 0, 0);
		    draw_item_count(0.758 + 0.109, ((maxOptions + 1) * 0.035f + 0.125f), 0.5f, 0.5f);
		    DRAW_RECT(Menu_X, (((maxOptions + 1) * 0.035f) + 0.1415f), CenterDraw, 0.035f, 15, 15, 15, 245); //footer
			//drawarrows2(true);
			DRAW_RECT(Menu_X, (((maxOptions + 1) * 0.035f) + 0.1600f), CenterDraw, .001406, 255, 170, 0, 255); //footer divisor orange bar
			DRAW_RECT(Menu_X, (((maxOptions + 1) * 0.035f) + 0.1800f), CenterDraw, 0.039f, 15, 15, 15, 245); //subfooter
			SPRITE("commonmenu", "arrowright", Cunt + .004, ((maxOptions *  0.035f) + 0.140f + .001), .026, .022, 0, 15, 15, 15, 255); //pointer
			
			if (NumMenu == Self_Mods && currentOption == 5)
			{
				DRAW_RECT(Menu_X, (((optionCount - 4) * 0.035f) + 0.0450f), CenterDraw, 0.039f, 15, 15, 15, 245); //subsubfooter help
				DRAW_RECT(Menu_X, (((optionCount - 4) * 0.035f) + 0.0300f - 0.005), CenterDraw, .001406, 255, 170, 0, 255); //subsubfooter divisor orange bar help
				DRAW_TEXT2("R1 launch - R2 fly - L2 levitate", 1, Title_X, ((maxOptions + 1) * 0.035f + 0.202f), 0.49000000, 0.49000000, 255, 170, 0, 255, true);
			}
			if (NumMenu == Self_Mods && currentOption == 16)
			{
				DRAW_RECT(Menu_X, (((optionCount - 4) * 0.035f) + 0.0450f), CenterDraw, 0.039f, 15, 15, 15, 245); //subsubfooter help
				DRAW_RECT(Menu_X, (((optionCount - 4) * 0.035f) + 0.0300f - 0.005), CenterDraw, .001406, 255, 170, 0, 255); //subsubfooter divisor orange bar help
				DRAW_TEXT2("Explode any Player who aims you", 1, Title_X, ((maxOptions + 1) * 0.035f + 0.202f), 0.49000000, 0.49000000, 255, 170, 0, 255, true);
			}
			if (NumMenu == Vehicle_Mods && currentOption == 12)
			{
				DRAW_RECT(Menu_X, (((optionCount + 2) * 0.035f) + 0.0780f), CenterDraw, 0.039f, 15, 15, 15, 245); //subsubfooter help
				DRAW_RECT(Menu_X, (((optionCount + 2) * 0.035f) + 0.0630f - 0.005), CenterDraw, .001406, 255, 170, 0, 255); //subsubfooter divisor orange bar help
				DRAW_TEXT2("Press Square to Jump", 1, Title_X, ((maxOptions + 1) * 0.035f + 0.201f), 0.49000000, 0.49000000, 255, 170, 0, 255, true);
			}
			if (NumMenu == Vehicle_Mods && currentOption == 13)
			{
				DRAW_RECT(Menu_X, (((optionCount + 2) * 0.035f) + 0.0780f), CenterDraw, 0.039f, 15, 15, 15, 245); //subsubfooter help
				DRAW_RECT(Menu_X, (((optionCount + 2) * 0.035f) + 0.0630f - 0.005), CenterDraw, .001406, 255, 170, 0, 255); //subsubfooter divisor orange bar help
				DRAW_TEXT2("Hold X to open the NOS", 1, Title_X, ((maxOptions + 1) * 0.035f + 0.202f), 0.49000000, 0.49000000, 255, 170, 0, 255, true);
			}
			if (NumMenu == Vehicle_Mods && currentOption == 14)
			{
				DRAW_RECT(Menu_X, (((optionCount + 2) * 0.035f) + 0.0780f), CenterDraw, 0.039f, 15, 15, 15, 245); //subsubfooter help
				DRAW_RECT(Menu_X, (((optionCount + 2) * 0.035f) + 0.0630f - 0.005), CenterDraw, .001406, 255, 170, 0, 255); //subsubfooter divisor orange bar help
				DRAW_TEXT2("Press L3 to Stop the Vehicle", 1, Title_X, ((maxOptions + 1) * 0.035f + 0.202f), 0.49000000, 0.49000000, 255, 170, 0, 255, true);
			}
		}
		else
		{
			DRAW_TEXT("v2.4.4", 1, 0.714 + 0.100, ((optionCount + 1) * 0.035f + 0.128f), 0.4f, 0.4f, 255, 170, 0, 255, false, false, 0, 0, 0);
		    DRAW_TEXT(GET_PLAYER_NAME(PLAYER_ID()), 1, 0.758 - 0.125, ((optionCount + 1) * 0.035f + 0.122f), 0.5f, 0.5f, 255, 170, 0, 255, false, false, 0, 0, 0);
		    draw_item_count(0.758 + 0.109, ((optionCount + 1) * 0.035f + 0.125f), 0.5f, 0.5f);
		    DRAW_RECT(Menu_X, (((optionCount + 1) * 0.035f) + 0.1415f), CenterDraw, 0.035f, 15, 15, 15, 245); //footer
			//drawarrows2(false);
			SPRITE("commonmenu", "arrowright", Cunt + .004, ((currentOption *  0.035f) + 0.140f + .001), .026, .022, 0, 15, 15, 15, 255); //pointer
			
			if (NumMenu == Recovery_Scripts)
			{
				DRAW_RECT(Menu_X, (((optionCount + 1) * 0.035f) + 0.1597f), CenterDraw, .001406, 255, 170, 0, 255); //footer divisor orange bar
				DRAW_RECT(Menu_X, (((optionCount + 1) * 0.035f) + 0.1797f), CenterDraw, 0.039f, 15, 15, 15, 245); //subfooter
			}
			else if (NumMenu == Cyber_Menu || NumMenu == Main_Scripts || NumMenu == Wheels_Type)
			{
				DRAW_RECT(Menu_X, (((optionCount + 1) * 0.035f) + 0.1597f), CenterDraw, .001406, 255, 170, 0, 255); //footer divisor orange bar
				DRAW_RECT(Menu_X, (((optionCount + 1) * 0.035f) + 0.1798f), CenterDraw, 0.039f, 15, 15, 15, 245); //subfooter
			}
			else
			{
				DRAW_RECT(Menu_X, (((optionCount + 1) * 0.035f) + 0.1598f), CenterDraw, .001406, 255, 170, 0, 255); //footer divisor orange bar
				DRAW_RECT(Menu_X, (((optionCount + 1) * 0.035f) + 0.1798f), CenterDraw, 0.039f, 15, 15, 15, 245); //subfooter
			}

			if (NumMenu == Self_Mods && currentOption == 5)
			{
				DRAW_RECT(Menu_X, (((optionCount - 4) * 0.035f) + 0.0450f), CenterDraw, 0.039f, 15, 15, 15, 245); //subsubfooter help
				DRAW_RECT(Menu_X, (((optionCount - 4) * 0.035f) + 0.0300f - 0.005), CenterDraw, .001406, 255, 170, 0, 255); //subsubfooter divisor orange bar help
				DRAW_TEXT2("R1 launch - R2 fly - L2 levitate", 1, Title_X, ((optionCount + 1) * 0.035f + 0.242f), 0.49000000, 0.49000000, 255, 170, 0, 255, true);
			}
			if (NumMenu == Self_Mods && currentOption == 16)
			{
				DRAW_RECT(Menu_X, (((optionCount - 4) * 0.035f) + 0.0450f), CenterDraw, 0.039f, 15, 15, 15, 245); //subsubfooter help
				DRAW_RECT(Menu_X, (((optionCount - 4) * 0.035f) + 0.0300f - 0.005), CenterDraw, .001406, 255, 170, 0, 255); //subsubfooter divisor orange bar help
				DRAW_TEXT2("Explode any Player who aims you", 1, Title_X, ((optionCount + 1) * 0.035f + 0.242f), 0.49000000, 0.49000000, 255, 170, 0, 255, true);
			}
			if (NumMenu == Vehicle_Mods && currentOption == 12)
			{
				DRAW_RECT(Menu_X, (((optionCount + 2) * 0.035f) + 0.0780f), CenterDraw, 0.039f, 15, 15, 15, 245); //subsubfooter help
				DRAW_RECT(Menu_X, (((optionCount + 2) * 0.035f) + 0.0630f - 0.005), CenterDraw, .001406, 255, 170, 0, 255); //subsubfooter divisor orange bar help
				DRAW_TEXT2("Press Square to Jump", 1, Title_X, ((optionCount + 1) * 0.035f + 0.211f), 0.49000000, 0.49000000, 255, 170, 0, 255, true);
			}
			if (NumMenu == Vehicle_Mods && currentOption == 13)
			{
				DRAW_RECT(Menu_X, (((optionCount + 2) * 0.035f) + 0.0780f), CenterDraw, 0.039f, 15, 15, 15, 245); //subsubfooter help
				DRAW_RECT(Menu_X, (((optionCount + 2) * 0.035f) + 0.0630f - 0.005), CenterDraw, .001406, 255, 170, 0, 255); //subsubfooter divisor orange bar help
				DRAW_TEXT2("Hold X to Open the NOS", 1, Title_X, ((optionCount + 1) * 0.035f + 0.238f), 0.49000000, 0.49000000, 255, 170, 0, 255, true);
			}
			if (NumMenu == Vehicle_Mods && currentOption == 14)
			{
				DRAW_RECT(Menu_X, (((optionCount + 2) * 0.035f) + 0.0780f), CenterDraw, 0.039f, 15, 15, 15, 245); //subsubfooter help
				DRAW_RECT(Menu_X, (((optionCount + 2) * 0.035f) + 0.0630f - 0.005), CenterDraw, .001406, 255, 170, 0, 255); //subsubfooter divisor orange bar help
				DRAW_TEXT2("Press L3 to Stop the Vehicle", 1, Title_X, ((optionCount + 1) * 0.035f + 0.238f), 0.49000000, 0.49000000, 255, 170, 0, 255, true);
			}
	    }

		UpdateOP();
	}
}

void Setup_System()
{
	PressX = false;
	rightPress = false;
	leftPress = false;
}

#pragma region func
void SuperMan_Function()
{
	if (supman == true)
	{
		float r2force;
		float lyforce;
		if (supermanmultip == 1)
		{
			r2force = 0.0050f;
			lyforce = 0.0101f;
		}
		else if (supermanmultip == 2)
		{
			r2force = 0.0173f;
			lyforce = 0.0131f;
		}
		else if (supermanmultip == 3)
		{
			r2force = 0.15933f;
			lyforce = 0.0211f;
		}

		Ped playerPed = PLAYER_PED_ID();
		vector3 zero = { 0.0f, 0.0f, 0.0f };

		if (!HAS_PED_GOT_WEAPON(playerPed, 0xFBAB5776, 0))
		{
			GIVE_DELAYED_WEAPON_TO_PED(playerPed, 0xFBAB5776, 99999, true);
		}
		if (GET_PED_PARACHUTE_STATE(playerPed) == 0)
		{
			vector3 force;

			// get L2 R2 and left analog values and convert range of 0 to 254 to range of -127 to 127
			int L2 = GET_CONTROL_VALUE(0, 183) - 127;
			int R2 = GET_CONTROL_VALUE(0, 184) - 127;
			int LY = GET_CONTROL_VALUE(0, 189) - 127;
			int LX = GET_CONTROL_VALUE(0, 188) - 127;

			// steering
			float turn = 0.0012f * (float)LX;

			// cannot apply a rotation force without a directional force (I think?)
			// so apply offsetting directional forces that have compounding rotational force
			vector3 vec1 = { 0.0f, 1.0f, 0.0f };
			vector3 vec2 = { 0.0f, -1.0f, 0.0f };
			vector3 vec3 = { -turn, 0.0f, 0.0f };
			vector3 vec4 = { turn, 0.0f, 0.0f };
			APPLY_FORCE_TO_ENTITY(playerPed, 1, vec1, vec3, 0, 1, 1, 1, 1, 1);
			APPLY_FORCE_TO_ENTITY(playerPed, 1, vec2, vec4, 0, 1, 1, 1, 1, 1);

			// flying
			if (L2 > 0) // brakes applied - apply only non-relative force using inverse velocity and multipliers
			{
				vector3 vel = GET_ENTITY_VELOCITY(playerPed);

				// analog multiplier - for readability, can be compressed into shit below
				float brake = 0.0039f * (float)L2;

				force.x = -vel.x * brake;
				force.y = -vel.y * brake;
				force.z = (-vel.z * brake) + 0.25f; // 0.25f vertical bump to stop slow falling

				// apply calculated force
				APPLY_FORCE_TO_ENTITY(playerPed, 1, force, zero, 0, 0, 1, 1, 1, 1);
			}
			else // regular superman - force is relative - multipliers are confusing
			{
			    if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xC1) && NumMenu == Closed)
			    {
					force.x = 0.0f;
					force.y = 0.0f + ((float)R2 * r2force);
					force.z = 0.10f + ((float)LY * lyforce);

					if (LY > 0)
						force.z = force.z + force.y;

					APPLY_FORCE_TO_ENTITY(playerPed, 1, force, zero, 0, 1, 1, 1, 1, 1);
			    }
				else
				{
					force.x = 0.0f;
					force.y = 0.0f + ((float)R2 * r2force);
					force.z = 0.10f + ((float)LY * lyforce);

					// extra upward force if analog is being pulled back
					if (LY > 0)
						force.z = force.z + force.y;

					// apply calculated force
					APPLY_FORCE_TO_ENTITY(playerPed, 1, force, zero, 0, 1, 1, 1, 1, 1);
				}
			}
		}
		else
		{
			if (IS_PED_JUMPING(playerPed))// vertical boost while jumping (doesn't work in shallow water or mud?)
			{
				if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xC5))
				{
					vector3 vec5 = { 0.0f, 0.0f, 70.0f };
					APPLY_FORCE_TO_ENTITY(playerPed, 1, vec5, zero, 0, 0, 1, 1, 1, 1);
					TASK_PARACHUTE(playerPed, true);
				}
			}
			else if (IS_PED_SWIMMING(playerPed) || IS_ENTITY_IN_WATER(playerPed))// attempted vertical boost out of water (fails miserably)
			{
				if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xC2))
				{
					vector3 vec6 = { 0.0f, 0.0f, 70.0f };
					CLEAR_PED_TASKS_IMMEDIATELY(PLAYER_PED_ID());
					APPLY_FORCE_TO_ENTITY(playerPed, 1, vec6, zero, 0, 0, 1, 1, 1, 1);
					TASK_PARACHUTE(playerPed, true);
				}
			}
		}
	}
	else
	{

	}
}

void SuperRun_Func()
{
	if (run == true && NumMenu == Closed)
	{
		if (superr == 1)
		{
			if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xC1))
			{
				vector3 vec1 = { 0, 7, 0 };
				vector3 vec2 = { 0, 7, 0 };
				APPLY_FORCE_TO_ENTITY(PLAYER_PED_ID(), 1, vec1, vec2, 0, 1, 1, 1, 0, 1);
			}
		}
		else if (superr == 2)
		{
			if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xC1))
			{
				vector3 vec1 = { 0, 10, 0 };
				vector3 vec2 = { 0, 10, 0 };
				APPLY_FORCE_TO_ENTITY(PLAYER_PED_ID(), 1, vec1, vec2, 0, 1, 1, 1, 0, 1);
			}
		}
		else if (superr == 3)
		{
			if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xC1))
			{
				vector3 vec1 = { 0, 15, 0 };
				vector3 vec2 = { 0, 15, 0 };
				APPLY_FORCE_TO_ENTITY(PLAYER_PED_ID(), 1, vec1, vec2, 0, 1, 1, 1, 0, 1);
			}
		}
		else if (superr == 4)
		{
			if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xC1))
			{
				vector3 vec1 = { 0, 25, 0 };
				vector3 vec2 = { 0, 25, 0 };
				APPLY_FORCE_TO_ENTITY(PLAYER_PED_ID(), 1, vec1, vec2, 0, 1, 1, 1, 0, 1);
			}
		}
		else if (superr == 5)
		{
			if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xC1))
			{
				vector3 vec1 = { 0, 30, 0 };
				vector3 vec2 = { 0, 30, 0 };
				APPLY_FORCE_TO_ENTITY(PLAYER_PED_ID(), 1, vec1, vec2, 0, 1, 1, 1, 0, 1);
			}
		}
	}
	else
	{

	}
}

void SuperJump_Func()
{
	if (jump == true)
	{
		SET_SUPER_JUMP_THIS_FRAME(PLAYER_ID());
	}
	else
	{

	}
}

void ExplosiveAmmo_Func()
{
	if (expammo == true)
	{
		SET_EXPLOSIVE_AMMO_THIS_FRAME(PLAYER_ID());
	}
	else
	{

	}
}

void FireAmmo_Func()
{
	if (fireammo == true)
	{
		SET_FIRE_AMMO_THIS_FRAME(PLAYER_ID());
	}
	else
	{

	}
}

void IperJump_Func()
{
	if (ijump == true && NumMenu == Closed)
	{
		if (iperj == 1)
		{
			if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xC2) && !IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				vector3 vec = { 4, 0, 10 };
				vector3 vec2 = { 0, 0, 0 };
				APPLY_FORCE_TO_ENTITY(PLAYER_PED_ID(), 1, vec, vec2, 0, 1, 1, 1, 0, 1);
			}
		}
		else if (iperj == 2)
		{
			if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xC2) && !IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				vector3 vec = { 6, 0, 20 };
				vector3 vec2 = { 0, 0, 0 };
				APPLY_FORCE_TO_ENTITY(PLAYER_PED_ID(), 1, vec, vec2, 0, 1, 1, 1, 0, 1);
			}
		}
		else if (iperj == 3)
		{
			if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xC2) && !IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				vector3 vec = { 7, 0, 30 };
				vector3 vec2 = { 0, 0, 0 };
				APPLY_FORCE_TO_ENTITY(PLAYER_PED_ID(), 1, vec, vec2, 0, 1, 1, 1, 0, 1);
			}
		}
		else if (iperj == 4)
		{
			if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xC2) && !IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				vector3 vec = { 8, 0, 40 };
				vector3 vec2 = { 0, 0, 0 };
				APPLY_FORCE_TO_ENTITY(PLAYER_PED_ID(), 1, vec, vec2, 0, 1, 1, 1, 0, 1);
			}
		}
		else if (iperj == 5)
		{
			if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xC2) && !IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				vector3 vec = { 9, 0, 50 };
				vector3 vec2 = { 0, 0, 0 };
				APPLY_FORCE_TO_ENTITY(PLAYER_PED_ID(), 1, vec, vec2, 0, 1, 1, 1, 0, 1);
			}
		}
	}
	else
	{

	}
}

void NeverWant_Func()
{
	if (nocop == true)
	{
		SET_PLAYER_WANTED_LEVEL(PLAYER_ID(), 0, true);
		SET_PLAYER_WANTED_LEVEL_NOW(0, 0);
		SET_MAX_WANTED_LEVEL(0);
	}
	else
	{

	}
}

void Godmode_Func()
{
	if (godmode == true)
	{
		int ped = PLAYER_PED_ID();
		SET_PLAYER_INVINCIBLE(PLAYER_ID(), true);
		SET_ENTITY_INVINCIBLE(ped, true);
		int hlt = GET_ENTITY_HEALTH(ped);
		int arm = GET_PED_ARMOUR(ped);
		if (hlt < 150 && IS_ENTITY_DEAD(ped) == false)
		{
			SET_ENTITY_HEALTH(ped, 200);
		}
		if (arm < 70 && IS_ENTITY_DEAD(ped) == false)
		{
			SET_PED_ARMOUR(ped, 100);
		}
	}
}

void Boss_Func()
{
	if (bossmode == true)
	{
		for (int client = 0; client < 16; ++client)
		{
			if (IS_PLAYER_TARGETTING_ENTITY(client, PLAYER_PED_ID()))
			{
				Ped PED_ID = GET_PLAYER_PED(client);
				vector3 entityCoords = GET_ENTITY_COORDS(PED_ID, true);
				ADD_OWNED_EXPLOSION(PED_ID, entityCoords, 5, 0.5f, true, false, 5.0f);
			}
		}
	}
}

void SuperPunch_Func()
{
	if (supunch == true)
	{
		SET_EXPLOSIVE_MELEE_THIS_FRAME(PLAYER_ID());
	}
}

void SMoneyDrop_Func()
{
	if (simplemoneydrop == true)
	{
		vector3 coord = GET_ENTITY_COORDS(PLAYER_PED_ID(), true);
		CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 5000, 1, 0, 1);
	}
}

void GodmodeVeh_Func()
{
	if (godmodeveh == true)
	{
		Vehicle VehicleHandle = GET_VEHICLE_PED_IS_IN(PLAYER_PED_ID(), false);
		if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
		{
			if (_IS_VEHICLE_DAMAGED(VehicleHandle))
			{
				SET_VEHICLE_FIXED(VehicleHandle);
				SET_VEHICLE_DEFORMATION_FIXED(VehicleHandle);
				SET_VEHICLE_DIRT_LEVEL(VehicleHandle, 0);
			}
		}
		if (IS_PED_IN_VEHICLE(PLAYER_PED_ID(), VehicleHandle, false) == false)
		{
			SET_ENTITY_PROOFS(VehicleHandle, false, false, false, false, false, false, 1, false);
			godmodeveh = false;
		}
	}
	else
	{
		
	}
}

void StickGround_Func()
{
	if (stickground == true)
	{
		if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
		{
			SET_VEHICLE_ON_GROUND_PROPERLY(GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID()));
		}
	}
	else
	{

	}
}

void DoorsLoop_Func()
{
	if (doorsloop == true)
	{
		if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			int door = GET_RANDOM_INT_IN_RANGE(0, 6);
			int oors = GET_RANDOM_INT_IN_RANGE(0, 2);

			if (oors == 0)
			{
				SET_VEHICLE_DOOR_OPEN(veh, door, false, false);
			}
			else
			{
				SET_VEHICLE_DOOR_SHUT(veh, door, false);
			}
			doorsok = false;
		}
	}
	else
	{
		if (!doorsok)
		{
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
				SET_VEHICLE_DOOR_SHUT(veh, 0, false);
				SET_VEHICLE_DOOR_SHUT(veh, 1, false);
				SET_VEHICLE_DOOR_SHUT(veh, 2, false);
				SET_VEHICLE_DOOR_SHUT(veh, 3, false);
				SET_VEHICLE_DOOR_SHUT(veh, 4, false);
				SET_VEHICLE_DOOR_SHUT(veh, 5, false);
				SET_VEHICLE_DOOR_SHUT(veh, 6, false);
			}
			doorsok = true;
		}
	}
}

void Speedom_Func()
{
	if (speedom == true)
	{
		Entity ent;
		float rotkm;
		float rotmph;
		if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
		{
			ent = GET_VEHICLE_PED_IS_IN(PLAYER_PED_ID(), false);
		}
		else
		{
			ent = PLAYER_PED_ID();
		}
			float SpeedKm = (GET_ENTITY_SPEED(ent) * 3.3) * 1.609344;
			float SpeedMph = (GET_ENTITY_SPEED(ent) * 2.94);

			if (SpeedKm > 340)
				rotkm = 340;
			else rotkm = SpeedKm;

			if (SpeedMph > 340)
				rotmph = 340;
			else rotmph = SpeedMph;
			
			if (selSpeedom == 0)
			{
				SPRITE("speedometers", "land_race_icon", 0.3 + 0.045, 0.8 + 0.033, 0.2000, 0.3300f, 0, 255, 255, 255, 255);
				SPRITE("speedometers", "custom_icon", 0.3 + 0.045, 0.8 + 0.033, 0.1800, 0.2900f, rotkm, 255, 255, 255, 255);
			}
			else if (selSpeedom == 1)
			{
				SPRITE("speedometers", "land_race_icon", 0.3 + 0.045, 0.8 + 0.033, 0.2000, 0.3300f, 0, 255, 255, 255, 255);
				SPRITE("speedometers", "custom_icon", 0.3 + 0.045, 0.8 + 0.033, 0.1800, 0.2900f, rotmph, 255, 255, 255, 255);
			}
	}
	else
	{

	}
}

void TireLoop_Func()
{
	if (tiresmokeloop == true)
	{
		if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			TOGGLE_VEHICLE_MOD(veh, 20, 1);
			int rand = GET_RANDOM_INT_IN_RANGE(0, 8);

			SET_VEHICLE_TYRE_SMOKE_COLOR(veh, TyreColors[rand]);
		}
	}
	else
	{

	}
}

void ResprayLoop_Func()
{
	if (resprayloop == true)
	{
		if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
		{
			int r = GET_RANDOM_INT_IN_RANGE(0, 255);
			int g = GET_RANDOM_INT_IN_RANGE(0, 255);
			int b = GET_RANDOM_INT_IN_RANGE(0, 255);
			int r2 = GET_RANDOM_INT_IN_RANGE(0, 255);
			int g2 = GET_RANDOM_INT_IN_RANGE(0, 255);
			int b2 = GET_RANDOM_INT_IN_RANGE(0, 255);
			SET_VEHICLE_CUSTOM_PRIMARY_COLOUR(GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID()), r, g, b);
			SET_VEHICLE_CUSTOM_SECONDARY_COLOUR(GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID()), r2, g2, b2);
		}
	}
	else
	{

	}
}

void VehJumpLoop_Func()
{
	if (vehjump == true && NumMenu == Closed)
	{
		if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
		{
			if (vehj == 1)
			{
				if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xC2))
				{
					Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
					vector3 vec = { 0, 0, 5 };
					APPLY_FORCE_TO_ENTITY(veh, 1, vec, vec, 0, 1, 1, 1, 0, 1);
				}
			}
			else if (vehj == 2)
			{
				if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xC2))
				{
					Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
					vector3 vec = { 0, 0, 10 };
					APPLY_FORCE_TO_ENTITY(veh, 1, vec, vec, 0, 1, 1, 1, 0, 1);
				}
			}
			else if (vehj == 3)
			{
				if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xC2))
				{
					Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
					vector3 vec = { 0, 0, 15 };
					APPLY_FORCE_TO_ENTITY(veh, 1, vec, vec, 0, 1, 1, 1, 0, 1);
				}
			}
			else if (vehj == 4)
			{
				if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xC2))
				{
					Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
					vector3 vec = { 0, 0, 20 };
					APPLY_FORCE_TO_ENTITY(veh, 1, vec, vec, 0, 1, 1, 1, 0, 1);
				}
			}
			else if (vehj == 5)
			{
				if (IS_DISABLED_CONTROL_JUST_PRESSED(0, 0xC2))
				{
					Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
					vector3 vec = { 0, 0, 25 };
					APPLY_FORCE_TO_ENTITY(veh, 1, vec, vec, 0, 1, 1, 1, 0, 1);
				}
			}
		}
	}
	else
	{

	}
}

void NOS_Func()
{
	if (nosbind == true && NumMenu == Closed)
	{
		if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
		{
			if (vehnos == 1)
			{
				Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());

				if (IS_CONTROL_PRESSED(0, 0xC1) && NumMenu == Closed)
				{
					float vel = GET_ENTITY_SPEED(veh);
					_START_SCREEN_EFFECT("RaceTurbo", 0, 0);
					SET_VEHICLE_BOOST_ACTIVE(veh, true);
					SET_VEHICLE_FORWARD_SPEED(veh, vel + 0.8f);
				}
				else
				{
					_STOP_SCREEN_EFFECT("RaceTurbo");
					SET_VEHICLE_BOOST_ACTIVE(veh, false);
				}
			}
			else if (vehnos == 2)
			{
				Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());

				if (IS_CONTROL_PRESSED(0, 0xC1) && NumMenu == Closed)
				{
					float vel = GET_ENTITY_SPEED(veh);
					_START_SCREEN_EFFECT("RaceTurbo", 0, 0);
					SET_VEHICLE_BOOST_ACTIVE(veh, true);
					SET_VEHICLE_FORWARD_SPEED(veh, vel + 1.1f);
				}
				else
				{
					_STOP_SCREEN_EFFECT("RaceTurbo");
					SET_VEHICLE_BOOST_ACTIVE(veh, false);
				}
			}
			else if (vehnos == 3)
			{
				Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());

				if (IS_CONTROL_PRESSED(0, 0xC1) && NumMenu == Closed)
				{
					float vel = GET_ENTITY_SPEED(veh);
					_START_SCREEN_EFFECT("RaceTurbo", 0, 0);
					SET_VEHICLE_BOOST_ACTIVE(veh, true);
					SET_VEHICLE_FORWARD_SPEED(veh, vel + 1.5f);
				}
				else
				{
					_STOP_SCREEN_EFFECT("RaceTurbo");
					SET_VEHICLE_BOOST_ACTIVE(veh, false);
				}
			}
			else if (vehnos == 4)
			{
				Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());

				if (IS_CONTROL_PRESSED(0, 0xC1) && NumMenu == Closed)
				{
					float vel = GET_ENTITY_SPEED(veh);
					_START_SCREEN_EFFECT("RaceTurbo", 0, 0);
					SET_VEHICLE_BOOST_ACTIVE(veh, true);
					SET_VEHICLE_FORWARD_SPEED(veh, vel + 2.0f);
				}
				else
				{
					_STOP_SCREEN_EFFECT("RaceTurbo");
					SET_VEHICLE_BOOST_ACTIVE(veh, false);
				}
			}
			else if (vehnos == 5)
			{
				Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());

				if (IS_CONTROL_PRESSED(0, 0xC1) && NumMenu == Closed)
				{
					float vel = GET_ENTITY_SPEED(veh);
					_START_SCREEN_EFFECT("RaceTurbo", 0, 0);
					SET_VEHICLE_BOOST_ACTIVE(veh, true);
					SET_VEHICLE_FORWARD_SPEED(veh, vel + 3.5f);
				}
				else
				{
					_STOP_SCREEN_EFFECT("RaceTurbo");
					SET_VEHICLE_BOOST_ACTIVE(veh, false);
				}
			}
		}
	}
	else
	{

	}
}

void Stop_Func()
{
	if (stopbind == true)
	{
		if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());

			if (IS_DISABLED_CONTROL_PRESSED(0, 0xC8))
			{
				SET_VEHICLE_FORWARD_SPEED(veh, 0);
			}
		}
	}
	else
	{

	}
}

void TPtoPVeh(Vehicle veh)
{
	int numSeats = GET_VEHICLE_MAX_NUMBER_OF_PASSENGERS(veh);
	int SeatIndex = -1;
	int SeatFree;
	while (SeatIndex < numSeats)
	{
		if (IS_VEHICLE_SEAT_FREE(veh, SeatIndex))
			SeatFree = SeatIndex;
		break;
		SeatIndex++;
	}
	SET_PED_INTO_VEHICLE(PLAYER_PED_ID(), veh, SeatFree);
}

void Forcefield_Func()
{
	for (int i = 0; i < 18; i++)
	{
		if (playersforcefield[i] == true)
		{
			if (IS_PLAYER_DEAD(pedforcefield[selected_player]) == false)
			{
				vector3 vec = GET_ENTITY_COORDS(pedforcefield[selected_player], true);
				ADD_OWNED_EXPLOSION(pedforcefield[selected_player], vec, 5, 0.5f, true, true, 5.0f);
			}
		}
	}
}

void KeyboardVeh_Check()
{
	if (g_bKeyBoardDisplayed2)
	{
		if (UPDATE_ONSCREEN_KEYBOARD() == 1)
		{
			g_bKeyBoardDisplayed2 = false;

			Hash hash = GET_HASH_KEY((char*)GET_ONSCREEN_KEYBOARD_RESULT());

			if (IS_MODEL_IN_CDIMAGE(hash) && IS_MODEL_VALID(hash))
			{
				vector3 origin;
				REQUEST_MODEL(hash);
				while (!HAS_MODEL_LOADED(hash))
					WAIT(0);

				if (HAS_MODEL_LOADED(hash))
				{
					int ped_id = PLAYER_PED_ID();
					int old_vehicle = GET_VEHICLE_PED_IS_USING(ped_id);
					float speed = GET_ENTITY_SPEED(old_vehicle);
					if (old_vehicle) DELETE_VEHICLE(&old_vehicle);
					origin = GET_ENTITY_COORDS(ped_id, true);
					int new_vehicle = CREATE_VEHICLE(hash, origin, 0, 1, 0);
					if (new_vehicle)
					{
						SET_ENTITY_HEADING(new_vehicle, GET_ENTITY_HEADING(ped_id));
						SET_PED_INTO_VEHICLE(ped_id, new_vehicle, -1);
						SET_VEHICLE_ENGINE_ON(new_vehicle, 1, 1, 0);
						SET_VEHICLE_FORWARD_SPEED(new_vehicle, speed);
					}
				}
			}
			else
			{
				print("Vehicle not found..", 2000);
			}
		}
		else if (UPDATE_ONSCREEN_KEYBOARD() == 2)
		{
			/*nothing has to happen, it was cancelled.*/
			g_bKeyBoardDisplayed2 = false;
		}
		else if (UPDATE_ONSCREEN_KEYBOARD() == 3)
		{
			g_bKeyBoardDisplayed2 = false;
			print("~r~Something goes wrong..", 2000);
		}
	}
}

void KeyboardModel_Check()
{
	if (g_bKeyBoardDisplayed3)
	{
		if (UPDATE_ONSCREEN_KEYBOARD() == 1)
		{
			g_bKeyBoardDisplayed3 = false;

			Hash hash = GET_HASH_KEY((char*)GET_ONSCREEN_KEYBOARD_RESULT());

			if (IS_MODEL_IN_CDIMAGE(hash) && IS_MODEL_VALID(hash))
			{
				vector3 origin;
				REQUEST_MODEL(hash);
				while (!HAS_MODEL_LOADED(hash))
					WAIT(0);

				if (HAS_MODEL_LOADED(hash))
				{
					SET_PLAYER_MODEL(PLAYER_ID(), hash);
					SET_MODEL_AS_NO_LONGER_NEEDED(hash);
				}
			}
			else
			{
				print("Model not found..", 2000);
			}
		}
		else if (UPDATE_ONSCREEN_KEYBOARD() == 2)
		{
			/*nothing has to happen, it was cancelled.*/
			g_bKeyBoardDisplayed3 = false;
		}
		else if (UPDATE_ONSCREEN_KEYBOARD() == 3)
		{
			g_bKeyBoardDisplayed3 = false;
			print("~r~Something goes wrong..", 2000);
		}
	}
}

void telepWayp()
{
	if (TeleportWPLoop)
	{
		//thanks krank!
		Blip WaypointID = GET_FIRST_BLIP_INFO_ID(8);
		vector3 WaypointCoords = GET_BLIP_COORDS(WaypointID);
		vector3 coordos;
		int Entity;
		if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
		{
			Entity = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			// helicopters will bug here. Was lazy to fix that
		}
		else
		{
			Entity = PLAYER_PED_ID();
		}
		float ZAxis;


		if (WaypointCoords.x != 0 && WaypointCoords.y != 0)
		{
			SET_ENTITY_COORDS(Entity, WaypointCoords.x, WaypointCoords.y, WaypointCoords.z, true, true, true, true);
			ContinueWP = true;
		}
		if (ContinueWP)
		{
			coordos = GET_ENTITY_COORDS(Entity, true);
			SET_ENTITY_COORDS(Entity, coordos.x, coordos.y, coordos.z + 10.0f, true, true, true, true);

			//the tricks is working here i keep teleporting my entity and thats where all the magic is going ... as when you teleport your entity to your entity coords it lifts you up and up till ground found
		}

		if (GET_GROUND_Z_FOR_3D_COORD(coordos, &ZAxis, 0))
		{
			SET_ENTITY_COORDS(Entity, coordos.x, coordos.y, ZAxis + 1.0f, true, true, true, true);
			ZAxis = 0;
			TeleportWPLoop = false;
			ContinueWP = false;
		}
	}
}

void changeModel(const char *model)
{
	Hash hash = GET_HASH_KEY(model);

	if (IS_MODEL_IN_CDIMAGE(hash) && IS_MODEL_VALID(hash))
	{
		vector3 origin;
		REQUEST_MODEL(hash);
		while (!HAS_MODEL_LOADED(hash))
			WAIT(0);

		if (HAS_MODEL_LOADED(hash))
		{
			SET_PLAYER_MODEL(PLAYER_ID(), hash);
			SET_MODEL_AS_NO_LONGER_NEEDED(hash);
		}
	}
	else
	{
		print("An error occured..", 2000);
	}
}

void spawnVeh(Hash vehash)
{
	NETWORK_SET_SCRIPT_IS_SAFE_FOR_NETWORK_GAME();
	if (NETWORK_IS_GAME_IN_PROGRESS() && !NETWORK_GET_THIS_SCRIPT_IS_NETWORK_SCRIPT())
	{
		NETWORK_SET_THIS_SCRIPT_IS_NETWORK_SCRIPT(18, 0, -1);
		NETWORK_GET_SCRIPT_STATUS();
	}

	REQUEST_MODEL(vehash);
	while (!HAS_MODEL_LOADED(vehash))
		WAIT(0);
	
	RESERVE_NETWORK_MISSION_VEHICLES(1);
	int old_vehicle = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
	float speed = GET_ENTITY_SPEED(old_vehicle);
	if (old_vehicle != 0)
	{
		vector3 coord = GET_ENTITY_COORDS(old_vehicle, false);
		CLEAR_PED_TASKS_IMMEDIATELY(PLAYER_PED_ID());
		SET_VEHICLE_FORWARD_SPEED(old_vehicle, 0);
		SET_ENTITY_COORDS(old_vehicle, coord.x - 10.0f, coord.y - 2.0f, coord.z, 0, 0, 0, 0);
	}

	Vehicle veh = CREATE_VEHICLE(vehash, GET_ENTITY_COORDS(PLAYER_PED_ID(), true), 0, true, 1);
	while (DOES_ENTITY_EXIST(veh) == false)
		WAIT(0);

	int netId = NETWORK_GET_NETWORK_ID_FROM_ENTITY(veh);
	if (NETWORK_DOES_NETWORK_ID_EXIST(netId))
	{
		_SET_ENTITY_REGISTER(veh, true);
		if (NETWORK_GET_ENTITY_IS_NETWORKED(veh))
			SET_NETWORK_ID_EXISTS_ON_ALL_MACHINES(netId, true);

		SET_ENTITY_HEADING(veh, GET_ENTITY_HEADING(PLAYER_PED_ID()));
		SET_PED_INTO_VEHICLE(PLAYER_PED_ID(), veh, -1);
		SET_VEHICLE_ENGINE_ON(veh, 1, 1, 0);
		SET_VEHICLE_FORWARD_SPEED(veh, speed);
	}
	SET_ENTITY_AS_NO_LONGER_NEEDED(&veh);
	SET_MODEL_AS_NO_LONGER_NEEDED(vehash);
}

void spawnPedSwatUnit(const char *model, Ped pl)
{
	NETWORK_SET_SCRIPT_IS_SAFE_FOR_NETWORK_GAME();
	if (NETWORK_IS_GAME_IN_PROGRESS() && !NETWORK_GET_THIS_SCRIPT_IS_NETWORK_SCRIPT())
	{
		NETWORK_SET_THIS_SCRIPT_IS_NETWORK_SCRIPT(18, 0, -1);
		NETWORK_GET_SCRIPT_STATUS();
	}

	Hash name = GET_HASH_KEY(model);
	REQUEST_MODEL(name);
	while (!HAS_MODEL_LOADED(name))
		WAIT(0);
	
	RESERVE_NETWORK_MISSION_PEDS(1);
	vector3 coord = GET_ENTITY_COORDS(pl, true);
	coord.x -= 10.0f;
	coord.y -= 10.0f;
	Ped ped = CREATE_PED(4, name, coord, GET_ENTITY_HEADING(pl), true, 1);
	while (!DOES_ENTITY_EXIST(ped))
		WAIT(0);
	
	OPswat2 = CLONE_PED(ped, GET_ENTITY_HEADING(ped), 0, 1);
	OPswat3 = CLONE_PED(ped, GET_ENTITY_HEADING(ped), 0, 1);
	OPswat4 = CLONE_PED(ped, GET_ENTITY_HEADING(ped), 0, 1);

	int netId = NETWORK_GET_NETWORK_ID_FROM_ENTITY(ped);
	if (NETWORK_DOES_NETWORK_ID_EXIST(netId))
	{
		_SET_ENTITY_REGISTER(ped, true);
		if (NETWORK_GET_ENTITY_IS_NETWORKED(ped))
			SET_NETWORK_ID_EXISTS_ON_ALL_MACHINES(netId, true);
	}

	SET_ENTITY_AS_NO_LONGER_NEEDED(&ped);
	SET_MODEL_AS_NO_LONGER_NEEDED(name);
}

void AllPspawnPedSwatUnit(const char *model)
{
	NETWORK_SET_SCRIPT_IS_SAFE_FOR_NETWORK_GAME();
	if (NETWORK_IS_GAME_IN_PROGRESS() && !NETWORK_GET_THIS_SCRIPT_IS_NETWORK_SCRIPT())
	{
		NETWORK_SET_THIS_SCRIPT_IS_NETWORK_SCRIPT(18, 0, -1);
		NETWORK_GET_SCRIPT_STATUS();
	}

	Hash name = GET_HASH_KEY(model);
	REQUEST_MODEL(name);
	while (!HAS_MODEL_LOADED(name))
		WAIT(0);

	for (int i = 0; i < 16; i++)
	{
		if (ARE_STRINGS_EQUAL(GET_PLAYER_NAME(i), "**Invalid**") == false)
		{
			Ped pl = GET_PLAYER_PED(i);
			if (includeself == true)
			{
				RESERVE_NETWORK_MISSION_PEDS(1);
				vector3 coord = GET_ENTITY_COORDS(pl, true);
				coord.x -= 10.0f;
				coord.y -= 10.0f;
				Ped clone = CREATE_PED(4, name, coord, GET_ENTITY_HEADING(pl), true, 1);
				while (!DOES_ENTITY_EXIST(clone))
					WAIT(0);

				Ped clone2 = CLONE_PED(clone, GET_ENTITY_HEADING(pl), 0, 1);
				Ped clone3 = CLONE_PED(clone, GET_ENTITY_HEADING(pl), 0, 1);
				Ped clone4 = CLONE_PED(clone, GET_ENTITY_HEADING(pl), 0, 1);

				int netId = NETWORK_GET_NETWORK_ID_FROM_ENTITY(clone);
				if (NETWORK_DOES_NETWORK_ID_EXIST(netId))
				{
					_SET_ENTITY_REGISTER(clone, true);
					if (NETWORK_GET_ENTITY_IS_NETWORKED(clone))
						SET_NETWORK_ID_EXISTS_ON_ALL_MACHINES(netId, true);
				}

				Hash hashKey = GET_HASH_KEY("WEAPON_CARBINERIFLE");
				GIVE_DELAYED_WEAPON_TO_PED(clone, hashKey, 0x270f, true);
				GIVE_DELAYED_WEAPON_TO_PED(clone2, hashKey, 0x270f, true);
				GIVE_DELAYED_WEAPON_TO_PED(clone3, hashKey, 0x270f, true);
				GIVE_DELAYED_WEAPON_TO_PED(clone4, hashKey, 0x270f, true);
				SET_PED_CAN_SWITCH_WEAPON(clone, 1);
				SET_PED_CAN_SWITCH_WEAPON(clone2, 1);
				SET_PED_CAN_SWITCH_WEAPON(clone3, 1);
				SET_PED_CAN_SWITCH_WEAPON(clone4, 1);
				SET_PED_ARMOUR(clone, 100);
				SET_PED_ARMOUR(clone2, 100);
				SET_PED_ARMOUR(clone3, 100);
				SET_PED_ARMOUR(clone4, 100);
				ADD_ARMOUR_TO_PED(clone, 100);
				ADD_ARMOUR_TO_PED(clone2, 100);
				ADD_ARMOUR_TO_PED(clone3, 100);
				ADD_ARMOUR_TO_PED(clone4, 100);
				SET_PED_AS_ENEMY(pl, 1);
				SET_ENTITY_IS_TARGET_PRIORITY(pl, 1, 0);
				TASK_SHOOT_AT_ENTITY(clone, pl, -1, 3337513804U);
				TASK_SHOOT_AT_ENTITY(clone2, pl, -1, 3337513804U);
				TASK_SHOOT_AT_ENTITY(clone3, pl, -1, 3337513804U);
				TASK_SHOOT_AT_ENTITY(clone4, pl, -1, 3337513804U);
				TASK_COMBAT_PED(clone, pl, 0, 16);
				TASK_COMBAT_PED(clone2, pl, 0, 16);
				TASK_COMBAT_PED(clone3, pl, 0, 16);
				TASK_COMBAT_PED(clone4, pl, 0, 16);
				SET_PED_KEEP_TASK(clone, 1);
				SET_PED_KEEP_TASK(clone2, 1);
				SET_PED_KEEP_TASK(clone3, 1);
				SET_PED_KEEP_TASK(clone4, 1);
				SET_PED_SHOOT_RATE(clone, 1000);
				SET_PED_SHOOT_RATE(clone2, 1000);
				SET_PED_SHOOT_RATE(clone3, 1000);
				SET_PED_SHOOT_RATE(clone4, 1000);
				SET_PED_COMBAT_ABILITY(clone, 2);
				SET_PED_COMBAT_ABILITY(clone2, 2);
				SET_PED_COMBAT_ABILITY(clone3, 2);
				SET_PED_COMBAT_ABILITY(clone4, 2);
				SET_PED_COMBAT_ATTRIBUTES(clone, 52, 1);
				SET_PED_COMBAT_ATTRIBUTES(clone2, 52, 1);
				SET_PED_COMBAT_ATTRIBUTES(clone3, 52, 1);
				SET_PED_COMBAT_ATTRIBUTES(clone4, 52, 1);
				SET_PED_COMBAT_RANGE(clone, 0);
				SET_PED_COMBAT_RANGE(clone2, 0);
				SET_PED_COMBAT_RANGE(clone3, 0);
				SET_PED_COMBAT_RANGE(clone4, 0);
				SET_PED_ACCURACY(clone, 100);
				SET_PED_ACCURACY(clone2, 100);
				SET_PED_ACCURACY(clone3, 100);
				SET_PED_ACCURACY(clone4, 100);
				SET_PED_COMBAT_MOVEMENT(clone, 2);
				SET_PED_COMBAT_MOVEMENT(clone2, 2);
				SET_PED_COMBAT_MOVEMENT(clone3, 2);
				SET_PED_COMBAT_MOVEMENT(clone4, 2);
				SET_PED_FIRING_PATTERN(clone, 3337513804U);
				SET_PED_FIRING_PATTERN(clone2, 3337513804U);
				SET_PED_FIRING_PATTERN(clone3, 3337513804U);
				SET_PED_FIRING_PATTERN(clone4, 3337513804U);
				SET_CAN_ATTACK_FRIENDLY(clone, 0, 0);
				SET_CAN_ATTACK_FRIENDLY(clone2, 0, 0);
				SET_CAN_ATTACK_FRIENDLY(clone3, 0, 0);
				SET_CAN_ATTACK_FRIENDLY(clone4, 0, 0);
				SET_PED_MONEY(clone, 1000);
				SET_PED_MONEY(clone2, 1000);
				SET_PED_MONEY(clone3, 1000);
				SET_PED_MONEY(clone4, 1000);

				SET_ENTITY_AS_NO_LONGER_NEEDED(&clone);
				SET_MODEL_AS_NO_LONGER_NEEDED(name);
			}
			else
			{
				if (pl == PLAYER_PED_ID() == false)
				{
					RESERVE_NETWORK_MISSION_PEDS(1);
					vector3 coord = GET_ENTITY_COORDS(pl, true);
					coord.x -= 10.0f;
					coord.y -= 10.0f;
					Ped clone = CREATE_PED(4, name, coord, GET_ENTITY_HEADING(pl), true, 1);
					while (!DOES_ENTITY_EXIST(clone))
						WAIT(0);

					Ped clone2 = CLONE_PED(clone, GET_ENTITY_HEADING(pl), 0, 1);
					Ped clone3 = CLONE_PED(clone, GET_ENTITY_HEADING(pl), 0, 1);
					Ped clone4 = CLONE_PED(clone, GET_ENTITY_HEADING(pl), 0, 1);

					int netId = NETWORK_GET_NETWORK_ID_FROM_ENTITY(clone);
					if (NETWORK_DOES_NETWORK_ID_EXIST(netId))
					{
						_SET_ENTITY_REGISTER(clone, true);
						if (NETWORK_GET_ENTITY_IS_NETWORKED(clone))
							SET_NETWORK_ID_EXISTS_ON_ALL_MACHINES(netId, true);
					}
					Hash hashKey = GET_HASH_KEY("WEAPON_CARBINERIFLE");
					GIVE_DELAYED_WEAPON_TO_PED(clone, hashKey, 0x270f, true);
					GIVE_DELAYED_WEAPON_TO_PED(clone2, hashKey, 0x270f, true);
					GIVE_DELAYED_WEAPON_TO_PED(clone3, hashKey, 0x270f, true);
					GIVE_DELAYED_WEAPON_TO_PED(clone4, hashKey, 0x270f, true);
					SET_PED_CAN_SWITCH_WEAPON(clone, 1);
					SET_PED_CAN_SWITCH_WEAPON(clone2, 1);
					SET_PED_CAN_SWITCH_WEAPON(clone3, 1);
					SET_PED_CAN_SWITCH_WEAPON(clone4, 1);
					SET_PED_ARMOUR(clone, 100);
					SET_PED_ARMOUR(clone2, 100);
					SET_PED_ARMOUR(clone3, 100);
					SET_PED_ARMOUR(clone4, 100);
					ADD_ARMOUR_TO_PED(clone, 100);
					ADD_ARMOUR_TO_PED(clone2, 100);
					ADD_ARMOUR_TO_PED(clone3, 100);
					ADD_ARMOUR_TO_PED(clone4, 100);
					SET_PED_AS_ENEMY(pl, 1);
					SET_ENTITY_IS_TARGET_PRIORITY(pl, 1, 0);
					TASK_SHOOT_AT_ENTITY(clone, pl, -1, 3337513804U);
					TASK_SHOOT_AT_ENTITY(clone2, pl, -1, 3337513804U);
					TASK_SHOOT_AT_ENTITY(clone3, pl, -1, 3337513804U);
					TASK_SHOOT_AT_ENTITY(clone4, pl, -1, 3337513804U);
					TASK_COMBAT_PED(clone, pl, 0, 16);
					TASK_COMBAT_PED(clone2, pl, 0, 16);
					TASK_COMBAT_PED(clone3, pl, 0, 16);
					TASK_COMBAT_PED(clone4, pl, 0, 16);
					SET_PED_KEEP_TASK(clone, 1);
					SET_PED_KEEP_TASK(clone2, 1);
					SET_PED_KEEP_TASK(clone3, 1);
					SET_PED_KEEP_TASK(clone4, 1);
					SET_PED_SHOOT_RATE(clone, 1000);
					SET_PED_SHOOT_RATE(clone2, 1000);
					SET_PED_SHOOT_RATE(clone3, 1000);
					SET_PED_SHOOT_RATE(clone4, 1000);
					SET_PED_COMBAT_ABILITY(clone, 2);
					SET_PED_COMBAT_ABILITY(clone2, 2);
					SET_PED_COMBAT_ABILITY(clone3, 2);
					SET_PED_COMBAT_ABILITY(clone4, 2);
					SET_PED_COMBAT_ATTRIBUTES(clone, 52, 1);
					SET_PED_COMBAT_ATTRIBUTES(clone2, 52, 1);
					SET_PED_COMBAT_ATTRIBUTES(clone3, 52, 1);
					SET_PED_COMBAT_ATTRIBUTES(clone4, 52, 1);
					SET_PED_COMBAT_RANGE(clone, 0);
					SET_PED_COMBAT_RANGE(clone2, 0);
					SET_PED_COMBAT_RANGE(clone3, 0);
					SET_PED_COMBAT_RANGE(clone4, 0);
					SET_PED_ACCURACY(clone, 100);
					SET_PED_ACCURACY(clone2, 100);
					SET_PED_ACCURACY(clone3, 100);
					SET_PED_ACCURACY(clone4, 100);
					SET_PED_COMBAT_MOVEMENT(clone, 2);
					SET_PED_COMBAT_MOVEMENT(clone2, 2);
					SET_PED_COMBAT_MOVEMENT(clone3, 2);
					SET_PED_COMBAT_MOVEMENT(clone4, 2);
					SET_PED_FIRING_PATTERN(clone, 3337513804U);
					SET_PED_FIRING_PATTERN(clone2, 3337513804U);
					SET_PED_FIRING_PATTERN(clone3, 3337513804U);
					SET_PED_FIRING_PATTERN(clone4, 3337513804U);
					SET_CAN_ATTACK_FRIENDLY(clone, 0, 0);
					SET_CAN_ATTACK_FRIENDLY(clone2, 0, 0);
					SET_CAN_ATTACK_FRIENDLY(clone3, 0, 0);
					SET_CAN_ATTACK_FRIENDLY(clone4, 0, 0);
					SET_PED_MONEY(clone, 1000);
					SET_PED_MONEY(clone2, 1000);
					SET_PED_MONEY(clone3, 1000);
					SET_PED_MONEY(clone4, 1000);

					SET_ENTITY_AS_NO_LONGER_NEEDED(&clone);
					SET_MODEL_AS_NO_LONGER_NEEDED(name);
				}
				else
				{

				}
			}
		}
	}
	
}

void spawnPed(const char *model, Ped pl)
{
	NETWORK_SET_SCRIPT_IS_SAFE_FOR_NETWORK_GAME();
	if (NETWORK_IS_GAME_IN_PROGRESS() && !NETWORK_GET_THIS_SCRIPT_IS_NETWORK_SCRIPT())
	{
		NETWORK_SET_THIS_SCRIPT_IS_NETWORK_SCRIPT(18, 0, -1);
		NETWORK_GET_SCRIPT_STATUS();
	}

	Hash name = GET_HASH_KEY(model);
	REQUEST_MODEL(name);
	while (!HAS_MODEL_LOADED(name))
		WAIT(0);
	
	RESERVE_NETWORK_MISSION_PEDS(1);
	vector3 coord = GET_ENTITY_COORDS(pl, true);
	coord.x -= 5.0f;
	coord.y -= 5.0f;
	Ped ped = CREATE_PED(4, name, coord, GET_ENTITY_HEADING(pl), true, 1);
	while (!DOES_ENTITY_EXIST(ped))
		WAIT(0);

	int netId = NETWORK_GET_NETWORK_ID_FROM_ENTITY(ped);
	if (NETWORK_DOES_NETWORK_ID_EXIST(netId))
	{
		_SET_ENTITY_REGISTER(ped, true);
		if (NETWORK_GET_ENTITY_IS_NETWORKED(ped))
			SET_NETWORK_ID_EXISTS_ON_ALL_MACHINES(netId, true);
	}
	swatBuzz = ped;
	SET_ENTITY_AS_NO_LONGER_NEEDED(&ped);
	SET_MODEL_AS_NO_LONGER_NEEDED(name);
}

void spawnObj(const char *obj)
{
	Hash name = GET_HASH_KEY(obj);
	REQUEST_MODEL(name);
	while (!HAS_MODEL_LOADED(name))
		WAIT(0);
	if (NETWORK_IS_GAME_IN_PROGRESS() && CAN_REGISTER_MISSION_OBJECTS(1)) //delete ?
	{
		RESERVE_NETWORK_MISSION_OBJECTS(1);
		Object obj = CREATE_OBJECT_NO_OFFSET(name, GET_ENTITY_COORDS(PLAYER_PED_ID(), true), true, true, false);
		int netId = NETWORK_GET_NETWORK_ID_FROM_ENTITY(obj);
		if (NETWORK_DOES_NETWORK_ID_EXIST(netId))
		{
			_SET_ENTITY_REGISTER(obj, true);
			if (NETWORK_GET_ENTITY_IS_NETWORKED(obj))
			{
				SET_NETWORK_ID_EXISTS_ON_ALL_MACHINES(netId, true);
				SET_NETWORK_ID_CAN_MIGRATE(netId, false);
			}
		}
		SET_ENTITY_AS_NO_LONGER_NEEDED(&obj);
	}
	SET_MODEL_AS_NO_LONGER_NEEDED(joaat("prop_ld_toilet_01"));
}

void AllPlayersExplode()
{
	if (allplayersexplode == true)
	{
		for (int i = 0; i < 16; i++)
		{
			Ped ped = GET_PLAYER_PED(i);
			if (ped != PLAYER_PED_ID())
			{
				if (IS_ENTITY_DEAD(ped) == false)
				{
					vector3 coord = GET_ENTITY_COORDS(ped, true);
					ADD_OWNED_EXPLOSION(GET_PLAYER_PED(i), coord, 29, 0.5f, true, true, 5.0f);
				}
			}
		}
	}
}

void HostileNearPeds()
{
	for (int i = 0; i < 16; i++)
	{
		if (playershostile[i] == true)
		{
			peds[0] = 12;
			int count = GET_PED_NEARBY_PEDS(pedhostile[selected_player], peds, -1);

			if (count > 0)
			{
				for (int i = 0; i < count; i++)
				{
					if (DOES_ENTITY_EXIST(peds[i]))
					{
						NETWORK_REQUEST_CONTROL_OF_ENTITY(peds[i]);
						SET_PED_COMBAT_ABILITY(peds[i], 2);
						SET_PED_COMBAT_ATTRIBUTES(peds[i], 52, 1);
						SET_PED_AS_ENEMY(pedhostile[selected_player], 1);
						SET_ENTITY_IS_TARGET_PRIORITY(pedhostile[selected_player], 1, 0);
						TASK_COMBAT_PED(peds[i], pedhostile[selected_player], 0, 16);
						SET_PED_KEEP_TASK(peds[i], 1);
					}
				}
			}
		}
	}
}

void PlayAnim(Ped ped, const char *animDict, const char *animName)
{
	REQUEST_ANIM_DICT(animDict);
	while (!HAS_ANIM_DICT_LOADED(animDict)) WAIT(0);
	if (HAS_ANIM_DICT_LOADED(animDict))
	{
		TASK_PLAY_ANIM(ped, animDict, animName, 8.0f, 0.0f, -1, 9, 0, 0, 0, 0);
	}
}

void FPSDisp()
{
	if (fpscount)
	{
		fps = frameCache_new - frameCache_old - 1;
		const char *fpsres = itosGlobal(fps);

		if (fps <= 18) //if fps <= 18 draw the value in red
		{
			DRAW_TEXT((char*)fpsres, 0, PosP(0.21f), PosP(0.78f), 0.5, 0.5, 255, 0, 0, 255, true, false, 0, 0, 0);
		}
		else
		{
			DRAW_TEXT((char*)fpsres, 0, PosP(0.21f), PosP(0.78f), 0.5, 0.5, 255, 255, 255, 255, true, false, 0, 0, 0);
		}

		if (frameCache_time + 1000 < GET_GAME_TIMER()) //Timer of FPS counter for cadence
		{
			frameCache_time = GET_GAME_TIMER();
			frameCache_old = frameCache_new;
			frameCache_new = GET_FRAME_COUNT();
		}
	}
}

void SetNeons()
{
	if (neonon == true)
	{
		if (selneon != 0)
		{
			Vehicle vehicle = GET_VEHICLE_PED_IS_IN(PLAYER_PED_ID(), false);
			Hash veh = GET_ENTITY_MODEL(vehicle);
			if (IS_THIS_MODEL_A_TRAIN(veh) == false && IS_THIS_MODEL_A_BOAT(veh) == false)
			{
				vector3 Relative = GET_ENTITY_COORDS(vehicle, false);
				float ZGround = 0;
				if (GET_GROUND_Z_FOR_3D_COORD(Relative, &ZGround, 0))
					Relative.z = ZGround;

				DRAW_LIGHT_WITH_RANGE(Relative, NeonsCl[selneon], 4.0f, 15.0f);
			}
		}
	}
}

void LightGen()
{
	if (lightn)
	{
		_CREATE_LIGHTNING_THUNDER();
	}
}
#pragma endregion

void Menu()
{
	if (NumMenu != Closed)
	SetupActions();

	optionCount = 0;

	if (NumMenu == Main_Menu)
	{
		AddTitle("Cyber Mod Loader");
		FolderOption("Cyber Menu", Cyber_Menu);
		FolderOption("Main Mod Menus", Main_Scripts);
		FolderOption("Other Mod Menus", Other_Scripts);
		FolderOption("Recovery Mod Menus", Recovery_Scripts);
		FolderOption("Protections Mod Menus", Protections_Scripts);
		//FolderOption("Custom Scripts", Custom_Scripts);
		AddSubTitle("Main Menu");
	}

	if (NumMenu == Cyber_Menu)
	{
		AddTitle("Cyber Mod Loader");
		FolderOption("Self Options", Self_Mods);
		FolderOption("Online Players", Online_Players);
		FolderOption("Vehicle Options", Vehicle_Mods);
		FolderOption("Models Menu", Models_Menu);
		FolderOption("Teleport Options", Teleport_Mods);
		FolderOption("Misc Options", Misc_Mods);
		FolderOption("Maps Loader", Map_Mods);
		AddSubTitle("Cyber Mod Menu");
	}

	if (NumMenu == Self_Mods)
	{
		AddTitle("Cyber Mod Loader");
		CheckBox("God Mode", godmode);
		CheckBox("Super Jump", jump);
		CheckBox("Invisible", invisible);
		CheckBoxMultiplier("Iper Jump", &iperj, 1, 5, ijump, 1);
		CheckBoxMultiplier("Super Man", &supermanmultip, 1, 3, supman, 6);
		CheckBoxMultiplier("Super Run", &superr, 1, 5, run, 2);
		FolderOption("Animations Menu", Anim_Menu);
		CheckBox("Super Punch", supunch);
		CheckBox("Never Wanted", nocop);
		addOptionInt("Wanted Level", &selfwanted, 0, 5);
		CheckBox("No Ragdoll", noragd);
		CheckBox("Explosive Ammo", expammo);
		CheckBox("Fire Ammo", fireammo);
		CheckBox("Mobile Radio", radio);
		CheckBox("Unlimited Ammo", unlimitedammo);
		CheckBox("Boss Mode", bossmode);
		CheckBox("One Hit Kill", ohk);
		CheckBox("Simple Money Drop", simplemoneydrop);
		addOption("Fix and Wash Player");
		addOptionMultip("Money Rain", &moneyrmultip, 1, 5);
		addOptionMoney("Give Money");
		addOption("Give all Weapons");
		addOption("Explode Self");
		AddSubTitle("Self Options");

		if (GET() == 1)
		{
			godmode = !godmode;
			if (godmode)
			{
				int ped = PLAYER_PED_ID();
				SET_PLAYER_INVINCIBLE(PLAYER_ID(), true);
				SET_ENTITY_PROOFS(ped, true, true, true, true, true, true, 1, true);

			}
			else
			{
				int ped = PLAYER_PED_ID();
				SET_PLAYER_INVINCIBLE(PLAYER_ID(), false);
				SET_ENTITY_INVINCIBLE(ped, false);
				SET_ENTITY_PROOFS(ped, false, false, false, false, false, false, 1, false);
			}
		}
		else if (GET() == 2)
		{
			jump = !jump;
		}
		else if (GET() == 3)
		{
			invisible = !invisible;
			if (invisible)
			{
				SET_ENTITY_ALPHA(PLAYER_PED_ID(), 0, 0);
			}
			else
			{
				RESET_ENTITY_ALPHA(PLAYER_PED_ID());
			}
		}
		else if (GET() == 4)
		{
			ijump = !ijump;

			if (ijump == true)
			{
				if (jump == false)
					print("Enable Super Jump for better jumps", 2000);
			}
		}
		else if (GET() == 5)
		{
			supman = !supman;
		}
		else if (GET() == 6)
		{
			run = !run;
		}
		else if (GET() == 8)
		{
			supunch = !supunch;
		}
		else if (GET() == 9)
		{
			nocop = !nocop;
			if (nocop == false)
			{
				SET_MAX_WANTED_LEVEL(5);
			}
			else
			{

			}
		}
		else if (GET() == 10)
		{
			SET_PLAYER_WANTED_LEVEL(PLAYER_ID(), selfwanted, false);
			SET_PLAYER_WANTED_LEVEL_NOW(PLAYER_ID(), false);
		}
		else if (GET() == 11)
		{
			noragd = !noragd;
			Ped ped = PLAYER_PED_ID();
			if (noragd)
			{
				SET_PED_CAN_RAGDOLL(ped, false);
				SET_PED_CAN_RAGDOLL_FROM_PLAYER_IMPACT(ped, false);
				SET_PED_CAN_BE_KNOCKED_OFF_VEHICLE(ped, false);
				GIVE_PLAYER_RAGDOLL_CONTROL(ped, true);
				SET_PED_RAGDOLL_ON_COLLISION(ped, false);
			}
			else
			{
				SET_PED_CAN_RAGDOLL(ped, true);
				SET_PED_CAN_RAGDOLL_FROM_PLAYER_IMPACT(ped, true);
				SET_PED_CAN_BE_KNOCKED_OFF_VEHICLE(ped, true);
				GIVE_PLAYER_RAGDOLL_CONTROL(ped, false);
				SET_PED_RAGDOLL_ON_COLLISION(ped, true);
			}
		}
		else if (GET() == 12)
		{
			expammo = !expammo;
		}
		else if (GET() == 13)
		{
			fireammo = !fireammo;
		}
		else if (GET() == 14)
		{
			radio = !radio;
			if (radio == true)
			{
				SET_MOBILE_RADIO_ENABLED_DURING_GAMEPLAY(true);
				SET_RADIO_TO_STATION_INDEX(6);
			}
			else
			{
				SET_MOBILE_RADIO_ENABLED_DURING_GAMEPLAY(false);
			}
		}
		else if (GET() == 15)
		{
			unlimitedammo = !unlimitedammo;
			if (unlimitedammo == true)
			{
				SET_PED_INFINITE_AMMO_CLIP(PLAYER_PED_ID(), true);
			}
			else
			{

			}
		}
		else if (GET() == 16)
		{
			bossmode = !bossmode;
		}
		else if (GET() == 17)
		{
			ohk = !ohk;
			if (ohk == true)
			{
				SET_PLAYER_WEAPON_DAMAGE_MODIFIER(PLAYER_PED_ID(), 700);
			}
			else
			{
				SET_PLAYER_WEAPON_DAMAGE_MODIFIER(PLAYER_PED_ID(), 1);
			}
		}
		else if (GET() == 18)
		{
			simplemoneydrop = !simplemoneydrop;
		}
		else if (GET() == 19)
		{
			CLEAR_PED_BLOOD_DAMAGE(PLAYER_PED_ID());
			RESET_PED_VISIBLE_DAMAGE(PLAYER_PED_ID());
			SET_ENTITY_HEALTH(PLAYER_PED_ID(), 200);
			ADD_ARMOUR_TO_PED(PLAYER_PED_ID(), 100);
		}
		else if (GET() == 20)
		{
			if (moneyrmultip == 1)
			{
				for (int i = 0; i < 20; i++)
				{
					vector3 coord = GET_ENTITY_COORDS(PLAYER_PED_ID(), true);
					int num = GET_RANDOM_INT_IN_RANGE(-500, 500);
					int num2 = GET_RANDOM_INT_IN_RANGE(-500, 500);
					coord.x += ((float)num) / 50.0f;
					coord.y += ((float)num2) / 50.0f;
					coord.z += 3.0f;
					CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0xC350, 1, 0, 1);
				}
			}
			else if (moneyrmultip == 2)
			{
				for (int i = 0; i < 35; i++)
				{
					vector3 coord = GET_ENTITY_COORDS(PLAYER_PED_ID(), true);
					int num = GET_RANDOM_INT_IN_RANGE(-500, 500);
					int num2 = GET_RANDOM_INT_IN_RANGE(-500, 500);
					coord.x += ((float)num) / 50.0f;
					coord.y += ((float)num2) / 50.0f;
					coord.z += 3.0f;
					CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0xC350, 1, 0, 1);
				}
			}
			else if (moneyrmultip == 3)
			{
				for (int i = 0; i < 50; i++)
				{
					vector3 coord = GET_ENTITY_COORDS(PLAYER_PED_ID(), true);
					int num = GET_RANDOM_INT_IN_RANGE(-500, 500);
					int num2 = GET_RANDOM_INT_IN_RANGE(-500, 500);
					coord.x += ((float)num) / 50.0f;
					coord.y += ((float)num2) / 50.0f;
					coord.z += 3.0f;
					CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0xC350, 1, 0, 1);
				}
			}
			else if (moneyrmultip == 4)
			{
				for (int i = 0; i < 65; i++)
				{
					vector3 coord = GET_ENTITY_COORDS(PLAYER_PED_ID(), true);
					int num = GET_RANDOM_INT_IN_RANGE(-500, 500);
					int num2 = GET_RANDOM_INT_IN_RANGE(-500, 500);
					coord.x += ((float)num) / 50.0f;
					coord.y += ((float)num2) / 50.0f;
					coord.z += 3.0f;
					CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0xC350, 1, 0, 1);
				}
			}
			else if (moneyrmultip == 5)
			{
				for (int i = 0; i < 80; i++)
				{
					vector3 coord = GET_ENTITY_COORDS(PLAYER_PED_ID(), true);
					int num = GET_RANDOM_INT_IN_RANGE(-500, 500);
					int num2 = GET_RANDOM_INT_IN_RANGE(-500, 500);
					coord.x += ((float)num) / 50.0f;
					coord.y += ((float)num2) / 50.0f;
					coord.z += 3.0f;
					CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0xC350, 1, 0, 1);
				}
			}
		}
		else if (GET() == 21)
		{
			vector3 coord = GET_ENTITY_COORDS(PLAYER_PED_ID(), true);

			if (givemoney == 0)
			{
				for (int i = 0; i < 10; i++)
				{
					CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0x2710, 1, 0, 1);
				}
			}
			else if (givemoney == 1)
			{
				for (int i = 0; i < 10; i++)
				{
					CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0x61A8, 1, 0, 1);
				}
			}
			else if (givemoney == 2)
			{
				for (int i = 0; i < 20; i++)
				{
					CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0x61A8, 1, 0, 1);
				}
			}
			else if (givemoney == 3)
			{
				for (int i = 0; i < 40; i++)
				{
					CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0x61A8, 1, 0, 1);
				}
			}
			else if (givemoney == 4)
			{
				for (int i = 0; i < 50; i++)
				{
					CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0x186A0, 1, 0, 1);
				}
			}
			else if (givemoney == 5)
			{
				for (int i = 0; i < 50; i++)
				{
					CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0xF4240, 1, 0, 1);
				}
			}
		}
		else if (GET() == 22)
		{
			for (int i = 0; i < 62; i++)
				GIVE_DELAYED_WEAPON_TO_PED(PLAYER_PED_ID(), WeaponsHash[i], 0x270f, true);
		}
		else if (GET() == 23)
		{
			vector3 coords = GET_ENTITY_COORDS(PLAYER_PED_ID(), true);
			ADD_OWNED_EXPLOSION(PLAYER_PED_ID(), coords, 5, 0.5f, true, true, 5.0f);
		}
	}

	if (NumMenu == Anim_Menu)
	{
		AddTitle("Cyber Mod Loaer");
		addOption("Stop Animation");
		addOption("Sex Giver");
		addOption("Sex Receiver");
		addOption("Strip Dance");
		addOption("Pole Dance");
		addOption("Private Dance");
		addOption("Push Ups");
		addOption("Sit Ups");
		addOption("Car Sex");
		addOption("Electrocution");
		addOption("Suicide");
		addOption("Shower");
		addOption("Jogging");
		addOption("Balcony Fight");
		addOption("Dog Pissing");
		addOption("Dog Fucking");
		addOption("WTF ??");
		AddSubTitle("Animations Menu");

		if (GET() == 1)
		{
			CLEAR_PED_TASKS_IMMEDIATELY(PLAYER_PED_ID());
		}
		else if (GET() == 2)
		{
			PlayAnim(PLAYER_PED_ID(), "rcmpaparazzo_2", "shag_loop_a");
		}
		else if (GET() == 3)
		{
			PlayAnim(PLAYER_PED_ID(), "rcmpaparazzo_2", "shag_loop_poppy");
		}
		else if (GET() == 4)
		{
			PlayAnim(PLAYER_PED_ID(), "mini@strip_club@private_dance@part1", "priv_dance_p1");
		}
		else if (GET() == 5)
		{
			PlayAnim(PLAYER_PED_ID(), "mini@strip_club@pole_dance@pole_dance3", "pd_dance_03");
		}
		else if (GET() == 6)
		{
			PlayAnim(PLAYER_PED_ID(), "mini@strip_club@private_dance@part2", "priv_dance_p2");
		}
		else if (GET() == 7)
		{
			PlayAnim(PLAYER_PED_ID(), "amb@world_human_push_ups@male@base", "base");
		}
		else if (GET() == 8)
		{
			PlayAnim(PLAYER_PED_ID(), "amb@world_human_sit_ups@male@base", "base");
		}
		else if (GET() == 9)
		{
			PlayAnim(PLAYER_PED_ID(), "ODDJOBS@ASSASSINATE@VICE@SEX", "frontseat_carsex_loop_m");
		}
		else if (GET() == 10)
		{
			PlayAnim(PLAYER_PED_ID(), "ragdoll@human", "electrocute");
		}
		else if (GET() == 11)
		{
			PlayAnim(PLAYER_PED_ID(), "mp_suicide", "pistol");
		}
		else if (GET() == 12)
		{
			PlayAnim(PLAYER_PED_ID(), "mp_safehouseshower@male@", "male_shower_idle_b");
		}
		else if (GET() == 13)
		{
			PlayAnim(PLAYER_PED_ID(), "rcmfanatic1", "jogging_up");
		}
		else if (GET() == 14)
		{
			PlayAnim(PLAYER_PED_ID(), "random@domestic", "balcony_fight_male");
		}
		else if (GET() == 15)
		{
			PlayAnim(PLAYER_PED_ID(), "creatures@rottweiler@move", "pee_right_idle");
		}
		else if (GET() == 16)
		{
			PlayAnim(PLAYER_PED_ID(), "missfra0_chop_find", "hump_loop_chop");
		}
		else if (GET() == 17)
		{
			PlayAnim(PLAYER_PED_ID(), "missfbi5ig_30monkeys", "monkey_a_freakout_loop");
		}
	}

	if (NumMenu == Vehicle_Mods)
	{
		AddTitle("Cyber Mod Loader");
		FolderOption("Vehicle Spawner  --->>", Veh_Spawn);
		FolderVehOption("Vehicle Mod Shop  --->>", Veh_ModShop, "");
		CheckBox("God Mode Vehicle", godmodeveh);
		CheckBoxMultiplier("Need 4 Speed Vehicle", &nfsm, 1, 5, nfs, 3);
		CheckBox("Ghost Vehicle", ghostveh);
		CheckBoxSpeedom("Show Speedometer", &selSpeedom, 0, 1, speedom);
		CheckBox("Stick to the Ground", stickground);
		CheckBox("Reduce Grip", reducegrip);
		CheckBox("Crazy Doors", doorsloop);
		CheckBox("Tiresmoke Color Loop", tiresmokeloop);
		CheckBox("Random Respray Loop", resprayloop);
		CheckBoxMultiplier("Vehicle Jump Bind", &vehj, 1, 5, vehjump, 4);
		CheckBoxMultiplier("NOS Bind", &vehnos, 1, 5, nosbind, 5);
		CheckBox("Instant Stop Bind", stopbind);
		addOption("Max Upgrades");
		addOption("Fix and Wash Vehicle");
		AddSubTitle("Vehicle Options");

		if (GET() == 3)
		{
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				godmodeveh = !godmodeveh;
				if (godmodeveh == true)
				{
					SET_VEHICLE_FIXED(GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID()));
					SET_VEHICLE_DEFORMATION_FIXED(GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID()));
					SET_VEHICLE_DIRT_LEVEL(GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID()), 0);
					SET_VEHICLE_CAN_BE_VISIBLY_DAMAGED(GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID()), false);
					SET_ENTITY_INVINCIBLE(GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID()), true);
					SET_VEHICLE_EXPLODES_ON_HIGH_EXPLOSION_DAMAGE(GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID()), false);
					SET_ENTITY_PROOFS(GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID()), true, true, true, true, true, true, 1, true);
				}
				else
				{
					SET_VEHICLE_CAN_BE_VISIBLY_DAMAGED(GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID()), true);
					SET_ENTITY_INVINCIBLE(GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID()), false);
					SET_VEHICLE_EXPLODES_ON_HIGH_EXPLOSION_DAMAGE(GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID()), true);
					SET_ENTITY_PROOFS(GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID()), false, false, false, false, false, false, 1, false);
				}
			}
			else
			{
				godmodeveh = false;
				print("~r~Not in a vehicle..", 2000);
			}
		}
		else if (GET() == 4)
		{
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				nfs = !nfs;
				if (nfs == true)
				{
					if (nfsm == 1)
					{
						_SET_VEHICLE_ENGINE_POWER_MULTIPLIER(GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID()), 30);
					}
					else if (nfsm == 2)
					{
						_SET_VEHICLE_ENGINE_POWER_MULTIPLIER(GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID()), 44);
					}
					else if (nfsm == 3)
					{
						_SET_VEHICLE_ENGINE_POWER_MULTIPLIER(GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID()), 60);
					}
					else if (nfsm == 4)
					{
						_SET_VEHICLE_ENGINE_POWER_MULTIPLIER(GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID()), 70);
					}
					else if (nfsm == 5)
					{
						_SET_VEHICLE_ENGINE_POWER_MULTIPLIER(GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID()), 90);
					}
				}
				else
				{
					_SET_VEHICLE_ENGINE_POWER_MULTIPLIER(GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID()), 0);
				}
			}
			else
			{
				nfs = false;
				print("~r~Not in a vehicle..", 2000);
			}
		}
		else if (GET() == 5)
		{
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				ghostveh = !ghostveh;
				if (ghostveh == true)
				{
					Vehicle veh = GET_VEHICLE_PED_IS_IN(PLAYER_PED_ID(), false);
					SET_ENTITY_ALPHA(veh, 0, 0);
				}
				else
				{
					Vehicle veh = GET_VEHICLE_PED_IS_IN(PLAYER_PED_ID(), false);
					SET_ENTITY_ALPHA(veh, 255, 0);
				}
			}
			else
			{
				ghostveh = false;
				print("~r~Not in a vehicle..", 2000);
			}
		}
		else if (GET() == 6)
		{
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				speedom = !speedom;
			}
			else
			{
				speedom = false;
				print("~r~Not in a vehicle..", 2000);
			}
		}
		else if (GET() == 7)
		{
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				stickground = !stickground;
			}
			else
			{
				stickground = false;
				print("~r~Not in a vehicle..", 2000);
			}
		}
		else if (GET() == 8)
		{
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				reducegrip = !reducegrip;
				if (reducegrip == true)
				{
					SET_VEHICLE_REDUCE_GRIP(GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID()), 1);
				}
				else
				{
					SET_VEHICLE_REDUCE_GRIP(GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID()), 0);
				}
			}
			else
			{
				reducegrip = false;
				print("~r~Not in a vehicle..", 2000);
			}
		}
		else if (GET() == 9)
		{
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				doorsloop = !doorsloop;
			}
			else
			{
				doorsloop = false;
				print("~r~Not in a vehicle..", 2000);
			}
		}
		else if (GET() == 10)
		{
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				tiresmokeloop = !tiresmokeloop;
			}
			else
			{
				tiresmokeloop = false;
				print("~r~Not in a vehicle..", 2000);
			}
		}
		else if (GET() == 11)
		{
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				resprayloop = !resprayloop;
			}
			else
			{
				resprayloop = false;
				print("~r~Not in a vehicle..", 2000);
			}
		}
		else if (GET() == 12)
		{
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				vehjump = !vehjump;
			}
			else
			{
				vehjump = false;
				print("~r~Not in a vehicle..", 2000);
			}
		}
		else if (GET() == 13)
		{
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				nosbind = !nosbind;
			}
			else
			{
				nosbind = false;
				print("~r~Not in a vehicle..", 2000);
			}
		}
		else if (GET() == 14)
		{
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				stopbind = !stopbind;
			}
			else
			{
				stopbind = false;
				print("~r~Not in a vehicle..", 2000);
			}
		}
		else if (GET() == 15)
		{
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
				SET_VEHICLE_CUSTOM_PRIMARY_COLOUR(veh, 0, 0, 0);
				SET_VEHICLE_CUSTOM_SECONDARY_COLOUR(veh, 0, 0, 0);
				SET_VEHICLE_MOD_KIT(veh, 0);
				SET_VEHICLE_COLOURS(veh, 120, 120);
				SET_VEHICLE_NUMBER_PLATE_TEXT(veh, "CYBER");
				SET_VEHICLE_NUMBER_PLATE_TEXT_INDEX(veh, 1);
				TOGGLE_VEHICLE_MOD(veh, 18, 1);
				TOGGLE_VEHICLE_MOD(veh, 22, 1);
				SET_VEHICLE_MOD(veh, 16, 5, 0);
				SET_VEHICLE_MOD(veh, 12, 2, 0);
				SET_VEHICLE_MOD(veh, 11, 3, 0);
				SET_VEHICLE_MOD(veh, 14, 14, 0);
				SET_VEHICLE_MOD(veh, 15, 3, 0);
				SET_VEHICLE_MOD(veh, 13, 2, 0);
				SET_VEHICLE_WHEEL_TYPE(veh, 6);
				SET_VEHICLE_WINDOW_TINT(veh, 5);
				SET_VEHICLE_MOD(veh, 23, 19, 1);
				SET_VEHICLE_MOD(veh, 0, 1, 0);
				SET_VEHICLE_MOD(veh, 1, 1, 0);
				SET_VEHICLE_MOD(veh, 2, 1, 0);
				SET_VEHICLE_MOD(veh, 3, 1, 0);
				SET_VEHICLE_MOD(veh, 4, 1, 0);
				SET_VEHICLE_MOD(veh, 5, 1, 0);
				SET_VEHICLE_MOD(veh, 6, 1, 0);
				SET_VEHICLE_MOD(veh, 7, 1, 0);
				SET_VEHICLE_MOD(veh, 8, 1, 0);
				SET_VEHICLE_MOD(veh, 9, 1, 0);
				SET_VEHICLE_MOD(veh, 10, 1, 0);
			}
			else
			{
				print("~r~Not in a Vehicle..", 2000);
			}
		}
		else if (GET() == 16)
		{
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				Vehicle VehicleHandle = GET_VEHICLE_PED_IS_IN(PLAYER_PED_ID(), false);
				SET_VEHICLE_FIXED(VehicleHandle);
				SET_VEHICLE_DEFORMATION_FIXED(VehicleHandle);
				SET_VEHICLE_DIRT_LEVEL(VehicleHandle, 0);
			}
			else
			{
				print("~r~Not in a vehicle..", 2000);
			}
		}
	}

	if (NumMenu == Misc_Mods)
	{
		AddTitle("Cyber Mod Loader");
		CheckBox("Crazy Weather with Lightnings", lightn);
		CheckBox("Freeze Time", frztime);
		CheckBox("Display FPS", fpscount);
		addOption("Set Midday");
		addOption("Set Midnight");
		addOption("Clear Area of Peds");
		addOption("Clear Area of Vehicles");
		AddSubTitle("Misc Options");

		if (GET() == 1)
		{
			lightn = !lightn;
			if (lightn)
			{
				_SET_WEATHER_TYPE_TRANSITION(GET_HASH_KEY("RAIN"), GET_HASH_KEY("SNOW"), 0.50f);
			}
			else
			{
				_SET_WEATHER_TYPE_OVER_TIME("CLOUDS", 20.0f);
			}
		}
		else if (GET() == 2)
		{
			frztime = !frztime;
			if (frztime == true)
			{
				PAUSE_CLOCK(true);
			}
			else
			{
				PAUSE_CLOCK(false);
			}
		}
		else if (GET() == 3)
		{
			fpscount = !fpscount;
		}
		else if (GET() == 4)
		{
			SET_CLOCK_TIME(12, 0, 0);
		}
		else if (GET() == 5)
		{
			SET_CLOCK_TIME(23, 59, 0);
		}
		else if (GET() == 6)
		{
			CLEAR_AREA_OF_PEDS(GET_ENTITY_COORDS(PLAYER_PED_ID(), true), 250.0f, 1);
		}
		else if (GET() == 7)
		{
			CLEAR_AREA_OF_VEHICLES(GET_ENTITY_COORDS(PLAYER_PED_ID(), true), 250.0f, false, false, false, false, false);
		}
	}

#pragma region vehSpawner
    if (NumMenu == Veh_Spawn)
	{
		AddTitle("Cyber Mod Loader");
		addOption("Spawn Custom Vehicle");
		FolderOption("Most used Vehicle", Most_used_veh);
		FolderOption("Super Cars", Super_Car);
		FolderOption("Sport", Sportive_Car);
		FolderOption("Classic Cars", SportiveC_Car);
		FolderOption("Muscle Cars", Muscle_Car);
		FolderOption("Coupes", Coupes_Car);
		FolderOption("Compact Cars", Compact_Car);
		FolderOption("Sedans", Sedans_Car);
		FolderOption("SUV", SUVTrucks_Car);
		FolderOption("Off Road", OFFRoad_Car);
		FolderOption("Vans", Vans_Car);
		FolderOption("Emergency", Emergency_Car);
		FolderOption("Service", Service_Car);
		FolderOption("Commercial", Commercial_Car);
		FolderOption("Military", Military_Car);
		FolderOption("Motorcycles", Moto_Car);
		FolderOption("Bicycles", Bicycles);
		FolderOption("Helicopters", Helicopters_Car);
		FolderOption("Planes", Planes_Car);
		FolderOption("Boats", Boats_Car);
		FolderOption("Snowy Vehicles", Snow_Car);
		AddSubTitle("Vehicle Spawner Menu");

		if (GET() == 1)
		{
			g_bKeyBoardDisplayed2 = true;
			DISPLAY_ONSCREEN_KEYBOARD(0, "FMMC_KEY_TIP8", "", "", "", "", "", 40);
		}
	}

	if (NumMenu == Super_Car)
	{
		AddTitle("Cyber Mod Loader");
		addOption("Adder");
		addOption("Entity XF");
		addOption("Cheetah");
		addOption("Infernus");
		addOption("Vacca");
		addOption("Bullet");
		addOption("Voltic");
		addOption("Zentorno");
		addOption("Turismo R");
		addOption("Osiris");
		addOption("T20");
		AddSubTitle("Super Cars");

		if (GET() == 1)
		{
			spawnVeh(VEHICLE_ADDER);
		}
		else if (GET() == 2)
		{
			spawnVeh(VEHICLE_ENTITYXF);
		}
		else if (GET() == 3)
		{
			spawnVeh(VEHICLE_CHEETAH);
		}
		else if (GET() == 4)
		{
			spawnVeh(VEHICLE_INFERNUS);
		}
		else if (GET() == 5)
		{
			spawnVeh(VEHICLE_VACCA);
		}
		else if (GET() == 6)
		{
			spawnVeh(VEHICLE_BULLET);
		}
		else if (GET() == 7)
		{
			spawnVeh(VEHICLE_VOLTIC);
		}
		else if (GET() == 8)
		{
			spawnVeh(VEHICLE_ZENTORNO);
		}
		else if (GET() == 9)
		{
			spawnVeh(VEHICLE_TURISMOR);
		}
		else if (GET() == 10)
		{
			spawnVeh(VEHICLE_OSIRIS);
		}
		else if (GET() == 11)
		{
			spawnVeh(VEHICLE_T20);
		}
	}

	if (NumMenu == Sportive_Car)
	{
		AddTitle("Cyber Mod Loader");
		addOption("Elegy RH8");
		addOption("Khamelion");
		addOption("Carbonizzare");
		addOption("Feltzer");
		addOption("Stirling GT");
		addOption("Rapid GT");
		addOption("Rapid GT cabrio");
		addOption("Coquette");
		addOption("9F");
		addOption("9F cabrio");
		addOption("Surano");
		addOption("Banshee");
		addOption("Comet");
		addOption("Schwartzer");
		addOption("Fusilade");
		addOption("Buffalo");
		addOption("Buffalo S");
		addOption("Penumbra");
		addOption("Sultan");
		addOption("Futo");
		addOption("Furore GT");
		addOption("Massacro");
		addOption("Massacro race");
		addOption("Jester");
		addOption("Jester race");
		addOption("Windsor");
		addOption("Alpha");
		addOption("Kuruma");
		addOption("Kuruma armored");
		AddSubTitle("Sportive Vehicles");

		if (GET() == 1)
		{
			spawnVeh(VEHICLE_ELEGY2);
		}
		else if (GET() == 2)
		{
			spawnVeh(VEHICLE_KHAMELION);
		}
		else if (GET() == 3)
		{
			spawnVeh(VEHICLE_CARBONIZZARE);
		}
		else if (GET() == 4)
		{
			spawnVeh(VEHICLE_FELTZER2);
		}
		else if (GET() == 5)
		{
			spawnVeh(VEHICLE_FELTZER3);
		}
		else if (GET() == 6)
		{
			spawnVeh(VEHICLE_RAPIDGT);
		}
		else if (GET() == 7)
		{
			spawnVeh(VEHICLE_RAPIDGT2);
		}
		else if (GET() == 8)
		{
			spawnVeh(VEHICLE_COQUETTE);
		}
		else if (GET() == 9)
		{
			spawnVeh(VEHICLE_NINEF);
		}
		else if (GET() == 10)
		{
			spawnVeh(VEHICLE_NINEF2);
		}
		else if (GET() == 11)
		{
			spawnVeh(VEHICLE_SURANO);
		}
		else if (GET() == 12)
		{
			spawnVeh(VEHICLE_BANSHEE);
		}
		else if (GET() == 13)
		{
			spawnVeh(VEHICLE_COMET2);
		}
		else if (GET() == 14)
		{
			spawnVeh(VEHICLE_SCHWARZER);
		}
		else if (GET() == 15)
		{
			spawnVeh(VEHICLE_FUSILADE);
		}
		else if (GET() == 16)
		{
			spawnVeh(VEHICLE_BUFFALO);
		}
		else if (GET() == 17)
		{
			spawnVeh(VEHICLE_BUFFALO2);
		}
		else if (GET() == 18)
		{
			spawnVeh(VEHICLE_PENUMBRA);
		}
		else if (GET() == 19)
		{
			spawnVeh(VEHICLE_SULTAN);
		}
		else if (GET() == 20)
		{
			spawnVeh(VEHICLE_FUTO);
		}
		else if (GET() == 21)
		{
			spawnVeh(VEHICLE_FUROREGT);
		}
		else if (GET() == 22)
		{
			spawnVeh(VEHICLE_MASSACRO);
		}
		else if (GET() == 23)
		{
			spawnVeh(VEHICLE_MASSACRO2);
		}
		else if (GET() == 24)
		{
			spawnVeh(VEHICLE_JESTER);
		}
		else if (GET() == 25)
		{
			spawnVeh(VEHICLE_JESTER2);
		}
		else if (GET() == 26)
		{
			spawnVeh(VEHICLE_WINDSOR);
		}
		else if (GET() == 27)
		{
			spawnVeh(VEHICLE_ALPHA);
		}
		else if (GET() == 28)
		{
		spawnVeh(VEHICLE_KURUMA);
		}
		else if (GET() == 29)
		{
		spawnVeh(VEHICLE_KURUMA2);
		}
	}

	if (NumMenu == SportiveC_Car)
	{
		AddTitle("Cyber Mod Loader");
		addOption("Coquette classic");
		addOption("Coquette blackfin");
		addOption("Z-Type");
		addOption("Stinger");
		addOption("Stinger GT");
		addOption("Monroe");
		addOption("JB 700");
		addOption("Tornado");
		addOption("Tornado cabrio");
		addOption("Tornado rusty");
		addOption("Tornado mexican");
		addOption("Peyote");
		addOption("Manana");
		addOption("Virgo");
		addOption("Roosevelt");
		addOption("Blade");
		addOption("Glendale");
		addOption("Pigalle");
		addOption("Casco");
		addOption("Chino");
		AddSubTitle("Classic Vehicles");

		if (GET() == 1)
		{
			spawnVeh(VEHICLE_COQUETTE2);
		}
		else if (GET() == 2)
		{
			spawnVeh(VEHICLE_COQUETTE3);
		}
		else if (GET() == 3)
		{
			spawnVeh(VEHICLE_ZTYPE);
		}
		else if (GET() == 4)
		{
			spawnVeh(VEHICLE_STINGER);
		}
		else if (GET() == 5)
		{
			spawnVeh(VEHICLE_STINGERGT);
		}
		else if (GET() == 6)
		{
			spawnVeh(VEHICLE_MONROE);
		}
		else if (GET() == 7)
		{
			spawnVeh(VEHICLE_JB700);
		}
		else if (GET() == 8)
		{
			spawnVeh(VEHICLE_TORNADO);
		}
		else if (GET() == 9)
		{
			spawnVeh(VEHICLE_TORNADO2);
		}
		else if (GET() == 10)
		{
			spawnVeh(VEHICLE_TORNADO3);
		}
		else if (GET() == 11)
		{
			spawnVeh(VEHICLE_TORNADO4);
		}
		else if (GET() == 12)
		{
			spawnVeh(VEHICLE_PEYOTE);
		}
		else if (GET() == 13)
		{
			spawnVeh(VEHICLE_MANANA);
		}
		else if (GET() == 14)
		{
			spawnVeh(VEHICLE_VIRGO);
		}
		else if (GET() == 15)
		{
			spawnVeh(VEHICLE_BTYPE);
		}
		else if (GET() == 16)
		{
			spawnVeh(VEHICLE_BLADE);
		}
		else if (GET() == 17)
		{
			spawnVeh(VEHICLE_GLENDALE);
		}
		else if (GET() == 18)
		{
			spawnVeh(VEHICLE_PIGALLE);
		}
		else if (GET() == 19)
		{
			spawnVeh(VEHICLE_CASCO);
		}
		else if (GET() == 20)
		{
			spawnVeh(VEHICLE_CHINO);
		}
	}

	if (NumMenu == Muscle_Car)
	{
		AddTitle("Cyber Mod Loader");
		addOption("Hotknife");
		addOption("Gauntlet");
		addOption("Vigero");
		addOption("Dominator");
		addOption("Buccaneer");
		addOption("Phoenix");
		addOption("Sabre Turbo");
		addOption("Ruiner");
		addOption("Voodoo");
		addOption("Picador");
		addOption("Ratloader");
		addOption("Rat-Truck");
		AddSubTitle("Muscle Cars");

		if (GET() == 1)
		{
			spawnVeh(VEHICLE_HOTKNIFE);
		}
		else if (GET() == 2)
		{
			spawnVeh(VEHICLE_GAUNTLET);
		}
		else if (GET() == 3)
		{
			spawnVeh(VEHICLE_VIGERO);
		}
		else if (GET() == 4)
		{
			spawnVeh(VEHICLE_DOMINATOR);
		}
		else if (GET() == 5)
		{
			spawnVeh(VEHICLE_BUCCANEER);
		}
		else if (GET() == 6)
		{
			spawnVeh(VEHICLE_PHOENIX);
		}
		else if (GET() == 7)
		{
			spawnVeh(VEHICLE_SABREGT);
		}
		else if (GET() == 8)
		{
			spawnVeh(VEHICLE_RUINER);
		}
		else if (GET() == 9)
		{
			spawnVeh(VEHICLE_VOODOO2);
		}
		else if (GET() == 10)
		{
			spawnVeh(VEHICLE_PICADOR);
		}
		else if (GET() == 11)
		{
			spawnVeh(VEHICLE_RATLOADER);
		}
		else if (GET() == 12)
		{
			spawnVeh(VEHICLE_RATLOADER2);
		}
	}

	if (NumMenu == Coupes_Car)
	{
		AddTitle("Cyber Mod Loader");
		addOption("Exemplar");
		addOption("Cabrio");
		addOption("Felon");
		addOption("Felon GT");
		addOption("Zion");
		addOption("Zion Cabrio");
		addOption("Sentinel");
		addOption("Sentinel XS");
		addOption("Ocelot Jackal");
		addOption("F620");
		AddSubTitle("Coupes");

		if (GET() == 1)
		{
			spawnVeh(VEHICLE_EXEMPLAR);
		}
		else if (GET() == 2)
		{
			spawnVeh(VEHICLE_COGCABRIO);
		}
		else if (GET() == 3)
		{
			spawnVeh(VEHICLE_FELON);
		}
		else if (GET() == 4)
		{
			spawnVeh(VEHICLE_FELON2);
		}
		else if (GET() == 5)
		{
			spawnVeh(VEHICLE_ZION);
		}
		else if (GET() == 6)
		{
			spawnVeh(VEHICLE_ZION2);
		}
		else if (GET() == 7)
		{
			spawnVeh(VEHICLE_SENTINEL2);
		}
		else if (GET() == 8)
		{
			spawnVeh(VEHICLE_SENTINEL);
		}
		else if (GET() == 9)
		{
			spawnVeh(VEHICLE_JACKAL);
		}
		else if (GET() == 10)
		{
			spawnVeh(VEHICLE_F620);
		}
	}

	if (NumMenu == Compact_Car)
	{
		AddTitle("Cyber Mod Loader");
		addOption("Dilettante");
		addOption("Dilettante patrol");
		addOption("Issi");
		addOption("Prairie");
		addOption("Blista");
		addOption("Rhapsody");
		addOption("Warrener");
		addOption("Panto");
		AddSubTitle("Compact Vehicles");

		if (GET() == 1)
		{
			spawnVeh(VEHICLE_DILETTANTE);
		}
		else if (GET() == 2)
		{
			spawnVeh(VEHICLE_DILETTANTE2);
		}
		else if (GET() == 3)
		{
			spawnVeh(VEHICLE_ISSI2);
		}
		else if (GET() == 4)
		{
			spawnVeh(VEHICLE_PRAIRIE);
		}
		else if (GET() == 5)
		{
			spawnVeh(VEHICLE_BLISTA);
		}
		else if (GET() == 6)
		{
			spawnVeh(VEHICLE_RHAPSODY);
		}
		else if (GET() == 7)
		{
			spawnVeh(VEHICLE_WARRENER);
		}
		else if (GET() == 8)
		{
			spawnVeh(VEHICLE_PANTO);
		}
	}

	if (NumMenu == Sedans_Car)
	{
		AddTitle("Cyber Mod Loader");
		addOption("Asea");
		addOption("Asterope");
		addOption("Emperor");
		addOption("Emperor rusty");
		addOption("Limousine");
		addOption("Fugitive");
		addOption("Intruder");
		addOption("Oracle");
		addOption("Oracle XS");
		addOption("Premier");
		addOption("Primo");
		addOption("Regina");
		addOption("Romero");
		addOption("Tailgater");
		addOption("Stanier");
		addOption("Stratum");
		addOption("Surge");
		addOption("Schafter");
		addOption("Washington");
		AddSubTitle("Sedans");

		if (GET() == 1)
		{
			spawnVeh(VEHICLE_ASEA);
		}
		else if (GET() == 2)
		{
			spawnVeh(VEHICLE_ASTEROPE);
		}
		else if (GET() == 3)
		{
			spawnVeh(VEHICLE_EMPEROR);
		}
		else if (GET() == 4)
		{
			spawnVeh(VEHICLE_EMPEROR2);
		}
		else if (GET() == 5)
		{
			spawnVeh(VEHICLE_STRETCH);
		}
		else if (GET() == 6)
		{
			spawnVeh(VEHICLE_FUGITIVE);
		}
		else if (GET() == 7)
		{
			spawnVeh(VEHICLE_INTRUDER);
		}
		else if (GET() == 8)
		{
			spawnVeh(VEHICLE_ORACLE2);
		}
		else if (GET() == 9)
		{
			spawnVeh(VEHICLE_ORACLE);
		}
		else if (GET() == 10)
		{
			spawnVeh(VEHICLE_PREMIER);
		}
		else if (GET() == 11)
		{
			spawnVeh(VEHICLE_PRIMO);
		}
		else if (GET() == 12)
		{
			spawnVeh(VEHICLE_REGINA);
		}
		else if (GET() == 13)
		{
			spawnVeh(VEHICLE_ROMERO);
		}
		else if (GET() == 14)
		{
			spawnVeh(VEHICLE_TAILGATER);
		}
		else if (GET() == 15)
		{
			spawnVeh(VEHICLE_STANIER);
		}
		else if (GET() == 16)
		{
			spawnVeh(VEHICLE_STRATUM);
		}
		else if (GET() == 17)
		{
			spawnVeh(VEHICLE_SURGE);
		}
		else if (GET() == 18)
		{
			spawnVeh(VEHICLE_SCHAFTER2);
		}
		else if (GET() == 19)
		{
			spawnVeh(VEHICLE_WASHINGTON);
		}
	}

	if (NumMenu == SUVTrucks_Car)
	{
		AddTitle("Cyber Mod Loader");
		addOption("Baller");
		addOption("Baller 2");
		addOption("Rocoto");
		addOption("Dubsta");
		addOption("Dubsta gang");
		addOption("Dubsta 6x6");
		addOption("Serrano");
		addOption("Landstalker");
		addOption("FQ 2");
		addOption("Patriot");
		addOption("Habanero");
		addOption("Radius");
		addOption("Granger");
		addOption("Mesa");
		addOption("Mesa merryweather");
		addOption("Seminole");
		addOption("Kalahari");
		addOption("Gresley");
		addOption("BeeJay XL");
		addOption("Huntley S");
		addOption("Sadler");
		addOption("Guardian");
		addOption("Cavalcade");
		addOption("Cavalcade 2");
		AddSubTitle("SUV Vehicles");

		if (GET() == 1)
		{
			spawnVeh(VEHICLE_BALLER);
		}
		else if (GET() == 2)
		{
			spawnVeh(VEHICLE_BALLER2);
		}
		else if (GET() == 3)
		{
			spawnVeh(VEHICLE_ROCOTO);
		}
		else if (GET() == 4)
		{
			spawnVeh(VEHICLE_DUBSTA);
		}
		else if (GET() == 5)
		{
			spawnVeh(VEHICLE_DUBSTA2);
		}
		else if (GET() == 6)
		{
			spawnVeh(VEHICLE_DUBSTA3);
		}
		else if (GET() == 7)
		{
			spawnVeh(VEHICLE_SERRANO);
		}
		else if (GET() == 8)
		{
			spawnVeh(VEHICLE_LANDSTALKER);
		}
		else if (GET() == 9)
		{
			spawnVeh(VEHICLE_FQ2);
		}
		else if (GET() == 10)
		{
			spawnVeh(VEHICLE_PATRIOT);
		}
		else if (GET() == 11)
		{
			spawnVeh(VEHICLE_HABANERO);
		}
		else if (GET() == 12)
		{
			spawnVeh(VEHICLE_RADI);
		}
		else if (GET() == 13)
		{
			spawnVeh(VEHICLE_GRANGER);
		}
		else if (GET() == 14)
		{
			spawnVeh(VEHICLE_MESA);
		}
		else if (GET() == 15)
		{
			spawnVeh(VEHICLE_MESA3);
		}
		else if (GET() == 16)
		{
			spawnVeh(VEHICLE_SEMINOLE);
		}
		else if (GET() == 17)
		{
			spawnVeh(VEHICLE_KALAHARI);
		}
		else if (GET() == 18)
		{
			spawnVeh(VEHICLE_GRESLEY);
		}
		else if (GET() == 19)
		{
			spawnVeh(VEHICLE_BJXL);
		}
		else if (GET() == 20)
		{
			spawnVeh(VEHICLE_HUNTLEY);
		}
		else if (GET() == 21)
		{
			spawnVeh(VEHICLE_SADLER);
		}
		else if (GET() == 22)
		{
			spawnVeh(VEHICLE_GUARDIAN);
		}
		else if (GET() == 23)
		{
			spawnVeh(VEHICLE_CAVALCADE);
		}
		else if (GET() == 24)
		{
			spawnVeh(VEHICLE_CAVALCADE2);
		}
	}

	if (NumMenu == OFFRoad_Car)
	{
		AddTitle("Cyber Mod Loader");
		addOption("Liberator");
		addOption("Sandking XL");
		addOption("Sandking SWB");
		addOption("Dune Buggy");
		addOption("Space Docker");
		addOption("BF Injection");
		addOption("Bifta");
		addOption("Blazer");
		addOption("Blazer lifeguard");
		addOption("Blazer Trevor");
		addOption("DuneLoader");
		addOption("Bodhi");
		addOption("Rancher XL");
		addOption("Rebel");
		addOption("Rebel rusty");
		addOption("Brawler");
		addOption("Insurgent");
		addOption("Insurgent armed");
		addOption("Technical");
		AddSubTitle("Off Road Vehicles"); 
		
		if (GET() == 1)
		{
			spawnVeh(VEHICLE_MONSTER);
		}
		else if (GET() == 2)
		{
			spawnVeh(VEHICLE_SANDKING);
		}
		else if (GET() == 3)
		{
			spawnVeh(VEHICLE_SANDKING2);
		}
		else if (GET() == 4)
		{
			spawnVeh(VEHICLE_DUNE);
		}
		else if (GET() == 5)
		{
			spawnVeh(VEHICLE_DUNE2);
		}
		else if (GET() == 6)
		{
			spawnVeh(VEHICLE_BFINJECTION);
		}
		else if (GET() == 7)
		{
			spawnVeh(VEHICLE_BIFTA);
		}
		else if (GET() == 8)
		{
			spawnVeh(VEHICLE_BLAZER);
		}
		else if (GET() == 9)
		{
			spawnVeh(VEHICLE_BLAZER2);
		}
		else if (GET() == 10)
		{
			spawnVeh(VEHICLE_BLAZER3);
		}
		else if (GET() == 11)
		{
			spawnVeh(VEHICLE_DLOADER);
		}
		else if (GET() == 12)
		{
			spawnVeh(VEHICLE_BODHI2);
		}
		else if (GET() == 13)
		{
			spawnVeh(VEHICLE_RANCHERXL);
		}
		else if (GET() == 14)
		{
			spawnVeh(VEHICLE_REBEL2);
		}
		else if (GET() == 15)
		{
			spawnVeh(VEHICLE_REBEL);
		}
		else if (GET() == 16)
		{
			spawnVeh(VEHICLE_BRAWLER);
		}
		else if (GET() == 17)
		{
			spawnVeh(VEHICLE_INSURGENT2);
		}
		else if (GET() == 18)
		{
			spawnVeh(VEHICLE_INSURGENT);
		}
		else if (GET() == 19)
		{
			spawnVeh(VEHICLE_TECHNICAL);
		}
	}

	if (NumMenu == Vans_Car)
	{
		AddTitle("Cyber Mod Loader");
		addOption("Bobcat XL");
		addOption("Boxville");
		addOption("Boxville 2");
		addOption("Boxville 3");
		addOption("Boxville 4");
		addOption("Speedo");
		addOption("Speedo Clown");
		addOption("Bison");
		addOption("Bison 2");
		addOption("Bison 3");
		addOption("Burrito");
		addOption("Burrito 2");
		addOption("Burrito 3");
		addOption("Burrito 4");
		addOption("Journey");
		addOption("Minivan");
		addOption("Paradise");
		addOption("Pony");
		addOption("Pony Weed");
		addOption("Rumpo");
		addOption("Rumpo 2");
		addOption("Slamvan");
		addOption("Slamvan 2");
		addOption("Surfer");
		addOption("Surfer rusty");
		addOption("Taco Van");
		addOption("Youga");
		AddSubTitle("Vans");

		if (GET() == 1)
		{
			spawnVeh(VEHICLE_BOBCATXL);
		}
		else if (GET() == 2)
		{
			spawnVeh(VEHICLE_BOXVILLE);
		}
		else if (GET() == 3)
		{
			spawnVeh(VEHICLE_BOXVILLE2);
		}
		else if (GET() == 4)
		{
			spawnVeh(VEHICLE_BOXVILLE3);
		}
		else if (GET() == 5)
		{
			spawnVeh(VEHICLE_BOXVILLE4);
		}
		else if (GET() == 6)
		{
			spawnVeh(VEHICLE_SPEEDO);
		}
		else if (GET() == 7)
		{
			spawnVeh(VEHICLE_SPEEDO2);
		}
		else if (GET() == 8)
		{
			spawnVeh(VEHICLE_BISON);
		}
		else if (GET() == 9)
		{
			spawnVeh(VEHICLE_BISON2);
		}
		else if (GET() == 10)
		{
			spawnVeh(VEHICLE_BISON3);
		}
		else if (GET() == 11)
		{
			spawnVeh(VEHICLE_BURRITO);
		}
		else if (GET() == 12)
		{
			spawnVeh(VEHICLE_BURRITO2);
		}
		else if (GET() == 13)
		{
			spawnVeh(VEHICLE_BURRITO3);
		}
		else if (GET() == 14)
		{
			spawnVeh(VEHICLE_BURRITO4);
		}
		else if (GET() == 15)
		{
			spawnVeh(VEHICLE_JOURNEY);
		}
		else if (GET() == 16)
		{
			spawnVeh(VEHICLE_MINIVAN);
		}
		else if (GET() == 17)
		{
			spawnVeh(VEHICLE_PARADISE);
		}
		else if (GET() == 18)
		{
			spawnVeh(VEHICLE_PONY);
		}
		else if (GET() == 19)
		{
			spawnVeh(VEHICLE_PONY2);
		}
		else if (GET() == 20)
		{
			spawnVeh(VEHICLE_RUMPO);
		}
		else if (GET() == 21)
		{
			spawnVeh(VEHICLE_RUMPO2);
		}
		else if (GET() == 22)
		{
			spawnVeh(VEHICLE_SLAMVAN);
		}
		else if (GET() == 23)
		{
			spawnVeh(VEHICLE_SLAMVAN2);
		}
		else if (GET() == 24)
		{
			spawnVeh(VEHICLE_SURFER);
		}
		else if (GET() == 25)
		{
			spawnVeh(VEHICLE_SURFER2);
		}
		else if (GET() == 26)
		{
			spawnVeh(VEHICLE_TACO);
		}
		else if (GET() == 27)
		{
			spawnVeh(VEHICLE_YOUGA);
		}
	}

	if (NumMenu == Emergency_Car)
	{
		AddTitle("Cyber Mod Loader");
		addOption("FIB buffalo");
		addOption("FIB granger");
		addOption("Firetruck");
		addOption("Ambulance");
		addOption("Police stanier");
		addOption("Police buffalo");
		addOption("Police interceptor");
		addOption("Unmarked car");
		addOption("Police bike");
		addOption("Police Van");
		addOption("Police RIOT");
		addOption("Sheriff stanier");
		addOption("Sheriff granger");
		addOption("Prison Bus");
		addOption("Park Ranger");
		addOption("SUV lifeguard");
		AddSubTitle("Emergency Vehicles");

		if (GET() == 1)
		{
			spawnVeh(VEHICLE_FBI);
		}
		else if (GET() == 2)
		{
			spawnVeh(VEHICLE_FBI2);
		}
		else if (GET() == 3)
		{
			spawnVeh(VEHICLE_FIRETRUK);
		}
		else if (GET() == 4)
		{
			spawnVeh(VEHICLE_AMBULANCE);
		}
		else if (GET() == 5)
		{
			spawnVeh(VEHICLE_POLICE);
		}
		else if (GET() == 6)
		{
			spawnVeh(VEHICLE_POLICE2);
		}
		else if (GET() == 7)
		{
			spawnVeh(VEHICLE_POLICE3);
		}
		else if (GET() == 8)
		{
			spawnVeh(VEHICLE_POLICE4);
		}
		else if (GET() == 9)
		{
			spawnVeh(VEHICLE_POLICEB);
		}
		else if (GET() == 10)
		{
			spawnVeh(VEHICLE_POLICET);
		}
		else if (GET() == 11)
		{
			spawnVeh(VEHICLE_RIOT);
		}
		else if (GET() == 12)
		{
			spawnVeh(VEHICLE_SHERIFF);
		}
		else if (GET() == 13)
		{
			spawnVeh(VEHICLE_SHERIFF2);
		}
		else if (GET() == 14)
		{
			spawnVeh(VEHICLE_PBUS);
		}
		else if (GET() == 15)
		{
			spawnVeh(VEHICLE_PRANGER);
		}
		else if (GET() == 16)
		{
			spawnVeh(VEHICLE_LGUARD);
		}
	}

	if (NumMenu == Service_Car)
	{
		AddTitle("Cyber Mod Loader");
		addOption("Bus airport");
		addOption("Bus");
		addOption("Bus dashhound");
		addOption("Bus of rent");
		addOption("Bus tourist");
		addOption("Taxi");
		addOption("Large towtruck");
		addOption("Small towtruck");
		AddSubTitle("Service Vehicles");

		if (GET() == 1)
		{
			spawnVeh(VEHICLE_AIRBUS);
		}
		else if (GET() == 2)
		{
			spawnVeh(VEHICLE_BUS);
		}
		else if (GET() == 3)
		{
			spawnVeh(VEHICLE_COACH);
		}
		else if (GET() == 4)
		{
			spawnVeh(VEHICLE_RENTALBUS);
		}
		else if (GET() == 5)
		{
			spawnVeh(VEHICLE_TOURBUS);
		}
		else if (GET() == 6)
		{
			spawnVeh(VEHICLE_TAXI);
		}
		else if (GET() == 7)
		{
			spawnVeh(VEHICLE_TOWTRUCK);
		}
		else if (GET() == 8)
		{
			spawnVeh(VEHICLE_TOWTRUCK2);
		}
	}

	if (NumMenu == Commercial_Car)
	{
		AddTitle("Cyber Mod Loader");
		addOption("Mule");
		addOption("Phantom");
		addOption("Benson");
		addOption("Packer");
		addOption("Pounder");
		addOption("Hauler");
		addOption("Stockade");
		addOption("Biff");
		addOption("Large dumptruck");
		addOption("Bulldozer");
		addOption("Forklift");
		addOption("Container carrier");
		addOption("Cutter");
		addOption("Dump truck");
		addOption("Dump truck rusty");
		addOption("Tipper");
		addOption("Brute tipper");
		addOption("Mixer");
		addOption("Car carrier");
		addOption("Ripley");
		addOption("Scrap metal truck");
		addOption("Lawn mower");
		addOption("Docktug");
		addOption("Airtug");
		addOption("Tractor old");
		addOption("Tractor farm");
		addOption("Caddy");
		addOption("Caddy old");
		AddSubTitle("Commercial Vehicles");

		if (GET() == 1)
		{
			spawnVeh(VEHICLE_MULE2);
		}
		else if (GET() == 2)
		{
			spawnVeh(VEHICLE_PHANTOM);
		}
		else if (GET() == 3)
		{
			spawnVeh(VEHICLE_BENSON);
		}
		else if (GET() == 4)
		{
			spawnVeh(VEHICLE_PACKER);
		}
		else if (GET() == 5)
		{
			spawnVeh(VEHICLE_POUNDER);
		}
		else if (GET() == 6)
		{
			spawnVeh(VEHICLE_HAULER);
		}
		else if (GET() == 7)
		{
			spawnVeh(VEHICLE_STOCKADE);
		}
		else if (GET() == 8)
		{
			spawnVeh(VEHICLE_BIFF);
		}
		else if (GET() == 9)
		{
			spawnVeh(VEHICLE_DUMP);
		}
		else if (GET() == 10)
		{
			spawnVeh(VEHICLE_BULLDOZER);
		}
		else if (GET() == 11)
		{
			spawnVeh(VEHICLE_FORKLIFT);
		}
		else if (GET() == 12)
		{
			spawnVeh(VEHICLE_HANDLER);
		}
		else if (GET() == 13)
		{
			spawnVeh(VEHICLE_CUTTER);
		}
		else if (GET() == 14)
		{
			spawnVeh(VEHICLE_TRASH);
		}
		else if (GET() == 15)
		{
			spawnVeh(VEHICLE_TRASH2);
		}
		else if (GET() == 16)
		{
			spawnVeh(VEHICLE_TIPTRUCK2);
		}
		else if (GET() == 17)
		{
			spawnVeh(VEHICLE_TIPTRUCK);
		}
		else if (GET() == 18)
		{
			spawnVeh(VEHICLE_MIXER2);
		}
		else if (GET() == 19)
		{
			spawnVeh(VEHICLE_FLATBED);
		}
		else if (GET() == 20)
		{
			spawnVeh(VEHICLE_RIPLEY);
		}
		else if (GET() == 21)
		{
			spawnVeh(VEHICLE_SCRAP);
		}
		else if (GET() == 22)
		{
			spawnVeh(VEHICLE_MOWER);
		}
		else if (GET() == 23)
		{
			spawnVeh(VEHICLE_DOCKTUG);
		}
		else if (GET() == 24)
		{
			spawnVeh(VEHICLE_AIRTUG);
		}
		else if (GET() == 25)
		{
			spawnVeh(VEHICLE_TRACTOR);
		}
		else if (GET() == 26)
		{
			spawnVeh(VEHICLE_TRACTOR2);
		}
		else if (GET() == 27)
		{
			spawnVeh(VEHICLE_CADDY);
		}
		else if (GET() == 28)
		{
			spawnVeh(VEHICLE_CADDY2);
		}
	}

	if (NumMenu == Military_Car)
	{
		AddTitle("Cyber Mod Loader");
		addOption("4x4 Crusader");
		addOption("Barracks");
		addOption("Barracks semi");
		addOption("Barracks movie");
		addOption("Rhino Tank");
		AddSubTitle("Military Vehicles");

		if (GET() == 1)
		{
			spawnVeh(VEHICLE_CRUSADER);
		}
		else if (GET() == 2)
		{
			spawnVeh(VEHICLE_BARRACKS);
		}
		else if (GET() == 3)
		{
			spawnVeh(VEHICLE_BARRACKS2);
		}
		else if (GET() == 4)
		{
			spawnVeh(VEHICLE_BARRACKS3);
		}
		else if (GET() == 5)
		{
			spawnVeh(VEHICLE_RHINO);
		}
	}

	if (NumMenu == Moto_Car)
	{
		AddTitle("Cyber Mod Loader");
		addOption("Carbon RS");
		addOption("Bati 801");
		addOption("Bati 801RR");
		addOption("Hexer");
		addOption("Innovation");
		addOption("Double-T");
		addOption("Thrust");
		addOption("Vindicator");
		addOption("Ruffian");
		addOption("Vader");
		addOption("PCJ 600");
		addOption("Hakuchou");
		addOption("Akuma");
		addOption("Sanchez (colors)");
		addOption("Sanchez");
		addOption("Faggio");
		addOption("Daemon");
		addOption("Bagger");
		addOption("Nemesis");
		addOption("Sovereign");
		addOption("Enduro");
		addOption("Lectro");
		AddSubTitle("Motorcycles");

		if (GET() == 1)
		{
			spawnVeh(VEHICLE_CARBONRS);
		}
		else if (GET() == 2)
		{
			spawnVeh(VEHICLE_BATI);
		}
		else if (GET() == 3)
		{
			spawnVeh(VEHICLE_BATI2);
		}
		else if (GET() == 4)
		{
			spawnVeh(VEHICLE_HEXER);
		}
		else if (GET() == 5)
		{
			spawnVeh(VEHICLE_INNOVATION);
		}
		else if (GET() == 6)
		{
			spawnVeh(VEHICLE_DOUBLE);
		}
		else if (GET() == 7)
		{
			spawnVeh(VEHICLE_THRUST);
		}
		else if (GET() == 8)
		{
			spawnVeh(VEHICLE_VINDICATOR);
		}
		else if (GET() == 9)
		{
			spawnVeh(VEHICLE_RUFFIAN);
		}
		else if (GET() == 10)
		{
			spawnVeh(VEHICLE_VADER);
		}
		else if (GET() == 11)
		{
			spawnVeh(VEHICLE_PCJ);
		}
		else if (GET() == 12)
		{
			spawnVeh(VEHICLE_HAKUCHOU);
		}
		else if (GET() == 13)
		{
			spawnVeh(VEHICLE_AKUMA);
		}
		else if (GET() == 14)
		{
			spawnVeh(VEHICLE_SANCHEZ2);
		}
		else if (GET() == 15)
		{
			spawnVeh(VEHICLE_SANCHEZ);
		}
		else if (GET() == 16)
		{
			spawnVeh(VEHICLE_FAGGIO2);
		}
		else if (GET() == 17)
		{
			spawnVeh(VEHICLE_DAEMON);
		}
		else if (GET() == 18)
		{
			spawnVeh(VEHICLE_BAGGER);
		}
		else if (GET() == 19)
		{
			spawnVeh(VEHICLE_NEMESIS);
		}
		else if (GET() == 20)
		{
			spawnVeh(VEHICLE_SOVEREIGN);
		}
		else if (GET() == 21)
		{
			spawnVeh(VEHICLE_ENDURO);
		}
		else if (GET() == 22)
		{
			spawnVeh(VEHICLE_LECTRO);
		}
	}

	if (NumMenu == Bicycles)
	{
		AddTitle("Cyber Mod Loader");
		addOption("BMX");
		addOption("Cruiser");
		addOption("Endurex");
		addOption("Fixter");
		addOption("Scorcher");
		addOption("Tri-cycles");
		addOption("Whippet");
		AddSubTitle("Bicycles");

		if (GET() == 1)
		{
			spawnVeh(VEHICLE_BMX);
		}
		else if (GET() == 2)
		{
			spawnVeh(VEHICLE_CRUISER);
		}
		else if (GET() == 3)
		{
			spawnVeh(VEHICLE_TRIBIKE2);
		}
		else if (GET() == 4)
		{
			spawnVeh(VEHICLE_FIXTER);
		}
		else if (GET() == 5)
		{
			spawnVeh(VEHICLE_SCORCHER);
		}
		else if (GET() == 6)
		{
			spawnVeh(VEHICLE_TRIBIKE3);
		}
		else if (GET() == 7)
		{
			spawnVeh(VEHICLE_TRIBIKE);
		}
	}

	if (NumMenu == Helicopters_Car)
	{
		AddTitle("Cyber Mod Loader");
		addOption("Annihilator");
		addOption("Buzzard");
		addOption("Buzzard attack");
		addOption("Frogger");
		addOption("Frogger Trevor");
		addOption("Maverick");
		addOption("Cargobob");
		addOption("Cargobob rescue");
		addOption("Maverick police");
		addOption("Swift");
		addOption("Swift deluxe");
		addOption("Valkyrie");
		addOption("Savage");
		addOption("Skylift");
		AddSubTitle("Helicopters");

		if (GET() == 1)
		{
			spawnVeh(VEHICLE_ANNIHILATOR);
		}
		else if (GET() == 2)
		{
			spawnVeh(VEHICLE_BUZZARD2);
		}
		else if (GET() == 3)
		{
			spawnVeh(VEHICLE_BUZZARD);
		}
		else if (GET() == 4)
		{
			spawnVeh(VEHICLE_FROGGER);
		}
		else if (GET() == 5)
		{
			spawnVeh(VEHICLE_FROGGER2);
		}
		else if (GET() == 6)
		{
			spawnVeh(VEHICLE_MAVERICK);
		}
		else if (GET() == 7)
		{
			spawnVeh(VEHICLE_CARGOBOB);
		}
		else if (GET() == 8)
		{
			spawnVeh(VEHICLE_CARGOBOB2);
		}
		else if (GET() == 9)
		{
			spawnVeh(VEHICLE_POLMAV);
		}
		else if (GET() == 10)
		{
			spawnVeh(VEHICLE_SWIFT);
		}
		else if (GET() == 11)
		{
			spawnVeh(VEHICLE_SWIFT2);
		}
		else if (GET() == 12)
		{
			spawnVeh(VEHICLE_VALKYRIE);
		}
		else if (GET() == 13)
		{
			spawnVeh(VEHICLE_SAVAGE);
		}
		else if (GET() == 14)
		{
			spawnVeh(VEHICLE_SKYLIFT);
		}
	}

	if (NumMenu == Planes_Car)
	{
		AddTitle("Cyber Mod Loader");
		addOption("Titan");
		addOption("Luxor");
		addOption("Luxor deluxe");
		addOption("Shamal");
		addOption("Vestra");
		addOption("Miljet");
		addOption("Velum");
		addOption("Velum 5 seats");
		addOption("Mammatus");
		addOption("Duster");
		addOption("Mallard");
		addOption("Cuban 800");
		addOption("Cargo Plane");
		addOption("Blimp");
		addOption("P-996 Lazer");
		addOption("Jet");
		addOption("Besra");
		addOption("Hydra");
		AddSubTitle("Planes");

		if (GET() == 1)
		{
			spawnVeh(VEHICLE_TITAN);
		}
		else if (GET() == 2)
		{
			spawnVeh(VEHICLE_LUXOR);
		}
		else if (GET() == 3)
		{
			spawnVeh(VEHICLE_LUXOR2);
		}
		else if (GET() == 4)
		{
			spawnVeh(VEHICLE_SHAMAL);
		}
		else if (GET() == 5)
		{
			spawnVeh(VEHICLE_VESTRA);
		}
		else if (GET() == 6)
		{
			spawnVeh(VEHICLE_MILJET);
		}
		else if (GET() == 7)
		{
			spawnVeh(VEHICLE_VELUM);
		}
		else if (GET() == 8)
		{
			spawnVeh(VEHICLE_VELUM2);
		}
		else if (GET() == 9)
		{
			spawnVeh(VEHICLE_MAMMATUS);
		}
		else if (GET() == 10)
		{
			spawnVeh(VEHICLE_DUSTER);
		}
		else if (GET() == 11)
		{
			spawnVeh(VEHICLE_STUNT);
		}
		else if (GET() == 12)
		{
			spawnVeh(VEHICLE_CUBAN800);
		}
		else if (GET() == 13)
		{
			spawnVeh(VEHICLE_CARGOPLANE);
		}
		else if (GET() == 14)
		{
			spawnVeh(VEHICLE_BLIMP);
		}
		else if (GET() == 15)
		{
			spawnVeh(VEHICLE_LAZER);
		}
		else if (GET() == 16)
		{
			spawnVeh(VEHICLE_JET);
		}
		else if (GET() == 17)
		{
			spawnVeh(VEHICLE_BESRA);
		}
		else if (GET() == 18)
		{
			spawnVeh(VEHICLE_HYDRA);
		}
	}

	if (NumMenu == Boats_Car)
	{
		AddTitle("Cyber Mod Loader");
		addOption("Marquis");
		addOption("Jetmax");
		addOption("Squalo");
		addOption("Suntrap");
		addOption("Tropic");
		addOption("Seashark");
		addOption("Seashark lifeguard");
		addOption("Bateau police");
		addOption("Submersible");
		addOption("Speeder");
		addOption("Dinghy 2 seats");
		addOption("Dinghy 4 seats");
		addOption("Toro");
		AddSubTitle("Boats");

		if (GET() == 1)
		{
			spawnVeh(VEHICLE_MARQUIS);
		}
		else if (GET() == 2)
		{
			spawnVeh(VEHICLE_JETMAX);
		}
		else if (GET() == 3)
		{
			spawnVeh(VEHICLE_SQUALO);
		}
		else if (GET() == 4)
		{
			spawnVeh(VEHICLE_SUNTRAP);
		}
		else if (GET() == 5)
		{
			spawnVeh(VEHICLE_TROPIC);
		}
		else if (GET() == 6)
		{
			spawnVeh(VEHICLE_SEASHARK);
		}
		else if (GET() == 7)
		{
			spawnVeh(VEHICLE_SEASHARK2);
		}
		else if (GET() == 8)
		{
			spawnVeh(VEHICLE_PREDATOR);
		}
		else if (GET() == 9)
		{
			spawnVeh(VEHICLE_SUBMERSIBLE);
		}
		else if (GET() == 10)
		{
			spawnVeh(VEHICLE_SPEEDER);
		}
		else if (GET() == 11)
		{
			spawnVeh(VEHICLE_DINGHY2);
		}
		else if (GET() == 12)
		{
			spawnVeh(VEHICLE_DINGHY);
		}
		else if (GET() == 13)
		{
			spawnVeh(VEHICLE_TORO);
		}
	}

	if (NumMenu == Snow_Car)
	{
		AddTitle("Cyber Mod Loader");
		addOption("Asea");
		addOption("Burrito");
		addOption("Emperor");
		addOption("Rancher police");
		addOption("Esperanto police");
		addOption("Mesa");
		addOption("Rancher XL");
		addOption("Sadler");
		addOption("Stockade");
		addOption("Tractor");
		AddSubTitle("Snow Vehicles");

		if (GET() == 1)
		{
			spawnVeh(VEHICLE_ASEA2);
		}
		else if (GET() == 2)
		{
			spawnVeh(VEHICLE_BURRITO5);
		}
		else if (GET() == 3)
		{
			spawnVeh(VEHICLE_EMPEROR3);
		}
		else if (GET() == 4)
		{
			spawnVeh(VEHICLE_POLICEOLD1);
		}
		else if (GET() == 5)
		{
			spawnVeh(VEHICLE_POLICEOLD2);
		}
		else if (GET() == 6)
		{
			spawnVeh(VEHICLE_MESA2);
		}
		else if (GET() == 7)
		{
			spawnVeh(VEHICLE_RANCHERXL2);
		}
		else if (GET() == 8)
		{
			spawnVeh(VEHICLE_SADLER2);
		}
		else if (GET() == 9)
		{
			spawnVeh(VEHICLE_STOCKADE3);
		}
		else if (GET() == 10)
		{
			spawnVeh(VEHICLE_TRACTOR3);
		}
	}

	if (NumMenu == Most_used_veh)
	{
		AddTitle("Cyber Mod Loader");
		addOption("Spawn Zentorno");
		addOption("Spawn Adder");
		addOption("Spawn T20");
		addOption("Spawn Osiris");
		addOption("Spawn Armored Kuruma");
		addOption("Spawn Armed Insurgent");
		addOption("Spawn Carbonizzare");
		addOption("Spawn Police Interceptor");
		addOption("Spawn Taxi");
		addOption("Spawn Bulldozer");
		addOption("Spawn Tank");
		addOption("Spawn Buzzard");
		addOption("Spawn P-996 Lazer");
		addOption("Spawn Titan");
		addOption("Spawn Luxore Deluxe");
		AddSubTitle("Most used Vehicles");

		if (GET() == 1)
		{
			spawnVeh(VEHICLE_ZENTORNO);
		}
		else if (GET() == 2)
		{
			spawnVeh(VEHICLE_ADDER);
		}
		else if (GET() == 3)
		{
			spawnVeh(VEHICLE_T20);
		}
		else if (GET() == 4)
		{
			spawnVeh(VEHICLE_OSIRIS);
		}
		else if (GET() == 5)
		{
			spawnVeh(VEHICLE_KURUMA2);
		}
		else if (GET() == 6)
		{
			spawnVeh(VEHICLE_INSURGENT);
		}
		else if (GET() == 7)
		{
			spawnVeh(VEHICLE_CARBONIZZARE);
		}
		else if (GET() == 8)
		{
			spawnVeh(VEHICLE_POLICE3);
		}
		else if (GET() == 9)
		{
			spawnVeh(VEHICLE_TAXI);
		}
		else if (GET() == 10)
		{
			spawnVeh(VEHICLE_BULLDOZER);
		}
		else if (GET() == 11)
		{
			spawnVeh(VEHICLE_RHINO);
		}
		else if (GET() == 12)
		{
			spawnVeh(VEHICLE_BUZZARD);
		}
		else if (GET() == 13)
		{
			spawnVeh(VEHICLE_LAZER);
		}
		else if (GET() == 14)
		{
			spawnVeh(VEHICLE_TITAN);
		}
		else if (GET() == 15)
		{
			spawnVeh(VEHICLE_LUXOR2);
		}
	}
#pragma endregion
	
	if (NumMenu == Veh_ModShop)
	{
		AddTitle("Cyber Mod Loader");
		addOption("Max Upgrades");
		addOptionIntList("Engine Level", &engine, engineList, 0, 4);
		addOptionIntList("Transmission Type", &transmission, transmissionList, 0, 3);
		addOptionIntList("Armor Level", &armor, armorList, 0, 5);
		addOptionIntList("Suspensions Level", &suspension, suspensionList, 0, 4);
		addOptionIntList("Front Bumper Type", &fbumper, fbumperList, 0, 4);
		addOptionIntList("Rear Bumper Type", &rbumper, rbumperList, 0, 4);
		addOptionIntList("Exhaust Type", &exhaust, exhaustList, 0, 6);
		addOptionIntList("Spoiler Type", &spoiler, spoilerList, 0, 7);
		addOptionIntList("Brakes Level", &brakes, brakesList, 0, 3);
		addOptionIntList("Skirt Type", &skirt, skirtList, 0, 6);
		addOptionIntList("Hood Type", &hood, hoodList, 0, 5);
		addOptionIntList("Roof Type", &roof, roofList, 0, 5);
		addOptionIntList("Horn Type", &horn, hornList, 0, 37);
		addOptionIntList("Frame Type", &frame, frameList, 0, 4);
		addOptionIntList("Windows Type", &windows, windowsList, 0, 5);
		addOptionIntList("Headlights Type", &headlights, headlightsList, 0, 1);
		addOptionIntList("Tiresmoke Color", &tiresmoke, tiresmokeList, 0, 8);
		addOptionIntList("Roll Cage Type", &rollcage, rollcageList, 0, 5);
		addOptionIntList("Grille Type", &grille, grilleList, 0, 5);
		addOptionIntList("Plate Type", &platetype, platetypeList, 0, 5);
		addOptionIntList("Neons Color", &selneon, NeonList, 0, 9);
		FolderOption("Wheels  --->>", Wheels_Type);
		FolderOption("Vehicle Paint  --->>", Veh_Paint);
		addOption("Set Plate Text");
		CheckBox("Turbo", turbo);
		CheckBox("Custom Tires", customtires);
		CheckBox("Bulletproof Tires", bulletprooftires);
		AddSubTitle("Vehicle Mod Shop");

		if (GET() == 1)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_CUSTOM_PRIMARY_COLOUR(veh, 0, 0, 0);
			SET_VEHICLE_CUSTOM_SECONDARY_COLOUR(veh, 0, 0, 0);
			SET_VEHICLE_MOD_KIT(veh, 0);
			SET_VEHICLE_COLOURS(veh, 120, 120);
			SET_VEHICLE_NUMBER_PLATE_TEXT(veh, "CYBER");
			SET_VEHICLE_NUMBER_PLATE_TEXT_INDEX(veh, 1);
			TOGGLE_VEHICLE_MOD(veh, 18, 1);
			TOGGLE_VEHICLE_MOD(veh, 22, 1);
			SET_VEHICLE_MOD(veh, 16, 5, 0);
			SET_VEHICLE_MOD(veh, 12, 2, 0);
			SET_VEHICLE_MOD(veh, 11, 3, 0);
			SET_VEHICLE_MOD(veh, 14, 14, 0);
			SET_VEHICLE_MOD(veh, 15, 3, 0);
			SET_VEHICLE_MOD(veh, 13, 2, 0);
			SET_VEHICLE_WHEEL_TYPE(veh, 6);
			SET_VEHICLE_WINDOW_TINT(veh, 5);
			SET_VEHICLE_MOD(veh, 0, 1, 0);
			SET_VEHICLE_MOD(veh, 1, 1, 0);
			SET_VEHICLE_MOD(veh, 2, 1, 0);
			SET_VEHICLE_MOD(veh, 3, 1, 0);
			SET_VEHICLE_MOD(veh, 4, 1, 0);
			SET_VEHICLE_MOD(veh, 5, 1, 0);
			SET_VEHICLE_MOD(veh, 6, 1, 0);
			SET_VEHICLE_MOD(veh, 7, 1, 0);
			SET_VEHICLE_MOD(veh, 8, 1, 0);
			SET_VEHICLE_MOD(veh, 9, 1, 0);
			SET_VEHICLE_MOD(veh, 10, 1, 0);
			SET_VEHICLE_MOD(veh, 23, 19, 1);
			SET_VEHICLE_CUSTOM_PRIMARY_COLOUR(veh, 255, 0, 0);
		}
		else if (GET() == 2)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);

			if (engine == 0)
			{
				REMOVE_VEHICLE_MOD(veh, 11);
			}
			else
			{
				SET_VEHICLE_MOD(veh, 11, engine - 1, 0);
			}
		}
		else if (GET() == 3)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);

			if (transmission == 0)
			{
				REMOVE_VEHICLE_MOD(veh, 13);
			}
			else
			{
				SET_VEHICLE_MOD(veh, 13, transmission - 1, 0);
			}
		}
		else if (GET() == 4)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);

			if (armor == 0)
			{
				REMOVE_VEHICLE_MOD(veh, 16);
			}
			else
			{
				SET_VEHICLE_MOD(veh, 16, armor - 1, 0);
			}
		}
		else if (GET() == 5)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);

			if (suspension == 0)
			{
				REMOVE_VEHICLE_MOD(veh, 15);
			}
			else
			{
				SET_VEHICLE_MOD(veh, 15, suspension - 1, 0);
			}
		}
		else if (GET() == 6)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);

			if (fbumper == 0)
			{
				REMOVE_VEHICLE_MOD(veh, 1);
			}
			else
			{
				SET_VEHICLE_MOD(veh, 1, fbumper - 1, 0);
			}
		}
		else if (GET() == 7)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);

			if (rbumper == 0)
			{
				REMOVE_VEHICLE_MOD(veh, 2);
			}
			else
			{
				SET_VEHICLE_MOD(veh, 2, rbumper - 1, 0);
			}
		}
		else if (GET() == 8)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);

			if (exhaust == 0)
			{
				REMOVE_VEHICLE_MOD(veh, 4);
			}
			else
			{
				SET_VEHICLE_MOD(veh, 4, exhaust - 1, 0);
			}
		}
		else if (GET() == 9)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);

			if (spoiler == 0)
			{
				REMOVE_VEHICLE_MOD(veh, 0);
			}
			else
			{
				SET_VEHICLE_MOD(veh, 0, spoiler - 1, 0);
			}
		}
		else if (GET() == 10)
		{
		    Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
		    SET_VEHICLE_MOD_KIT(veh, 0);

		    if (brakes == 0)
		    {
			    REMOVE_VEHICLE_MOD(veh, 12);
		    }
		    else
		    {
			    SET_VEHICLE_MOD(veh, 12, brakes - 1, 0);
		    }
		}
		else if (GET() == 11)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);

			if (skirt == 0)
			{
				REMOVE_VEHICLE_MOD(veh, 3);
			}
			else
			{
				SET_VEHICLE_MOD(veh, 3, skirt - 1, 0);
			}
		}
		else if (GET() == 12)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);
			SET_VEHICLE_MOD(veh, 7, hood, 0);
		}
		else if (GET() == 13)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);

			if (roof == 0)
			{
				REMOVE_VEHICLE_MOD(veh, 10);
			}
			else
			{
				SET_VEHICLE_MOD(veh, 10, roof - 1, 0);
			}
		}
		else if (GET() == 14)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);

			if (horn == 0)
			{
				REMOVE_VEHICLE_MOD(veh, 14);
			}
			else
			{
				SET_VEHICLE_MOD(veh, 14, horn - 1, 0);
			}
		}
		else if (GET() == 15)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);

			if (frame == 0)
			{
				REMOVE_VEHICLE_MOD(veh, 5);
			}
			else
			{
				SET_VEHICLE_MOD(veh, 5, frame - 1, 0);
			}
		}
		else if (GET() == 16)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);

			if (windows == 0)
			{
				SET_VEHICLE_WINDOW_TINT(veh, 4);
			}
			else if (windows == 1)
			{
				SET_VEHICLE_WINDOW_TINT(veh, 3);
			}
			else if (windows == 2)
			{
				SET_VEHICLE_WINDOW_TINT(veh, 2);
			}
			else if (windows == 3)
			{
				SET_VEHICLE_WINDOW_TINT(veh, 5);
			}
			else if (windows == 4)
			{
				SET_VEHICLE_WINDOW_TINT(veh, 1);
			}
			else if (windows == 5)
			{
				SET_VEHICLE_WINDOW_TINT(veh, 7);
			}
		}
		else if (GET() == 17)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);

			if (headlights == 0)
			{
				REMOVE_VEHICLE_MOD(veh, 22);
			}
			else
			{
				SET_VEHICLE_MOD(veh, 22, headlights, 0);
			}
		}
		else if (GET() == 18)
		{
		    Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
		    SET_VEHICLE_MOD_KIT(veh, 0);
			TOGGLE_VEHICLE_MOD(veh, 20, 1);
			SET_VEHICLE_TYRE_SMOKE_COLOR(veh, TyreColors[tiresmoke]);
		}
		else if (GET() == 19)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);

			if (rollcage == 0)
			{
				REMOVE_VEHICLE_MOD(veh, 5);
			}
			else
			{
				SET_VEHICLE_MOD(veh, 5, rollcage, 0);
			}
		}
		else if (GET() == 20)
		{
		    Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
		    SET_VEHICLE_MOD_KIT(veh, 0);

		    if (grille == 0)
		    {
			    REMOVE_VEHICLE_MOD(veh, 6);
		    }
		    else
		    {
			    SET_VEHICLE_MOD(veh, 6, grille, 0);
		    }
		}
		else if (GET() == 21)
		{
		    Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
		    SET_VEHICLE_NUMBER_PLATE_TEXT_INDEX(veh, platetype);
		}
		else if (GET() == 22)
		{
		    if (selneon == 0)
		    {
				neonon = false;
			}
			else
			{
				neonon = true;
			}
		}
		else if (GET() == 25)
		{
		    Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
		    DISPLAY_ONSCREEN_KEYBOARD(0, "FMMC_KEY_TIP8", "", "", "", "", "", 8);
		    WAIT(100);
		    if (UPDATE_ONSCREEN_KEYBOARD() == 1)
		    {
			    const char *txt = GET_ONSCREEN_KEYBOARD_RESULT();
				SET_VEHICLE_NUMBER_PLATE_TEXT(veh, txt);
		    }
		}
		else if (GET() == 26)
		{
			turbo = !turbo;
		    Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);

			if (turbo)
			{
				TOGGLE_VEHICLE_MOD(veh, 18, 0);
			}
			else
			{
				TOGGLE_VEHICLE_MOD(veh, 18, 1);
			}
		}
		else if (GET() == 27)
		{
		    customtires = !customtires;
		    Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
		    SET_VEHICLE_MOD_KIT(veh, 0);

		    if (customtires)
		    {
				int tyre = GET_VEHICLE_MOD(veh, 23 );
				SET_VEHICLE_MOD(veh, 23, tyre, 1 );
		    }
		    else
		    {
				int tyre = GET_VEHICLE_MOD(veh, 23);
				SET_VEHICLE_MOD(veh, 23, tyre, 0);
		    }
		}
		else if (GET() == 28)
		{
			bulletprooftires = !bulletprooftires;
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);

			if (bulletprooftires)
			{
				SET_VEHICLE_TYRES_CAN_BURST(veh, false);
			}
			else
			{
				SET_VEHICLE_TYRES_CAN_BURST(veh, true);
			}
		}
	}

	if (NumMenu == Wheels_Type)
	{
		AddTitle("Cyber Mod Loader");
		addOptionIntList("Sport Wheels", &sportwheel, sportwList, 0, 23);
		addOptionIntList("Muscle Wheels", &musclewheel, musclewList, 0, 18);
		addOptionIntList("Low Rider Wheels", &lowriderwheel, lowriderwList, 0, 15);
		addOptionIntList("SUV Wheels", &suvwheel, suvwList, 0, 14);
		addOptionIntList("Off Road Wheels", &offroadwheel, offroadwList, 0, 10);
		addOptionIntList("Tuner Wheels", &tunerwheel, tunerwList, 0, 24);
		addOptionIntList("High End Wheels", &highendwheel, highendwList, 0, 19);
		addOptionIntList("Rim Color", &rimcolor, ColorsList, 0, 160);
		addOptionIntList("Rim Pearlescent Color", &rimpearlcolor, ColorsList, 0, 160);
		AddSubTitle("Wheels Type");

		if (GET() == 1)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);
			SET_VEHICLE_WHEEL_TYPE(veh, 0);
			SET_VEHICLE_MOD(veh, 23, sportwheel, customtires);
		}
		else if (GET() == 2)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);
			SET_VEHICLE_WHEEL_TYPE(veh, 1);
			SET_VEHICLE_MOD(veh, 23, musclewheel, customtires);
		}
		else if (GET() == 3)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);
			SET_VEHICLE_WHEEL_TYPE(veh, 2);
			SET_VEHICLE_MOD(veh, 23, lowriderwheel, customtires);
		}
		else if (GET() == 4)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);
			SET_VEHICLE_WHEEL_TYPE(veh, 3);
			SET_VEHICLE_MOD(veh, 23, suvwheel, customtires);
		}
		else if (GET() == 5)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);
			SET_VEHICLE_WHEEL_TYPE(veh, 4);
			SET_VEHICLE_MOD(veh, 23, offroadwheel, customtires);
		}
		else if (GET() == 6)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);
			SET_VEHICLE_WHEEL_TYPE(veh, 5);
			SET_VEHICLE_MOD(veh, 23, tunerwheel, customtires);
		}
		else if (GET() == 7)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			SET_VEHICLE_MOD_KIT(veh, 0);
			SET_VEHICLE_WHEEL_TYPE(veh, 6);
			SET_VEHICLE_MOD(veh, 23, highendwheel, customtires);
		}
		else if (GET() == 8)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			int peac;
			int whec;
			GET_VEHICLE_EXTRA_COLOURS(veh, &peac, &whec);
			SET_VEHICLE_EXTRA_COLOURS(veh, peac, rimcolor);
		}
		else if (GET() == 9)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			int peac;
			int whec;
			GET_VEHICLE_EXTRA_COLOURS(veh, &peac, &whec);
			SET_VEHICLE_EXTRA_COLOURS(veh, rimpearlcolor, whec);
		}
	}

	if (NumMenu == Veh_Paint)
	{
		AddTitle("Cyber Mod Loader");
		addOptionIntList("Primary Color", &primcolor, ColorsList, 0, 160);
		addOptionIntList("Secondary Color", &seccolor, ColorsList, 0, 160);
		addOptionIntList("Pearlescent Color", &pearlcolor, ColorsList, 0, 160);
		addOption("Manual Primary Color");
		addOption("Manual Secondary Color");
		AddSubTitle("Vehicle Paint");

		if (GET() == 1)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			int pric;
			int secc;
			GET_VEHICLE_COLOURS(veh, &pric, &secc);
			SET_VEHICLE_COLOURS(veh, primcolor, secc);
		}
		else if (GET() == 2)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			int pric;
			int secc;
			GET_VEHICLE_COLOURS(veh, &pric, &secc);
			SET_VEHICLE_COLOURS(veh, pric, seccolor);
		}
		else if (GET() == 3)
		{
			Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			int peac;
			int whec;
			GET_VEHICLE_EXTRA_COLOURS(veh, &peac, &whec);
			SET_VEHICLE_EXTRA_COLOURS(veh, rimpearlcolor, whec);
		}
		else if (GET() == 4)
		{
			int r;
int g;
int b;
Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());

DISPLAY_ONSCREEN_KEYBOARD(0, "FMMC_KEY_TIP8", "", "", "", "", "", 4);
WAIT(100);
if (UPDATE_ONSCREEN_KEYBOARD() == 1)
{
	const char *txt = GET_ONSCREEN_KEYBOARD_RESULT();
	r = (int)txt;
}

DISPLAY_ONSCREEN_KEYBOARD(0, "FMMC_KEY_TIP8", "", "", "", "", "", 4);
WAIT(100);
if (UPDATE_ONSCREEN_KEYBOARD() == 1)
{
	const char *txt = GET_ONSCREEN_KEYBOARD_RESULT();
	g = (int)txt;
}

DISPLAY_ONSCREEN_KEYBOARD(0, "FMMC_KEY_TIP8", "", "", "", "", "", 4);
WAIT(100);
if (UPDATE_ONSCREEN_KEYBOARD() == 1)
{
	const char *txt = GET_ONSCREEN_KEYBOARD_RESULT();
	b = (int)txt;
}

SET_VEHICLE_CUSTOM_PRIMARY_COLOUR(veh, r, g, b);
		}
		else if (GET() == 5)
		{
		int r;
		int g;
		int b;
		Vehicle veh = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());

		DISPLAY_ONSCREEN_KEYBOARD(0, "FMMC_KEY_TIP8", "", "", "", "", "", 4);
		WAIT(100);
		if (UPDATE_ONSCREEN_KEYBOARD() == 1)
		{
			const char *txt = GET_ONSCREEN_KEYBOARD_RESULT();
			r = (int)txt;
		}

		DISPLAY_ONSCREEN_KEYBOARD(0, "FMMC_KEY_TIP8", "", "", "", "", "", 4);
		WAIT(100);
		if (UPDATE_ONSCREEN_KEYBOARD() == 1)
		{
			const char *txt = GET_ONSCREEN_KEYBOARD_RESULT();
			g = (int)txt;
		}

		DISPLAY_ONSCREEN_KEYBOARD(0, "FMMC_KEY_TIP8", "", "", "", "", "", 4);
		WAIT(100);
		if (UPDATE_ONSCREEN_KEYBOARD() == 1)
		{
			const char *txt = GET_ONSCREEN_KEYBOARD_RESULT();
			b = (int)txt;
		}

		SET_VEHICLE_CUSTOM_SECONDARY_COLOUR(veh, r, g, b);
		}
	}

	if (NumMenu == Online_Players)
	{
		AddTitle("Cyber Mod Loader");
		FolderOption("All Players Mods  --->>", All_Players_Mods);
		for (int i = 0; i < 16; i++)
		{
			if (ARE_STRINGS_EQUAL(GET_PLAYER_NAME(i), "**Invalid**") == false)
				FolderPlayerOption(GET_PLAYER_NAME(i), i, OP_Mods);
			else
				FolderPlayerOption("**Not Connected**", i, OP_Mods);
		}
		AddSubTitle("Online Players");

		if (currentOption != 1)
		{
			if (ARE_STRINGS_EQUAL(GET_PLAYER_NAME(currentOption - 2), "**Invalid**") == false)
			{
				Ped pd = GET_PLAYER_PED(currentOption - 2);
				vector3 coord = GET_ENTITY_COORDS(pd, true);
				coord.z += 2.0f;
				vector3 dir = { 0, 0, 0 };
				vector3 rot = { 0, 180, 0 };
				vector3 scale = { 1.5, 1.2, 1.9 };
				RGBA color = { 255, 170, 0, 120 };
				DRAW_MARKER(2, coord, dir, rot, scale, color, 1, 0, 2, 1, 0, 0, 0);
			}
		}
		
	}

	if (NumMenu == All_Players_Mods)
	{
		AddTitle("Cyber Mod Loader");
		CheckBox("Include Self for All players Mods", includeself);
		addOption("Explode All Players");
		addOptionMultip("Money Rain", &allplayersmoneyrainmultip, 1, 5);
		addOption("Trap in a Cage");
		addOption("Lag All Players");
		addOption("Iper Lag All Players");
		addOption("Kill All Players");
		addOption("Spawn Clone");
		addOption("Spawn Enemy Clone");
		addOption("Spawn Enemy Swat Unit");
		CheckBox("Explosion Loop", allplayersexplode);
		AddSubTitle("All Players Options");

		if (GET() == 1)
		{
			includeself = !includeself;
		}
		else if (GET() == 2)
		{
			for (int i = 0; i < 16; i++)
			{
				if (includeself == false)
				{
					if (GET_PLAYER_PED(i) != PLAYER_PED_ID())
					{
						vector3 coord = GET_ENTITY_COORDS(GET_PLAYER_PED(i), true);
						ADD_OWNED_EXPLOSION(GET_PLAYER_PED(i), coord, 29, 0.5f, true, true, 5.0f);
					}
				}
				else
				{
					vector3 coord = GET_ENTITY_COORDS(GET_PLAYER_PED(i), true);
					ADD_OWNED_EXPLOSION(GET_PLAYER_PED(i), coord, 29, 0.5f, true, true, 5.0f);
				}
			}
		}
		else if (GET() == 3)
		{
			if (allplayersmoneyrainmultip == 1)
			{
				for (int i = 0; i < 16; i++)
				{
					if (includeself == false)
					{
						if (GET_PLAYER_PED(i) != PLAYER_PED_ID())
						{
							for (int a = 0; a < 20; a++)
							{
								vector3 coord = GET_ENTITY_COORDS(GET_PLAYER_PED(i), true);
								int num = GET_RANDOM_INT_IN_RANGE(-500, 500);
								int num2 = GET_RANDOM_INT_IN_RANGE(-500, 500);
								coord.x += ((float)num) / 50.0f;
								coord.y += ((float)num2) / 50.0f;
								coord.z += 3.0f;
								CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0xC350, 1, 0, 1);
							}
						}
					}
					else
					{
						for (int a = 0; a < 20; a++)
						{
							vector3 coord = GET_ENTITY_COORDS(GET_PLAYER_PED(i), true);
							int num = GET_RANDOM_INT_IN_RANGE(-500, 500);
							int num2 = GET_RANDOM_INT_IN_RANGE(-500, 500);
							coord.x += ((float)num) / 50.0f;
							coord.y += ((float)num2) / 50.0f;
							coord.z += 3.0f;
							CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0xC350, 1, 0, 1);
						}
					}
				}
			}
			else if (allplayersmoneyrainmultip == 2)
			{
				for (int i = 0; i < 18; i++)
				{
					if (includeself == false)
					{
						if (GET_PLAYER_PED(i) != PLAYER_PED_ID())
						{
							for (int a = 0; a < 35; a++)
							{
								vector3 coord = GET_ENTITY_COORDS(GET_PLAYER_PED(i), true);
								int num = GET_RANDOM_INT_IN_RANGE(-500, 500);
								int num2 = GET_RANDOM_INT_IN_RANGE(-500, 500);
								coord.x += ((float)num) / 50.0f;
								coord.y += ((float)num2) / 50.0f;
								coord.z += 3.0f;
								CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0xC350, 1, 0, 1);
							}
						}
					}
					else
					{
						for (int a = 0; a < 35; a++)
						{
							vector3 coord = GET_ENTITY_COORDS(GET_PLAYER_PED(i), true);
							int num = GET_RANDOM_INT_IN_RANGE(-500, 500);
							int num2 = GET_RANDOM_INT_IN_RANGE(-500, 500);
							coord.x += ((float)num) / 50.0f;
							coord.y += ((float)num2) / 50.0f;
							coord.z += 3.0f;
							CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0xC350, 1, 0, 1);
						}
					}
				}
			}
			else if (allplayersmoneyrainmultip == 3)
			{
				for (int i = 0; i < 18; i++)
				{
					if (includeself == false)
					{
						if (GET_PLAYER_PED(i) != PLAYER_PED_ID())
						{
							for (int a = 0; a < 50; a++)
							{
								vector3 coord = GET_ENTITY_COORDS(GET_PLAYER_PED(i), true);
								int num = GET_RANDOM_INT_IN_RANGE(-500, 500);
								int num2 = GET_RANDOM_INT_IN_RANGE(-500, 500);
								coord.x += ((float)num) / 50.0f;
								coord.y += ((float)num2) / 50.0f;
								coord.z += 3.0f;
								CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0xC350, 1, 0, 1);
							}
						}
					}
					else
					{
						for (int a = 0; a < 50; a++)
						{
							vector3 coord = GET_ENTITY_COORDS(GET_PLAYER_PED(i), true);
							int num = GET_RANDOM_INT_IN_RANGE(-500, 500);
							int num2 = GET_RANDOM_INT_IN_RANGE(-500, 500);
							coord.x += ((float)num) / 50.0f;
							coord.y += ((float)num2) / 50.0f;
							coord.z += 3.0f;
							CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0xC350, 1, 0, 1);
						}
					}
				}
			}
			else if (allplayersmoneyrainmultip == 4)
			{
				for (int i = 0; i < 18; i++)
				{
					if (includeself == false)
					{
						if (GET_PLAYER_PED(i) != PLAYER_PED_ID())
						{
							for (int a = 0; a < 65; a++)
							{
								vector3 coord = GET_ENTITY_COORDS(GET_PLAYER_PED(i), true);
								int num = GET_RANDOM_INT_IN_RANGE(-500, 500);
								int num2 = GET_RANDOM_INT_IN_RANGE(-500, 500);
								coord.x += ((float)num) / 50.0f;
								coord.y += ((float)num2) / 50.0f;
								coord.z += 3.0f;
								CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0xC350, 1, 0, 1);
							}
						}
					}
					else
					{
						for (int a = 0; a < 65; a++)
						{
							vector3 coord = GET_ENTITY_COORDS(GET_PLAYER_PED(i), true);
							int num = GET_RANDOM_INT_IN_RANGE(-500, 500);
							int num2 = GET_RANDOM_INT_IN_RANGE(-500, 500);
							coord.x += ((float)num) / 50.0f;
							coord.y += ((float)num2) / 50.0f;
							coord.z += 3.0f;
							CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0xC350, 1, 0, 1);
						}
					}
				}
			}
			else if (allplayersmoneyrainmultip == 5)
			{
				for (int i = 0; i < 18; i++)
				{
					if (includeself == false)
					{
						if (GET_PLAYER_PED(i) != PLAYER_PED_ID())
						{
							for (int a = 0; a < 80; a++)
							{
								vector3 coord = GET_ENTITY_COORDS(GET_PLAYER_PED(i), true);
								int num = GET_RANDOM_INT_IN_RANGE(-500, 500);
								int num2 = GET_RANDOM_INT_IN_RANGE(-500, 500);
								coord.x += ((float)num) / 50.0f;
								coord.y += ((float)num2) / 50.0f;
								coord.z += 3.0f;
								CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0xC350, 1, 0, 1);
							}
						}
					}
					else
					{
						for (int a = 0; a < 80; a++)
						{
							vector3 coord = GET_ENTITY_COORDS(GET_PLAYER_PED(i), true);
							int num = GET_RANDOM_INT_IN_RANGE(-500, 500);
							int num2 = GET_RANDOM_INT_IN_RANGE(-500, 500);
							coord.x += ((float)num) / 50.0f;
							coord.y += ((float)num2) / 50.0f;
							coord.z += 3.0f;
							CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0xC350, 1, 0, 1);
						}
					}
				}
			}
		}
		else if (GET() == 4)
		{
			if (includeself == false)
			{
				for (int i = 0; i < 16; i++)
				{
					Ped ped = GET_PLAYER_PED(i);
					if (ped != PLAYER_PED_ID())
					{
						if (IS_PED_IN_ANY_VEHICLE(ped, false))
							CLEAR_PED_TASKS_IMMEDIATELY(ped);

						vector3 coord = GET_ENTITY_COORDS(ped, 1);
						coord.z -= 1.0f;
						CREATE_OBJECT(0x392D62AA, coord, true, true, true);
					}
				}
			}
			else
			{
				for (int i = 0; i < 18; i++)
				{
					Ped ped = GET_PLAYER_PED(i);
					if (IS_PED_IN_ANY_VEHICLE(ped, false))
						CLEAR_PED_TASKS_IMMEDIATELY(ped);

					vector3 coord = GET_ENTITY_COORDS(ped, 1);
					coord.z -= 1.0f;
					CREATE_OBJECT(0x392D62AA, coord, true, true, true);
				}
			}
		}
		else if (GET() == 5)
		{
			if (includeself == false)
			{
				for (int i = 0; i < 16; i++)
				{
					Ped ped = GET_PLAYER_PED(i);
					if (ped != PLAYER_PED_ID())
					{
						Hash hashKey = GET_HASH_KEY("CARGOPLANE");
						REQUEST_MODEL(hashKey);
						while (HAS_MODEL_LOADED(hashKey) != 1)
							WAIT(0);

						vector3 coord = GET_ENTITY_COORDS(ped, 1);
						++coord.x;
						coord.y -= 0.0f;

						CREATE_VEHICLE(hashKey, coord, 1, 1, 0);
						CREATE_VEHICLE(hashKey, coord, 1, 1, 0);
						CREATE_VEHICLE(hashKey, coord, 1, 1, 0);

						for (int i = 0; i < 6; ++i)
						{
							CLEAR_PED_TASKS_IMMEDIATELY(ped);
						}
						SET_MODEL_AS_NO_LONGER_NEEDED(hashKey);
					}
				}
			}
			else
			{
				for (int i = 0; i < 18; i++)
				{
					Ped ped = GET_PLAYER_PED(i);
					Hash hashKey = GET_HASH_KEY("CARGOPLANE");
					REQUEST_MODEL(hashKey);
					while (HAS_MODEL_LOADED(hashKey) != 1)
						WAIT(0);

					vector3 coord = GET_ENTITY_COORDS(ped, 1);
					++coord.x;
					coord.y -= 0.0f;

					CREATE_VEHICLE(hashKey, coord, 1, 1, 0);
					CREATE_VEHICLE(hashKey, coord, 1, 1, 0);
					CREATE_VEHICLE(hashKey, coord, 1, 1, 0);

					for (int i = 0; i < 6; ++i)
					{
						CLEAR_PED_TASKS_IMMEDIATELY(ped);
					}
					SET_MODEL_AS_NO_LONGER_NEEDED(hashKey);
				}
			}
		}
		else if (GET() == 6)
		{
			if (includeself == false)
			{
				for (int i = 0; i < 16; i++)
				{
					Ped ped = GET_PLAYER_PED(i);
					if (ped != PLAYER_PED_ID())
					{
						Hash hashKey = GET_HASH_KEY("CARGOPLANE");
						REQUEST_MODEL(hashKey);
						while (HAS_MODEL_LOADED(hashKey) != 1)
							WAIT(0);

						vector3 coord = GET_ENTITY_COORDS(ped, 1);
						++coord.x;
						coord.y -= 0.0f;

						CREATE_VEHICLE(hashKey, coord, 1, 1, 0);
						CREATE_VEHICLE(hashKey, coord, 1, 1, 0);
						CREATE_VEHICLE(hashKey, coord, 1, 1, 0);
						CREATE_VEHICLE(hashKey, coord, 1, 1, 0);
						CREATE_VEHICLE(hashKey, coord, 1, 1, 0);

						for (int i = 0; i < 6; ++i)
						{
							CLEAR_PED_TASKS_IMMEDIATELY(ped);
						}
						SET_MODEL_AS_NO_LONGER_NEEDED(hashKey);
					}
				}
			}
			else
			{
				for (int i = 0; i < 18; i++)
				{
					Ped ped = GET_PLAYER_PED(i);
					Hash hashKey = GET_HASH_KEY("CARGOPLANE");
					REQUEST_MODEL(hashKey);
					while (HAS_MODEL_LOADED(hashKey) != 1)
						WAIT(0);

					vector3 coord = GET_ENTITY_COORDS(ped, 1);
					++coord.x;
					coord.y -= 0.0f;

					CREATE_VEHICLE(hashKey, coord, 1, 1, 0);
					CREATE_VEHICLE(hashKey, coord, 1, 1, 0);
					CREATE_VEHICLE(hashKey, coord, 1, 1, 0);
					CREATE_VEHICLE(hashKey, coord, 1, 1, 0);
					CREATE_VEHICLE(hashKey, coord, 1, 1, 0);

					for (int i = 0; i < 6; ++i)
					{
						CLEAR_PED_TASKS_IMMEDIATELY(ped);
					}
					SET_MODEL_AS_NO_LONGER_NEEDED(hashKey);
				}
			}
		}
		else if (GET() == 7)
		{
			if (includeself == false)
			{
				for (int i = 0; i < 16; i++)
				{
					Ped ped = GET_PLAYER_PED(i);
					if (ped != PLAYER_PED_ID())
					{
						Hash hashKey = GET_HASH_KEY("AIRBUS");
						REQUEST_MODEL(hashKey);
						while (HAS_MODEL_LOADED(hashKey) != 1)
							WAIT(0);

						if (IS_PED_IN_ANY_VEHICLE(ped, false))
							CLEAR_PED_TASKS_IMMEDIATELY(ped);

						vector3 coord = GET_ENTITY_COORDS(ped, 1);
						coord.z += 20.0f;

						Vehicle veh = CREATE_VEHICLE(hashKey, coord, 1, 1, 0);
						vector3 vec = { 0, 0, -650.0f };
						vector3 rot = { 0, 0, 0 };
						APPLY_FORCE_TO_ENTITY(veh, 1, vec, rot, 0, 1, 1, 1, 0, 1);
						SET_MODEL_AS_NO_LONGER_NEEDED(hashKey);
					}
				}
			}
			else
			{
				for (int i = 0; i < 18; i++)
				{
					Ped ped = GET_PLAYER_PED(i);
					Hash hashKey = GET_HASH_KEY("AIRBUS");
					REQUEST_MODEL(hashKey);
					while (HAS_MODEL_LOADED(hashKey) != 1)
						WAIT(0);

					if (IS_PED_IN_ANY_VEHICLE(ped, false))
						CLEAR_PED_TASKS_IMMEDIATELY(ped);

					vector3 coord = GET_ENTITY_COORDS(ped, 1);
					coord.z += 20.0f;

					Vehicle veh = CREATE_VEHICLE(hashKey, coord, 1, 1, 0);
					vector3 vec = { 0, 0, -650.0f };
					vector3 rot = { 0, 0, 0 };
					APPLY_FORCE_TO_ENTITY(veh, 1, vec, rot, 0, 1, 1, 1, 0, 1);
					SET_MODEL_AS_NO_LONGER_NEEDED(hashKey);
				}
			}
		}
		else if (GET() == 8)
		{
			if (includeself == false)
			{
				for (int i = 0; i < 16; i++)
				{
					Ped ped = GET_PLAYER_PED(i);
					if (ped != PLAYER_PED_ID())
					{
						CLONE_PED(ped, GET_ENTITY_HEADING(ped), 0, 1);
					}
				}
			}
			else
			{
				for (int i = 0; i < 18; i++)
				{
					Ped ped = GET_PLAYER_PED(i);
					CLONE_PED(ped, GET_ENTITY_HEADING(ped), 0, 1);
				}
			}
		}
		else if (GET() == 9)
		{
			if (includeself == false)
			{
				for (int i = 0; i < 16; i++)
				{
					Ped ped = GET_PLAYER_PED(i);
					if (ped != PLAYER_PED_ID())
					{
						Ped clone = CLONE_PED(ped, GET_ENTITY_HEADING(ped), 0, 1);
						//enemy ped
						while (DOES_ENTITY_EXIST(clone) == false)
							WAIT(0);
						Hash hashKey = GET_HASH_KEY("WEAPON_CARBINERIFLE");
						GIVE_DELAYED_WEAPON_TO_PED(clone, hashKey, 0x270f, true);
						SET_PED_CAN_SWITCH_WEAPON(clone, 1);
						SET_PED_ARMOUR(clone, 100);
						ADD_ARMOUR_TO_PED(clone, 100);
						SET_PED_AS_ENEMY(ped, 1);
						SET_ENTITY_IS_TARGET_PRIORITY(ped, 1, 0);
						TASK_SHOOT_AT_ENTITY(clone, ped, -1, 3337513804U);
						TASK_COMBAT_PED(clone, ped, 0, 16);
						SET_PED_KEEP_TASK(clone, 1);
						SET_PED_SHOOT_RATE(clone, 1000);
						SET_PED_COMBAT_ABILITY(clone, 2);
						SET_PED_COMBAT_ATTRIBUTES(clone, 52, 1);
						SET_PED_COMBAT_RANGE(clone, 0);
						SET_PED_ACCURACY(clone, 100);
						SET_PED_COMBAT_MOVEMENT(clone, 2);
						SET_PED_FIRING_PATTERN(clone, 3337513804U);
						SET_CAN_ATTACK_FRIENDLY(clone, 0, 0);
						SET_PED_MONEY(clone, 1000);
					}
				}
			}
			else
			{
				for (int i = 0; i < 18; i++)
				{
					Ped ped = GET_PLAYER_PED(i);
					Ped clone = CLONE_PED(ped, GET_ENTITY_HEADING(ped), 0, 1);
					//enemy ped
					while (DOES_ENTITY_EXIST(clone) == false)
						WAIT(0);
					Hash hashKey = GET_HASH_KEY("WEAPON_CARBINERIFLE");
					GIVE_DELAYED_WEAPON_TO_PED(clone, hashKey, 0x270f, true);
					SET_PED_CAN_SWITCH_WEAPON(clone, 1);
					SET_PED_ARMOUR(clone, 100);
					ADD_ARMOUR_TO_PED(clone, 100);
					SET_PED_AS_ENEMY(ped, 1);
					SET_ENTITY_IS_TARGET_PRIORITY(ped, 1, 0);
					TASK_SHOOT_AT_ENTITY(clone, ped, -1, 3337513804U);
					TASK_COMBAT_PED(clone, ped, 0, 16);
					SET_PED_KEEP_TASK(clone, 1);
					SET_PED_SHOOT_RATE(clone, 1000);
					SET_PED_COMBAT_ABILITY(clone, 2);
					SET_PED_COMBAT_ATTRIBUTES(clone, 52, 1);
					SET_PED_COMBAT_RANGE(clone, 0);
					SET_PED_ACCURACY(clone, 100);
					SET_PED_COMBAT_MOVEMENT(clone, 2);
					SET_PED_FIRING_PATTERN(clone, 3337513804U);
					SET_CAN_ATTACK_FRIENDLY(clone, 0, 0);
					SET_PED_MONEY(clone, 1000);
				}
			}
		}
		else if (GET() == 10)
		{
		    AllPspawnPedSwatUnit("S_M_Y_SWAT_01");
		}
		else if (GET() == 11)
		{
			allplayersexplode = !allplayersexplode;
		}
	}

	if (NumMenu == OP_Mods)
	{
		AddTitle("Cyber Mod Loader");
		addOption("Teleport to Player");
		addOption("Teleport into Player's Car");
		addOptionMultip("Money Rain", &opmoneyrainmultip, 1, 5);
		addOption("Explode Player");
		addOption("Lag Player");
		addOption("Iper Lag Player");
		addOption("Kill Player even on Passive Mode");
		addOption("Trap Player in a Cage");
		addOption("Make Player Explode Lobby");
		addOption("Spawn Enemy Clone");
		addOption("Spawn Enemy Swat Unit");
		addOption("Spawn Enemy Buzzard");
		CheckBox("Explosions loop", playersforcefield[selected_player]);
		CheckBox("Aggressive Peds", playershostile[selected_player]);
		AddSubTitle("Online Player Options");

		if (ARE_STRINGS_EQUAL(GET_PLAYER_NAME(selected_player), "**Invalid**"))
		{
			print("The Player is no more Online..", 4000);
			NumMenu = lastNumMenu[NumMenuLevel - 1];
			currentOption = lastOption[NumMenuLevel - 1];
			NumMenuLevel--;
		}

		if (GET() == 1)
		{
		    Ped pedd = GET_PLAYER_PED(selected_player);
			vector3 coords = GET_ENTITY_COORDS(pedd, true);
			DO_SCREEN_FADE_OUT(300);
			SET_ENTITY_COORDS(PLAYER_PED_ID(), coords.x, coords.y, coords.z, 0, 0, 0, 0);
			DO_SCREEN_FADE_IN(300);
		}
		else if (GET() == 2)
		{
		    Ped ped = GET_PLAYER_PED(selected_player);
			if (IS_PED_IN_ANY_VEHICLE(ped, false))
			{
				Vehicle veh = GET_VEHICLE_PED_IS_IN(ped, false);
				if (ARE_ANY_VEHICLE_SEATS_FREE(veh))
				{
					TPtoPVeh(veh);
				}
				else
				{
					print("~r~All seats occupied..", 2000);
				}
			}
			else
			{
				print("~r~Player not in a Vehicle..", 2000);
			}
		}
		else if (GET() == 3)
		{
		    Ped ped = GET_PLAYER_PED(selected_player);
			if (opmoneyrainmultip == 1)
			{
				for (int i = 0; i < 20; i++)
				{
					vector3 coord = GET_ENTITY_COORDS(ped, true);
					int num = GET_RANDOM_INT_IN_RANGE(-500, 500);
					int num2 = GET_RANDOM_INT_IN_RANGE(-500, 500);
					coord.x += ((float)num) / 50.0f;
					coord.y += ((float)num2) / 50.0f;
					coord.z += 3.0f;
					CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0x7d0, 1, 0, 1);
				}
			}
			else if (opmoneyrainmultip == 2)
			{
				for (int i = 0; i < 35; i++)
				{
					vector3 coord = GET_ENTITY_COORDS(ped, true);
					int num = GET_RANDOM_INT_IN_RANGE(-500, 500);
					int num2 = GET_RANDOM_INT_IN_RANGE(-500, 500);
					coord.x += ((float)num) / 50.0f;
					coord.y += ((float)num2) / 50.0f;
					coord.z += 3.0f;
					CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0x7d0, 1, 0, 1);
				}
			}
			else if (opmoneyrainmultip == 3)
			{
				for (int i = 0; i < 50; i++)
				{
					vector3 coord = GET_ENTITY_COORDS(ped, true);
					int num = GET_RANDOM_INT_IN_RANGE(-500, 500);
					int num2 = GET_RANDOM_INT_IN_RANGE(-500, 500);
					coord.x += ((float)num) / 50.0f;
					coord.y += ((float)num2) / 50.0f;
					coord.z += 3.0f;
					CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0x7d0, 1, 0, 1);
				}
			}
			else if (opmoneyrainmultip == 4)
			{
				for (int i = 0; i < 75; i++)
				{
					vector3 coord = GET_ENTITY_COORDS(ped, true);
					int num = GET_RANDOM_INT_IN_RANGE(-500, 500);
					int num2 = GET_RANDOM_INT_IN_RANGE(-500, 500);
					coord.x += ((float)num) / 50.0f;
					coord.y += ((float)num2) / 50.0f;
					coord.z += 3.0f;
					CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0x7d0, 1, 0, 1);
				}
			}
			else if (opmoneyrainmultip == 5)
			{
				for (int i = 0; i < 90; i++)
				{
					vector3 coord = GET_ENTITY_COORDS(ped, true);
					int num = GET_RANDOM_INT_IN_RANGE(-500, 500);
					int num2 = GET_RANDOM_INT_IN_RANGE(-500, 500);
					coord.x += ((float)num) / 50.0f;
					coord.y += ((float)num2) / 50.0f;
					coord.z += 3.0f;
					CREATE_AMBIENT_PICKUP(0x711d02a4, coord, 0, 0x7d0, 1, 0, 1);
				}
			}
		}
		else if (GET() == 4)
		{
		    Ped ped = GET_PLAYER_PED(selected_player);
			vector3 coord = GET_ENTITY_COORDS(ped, 1);
			ADD_OWNED_EXPLOSION(ped, coord, 5, 0.5f, true, true, 5.0f);
		}
		else if (GET() == 5)
		{
		    Ped ped = GET_PLAYER_PED(selected_player);
			Hash hashKey = GET_HASH_KEY("CARGOPLANE");
			REQUEST_MODEL(hashKey);
			while (HAS_MODEL_LOADED(hashKey) != 1)
				WAIT(0);

			vector3 coord = GET_ENTITY_COORDS(ped, 1);
			++coord.x;
			coord.y -= 0.0f;

			CREATE_VEHICLE(hashKey, coord, 1, 1, 0);
			CREATE_VEHICLE(hashKey, coord, 1, 1, 0);
			CREATE_VEHICLE(hashKey, coord, 1, 1, 0);

			for (int i = 0; i < 6; ++i)
			{
				CLEAR_PED_TASKS_IMMEDIATELY(ped);
			}
		}
		else if (GET() == 6)
		{
			Ped ped = GET_PLAYER_PED(selected_player);
			Hash hashKey = GET_HASH_KEY("CARGOPLANE");
			REQUEST_MODEL(hashKey);
			while (HAS_MODEL_LOADED(hashKey) != 1)
				WAIT(0);

			vector3 coord = GET_ENTITY_COORDS(ped, 1);
			++coord.x;
			coord.y -= 0.0f;

			CREATE_VEHICLE(hashKey, coord, 1, 1, 0);
			CREATE_VEHICLE(hashKey, coord, 1, 1, 0);
			CREATE_VEHICLE(hashKey, coord, 1, 1, 0);
			CREATE_VEHICLE(hashKey, coord, 1, 1, 0);
			CREATE_VEHICLE(hashKey, coord, 1, 1, 0);

			for (int i = 0; i < 6; ++i)
			{
				CLEAR_PED_TASKS_IMMEDIATELY(ped);
			}
		}
		else if (GET() == 7)
		{
		    Ped ped = GET_PLAYER_PED(selected_player);
			Hash hashKey = GET_HASH_KEY("AIRBUS");
			REQUEST_MODEL(hashKey);
			while (HAS_MODEL_LOADED(hashKey) != 1)
				WAIT(0);

			if (IS_PED_IN_ANY_VEHICLE(ped, false))
				CLEAR_PED_TASKS_IMMEDIATELY(ped);

			vector3 coord = GET_ENTITY_COORDS(ped, 1);
			coord.z += 20.0f;

			Vehicle veh = CREATE_VEHICLE(hashKey, coord, 1, 1, 0);
			vector3 vec = { 0, 0, -650.0f };
			vector3 rot = { 0, 0, 0 };
			APPLY_FORCE_TO_ENTITY(veh, 1, vec, rot, 0, 1, 1, 1, 0, 1);
			SET_MODEL_AS_NO_LONGER_NEEDED(hashKey);
		}
		else if (GET() == 8)
		{
		    Ped ped = GET_PLAYER_PED(selected_player);
			CLEAR_PED_TASKS_IMMEDIATELY(ped);
			vector3 coord = GET_ENTITY_COORDS(ped, 1);
			coord.z -= 1.0f;
			CREATE_OBJECT(0x392D62AA, coord, true, true, true);
		}
		else if (GET() == 9)
		{
		    Ped ped = GET_PLAYER_PED(selected_player);
			for (int i = 0; i < 16; i++)
			{
				if (GET_PLAYER_PED(i) != PLAYER_PED_ID())
				{
					vector3 coords = GET_ENTITY_COORDS(GET_PLAYER_PED(i), true);
					ADD_OWNED_EXPLOSION(ped, coords, 5, 0.5f, true, true, 5.0f);
				}
			}
		}
		else if (GET() == 10)
		{
			Ped ped = GET_PLAYER_PED(selected_player);
			Ped clone = CLONE_PED(ped, GET_ENTITY_HEADING(ped), 0, 1);
			//enemy
			while (DOES_ENTITY_EXIST(clone) == false)
				WAIT(0);
			Hash hashKey = GET_HASH_KEY("WEAPON_CARBINERIFLE");
			GIVE_DELAYED_WEAPON_TO_PED(clone, hashKey, 0x270f, true);
			SET_PED_CAN_SWITCH_WEAPON(clone, 1);
			SET_PED_ARMOUR(clone, 100);
			ADD_ARMOUR_TO_PED(clone, 100);
			SET_ENTITY_HEALTH(clone, 200);
			SET_PED_AS_ENEMY(ped, 1);
			SET_ENTITY_IS_TARGET_PRIORITY(ped, 1, 0);
			TASK_SHOOT_AT_ENTITY(clone, ped, -1, 3337513804U);
			TASK_COMBAT_PED(clone, ped, 0, 16);
			SET_PED_KEEP_TASK(clone, 1);
			SET_PED_SHOOT_RATE(clone, 1000);
			SET_PED_COMBAT_ABILITY(clone, 2);
			SET_PED_COMBAT_ATTRIBUTES(clone, 52, 1);
			SET_PED_COMBAT_RANGE(clone, 0);
			SET_PED_ACCURACY(clone, 100);
			SET_PED_COMBAT_MOVEMENT(clone, 2);
			SET_PED_FIRING_PATTERN(clone, 3337513804U);
			SET_CAN_ATTACK_FRIENDLY(clone, 0, 0);
			SET_PED_MONEY(clone, 1000);
		}
		else if (GET() == 11)
		{
			Ped ped = GET_PLAYER_PED(selected_player);
			
			spawnPedSwatUnit("S_M_Y_SWAT_01", ped);
			Ped clone = OPswat;
			Ped clone2 = OPswat2;
			Ped clone3 = OPswat3; 
			Ped clone4 = OPswat4;
			
			//enemy ped
			Hash hashKey = GET_HASH_KEY("WEAPON_CARBINERIFLE");
			GIVE_DELAYED_WEAPON_TO_PED(clone, hashKey, 0x270f, true);
			GIVE_DELAYED_WEAPON_TO_PED(clone2, hashKey, 0x270f, true);
			GIVE_DELAYED_WEAPON_TO_PED(clone3, hashKey, 0x270f, true);
			GIVE_DELAYED_WEAPON_TO_PED(clone4, hashKey, 0x270f, true);
			SET_PED_CAN_SWITCH_WEAPON(clone, 1);
			SET_PED_CAN_SWITCH_WEAPON(clone2, 1);
			SET_PED_CAN_SWITCH_WEAPON(clone3, 1);
			SET_PED_CAN_SWITCH_WEAPON(clone4, 1);
			SET_PED_ARMOUR(clone, 100);
			SET_PED_ARMOUR(clone2, 100);
			SET_PED_ARMOUR(clone3, 100);
			SET_PED_ARMOUR(clone4, 100);
			ADD_ARMOUR_TO_PED(clone, 100);
			ADD_ARMOUR_TO_PED(clone2, 100);
			ADD_ARMOUR_TO_PED(clone3, 100);
			ADD_ARMOUR_TO_PED(clone4, 100);
			SET_ENTITY_HEALTH(clone, 200);
			SET_ENTITY_HEALTH(clone2, 200);
			SET_ENTITY_HEALTH(clone3, 200);
			SET_ENTITY_HEALTH(clone4, 200);
			ADD_ARMOUR_TO_PED(clone, 100);
			ADD_ARMOUR_TO_PED(clone2, 100);
			ADD_ARMOUR_TO_PED(clone3, 100);
			ADD_ARMOUR_TO_PED(clone4, 100);
			SET_PED_AS_ENEMY(ped, 1);
			SET_ENTITY_IS_TARGET_PRIORITY(ped, 1, 0);
			TASK_SHOOT_AT_ENTITY(clone, ped, -1, 3337513804U);
			TASK_SHOOT_AT_ENTITY(clone2, ped, -1, 3337513804U);
			TASK_SHOOT_AT_ENTITY(clone3, ped, -1, 3337513804U);
			TASK_SHOOT_AT_ENTITY(clone4, ped, -1, 3337513804U);
			TASK_COMBAT_PED(clone, ped, 0, 16);
			TASK_COMBAT_PED(clone2, ped, 0, 16);
			TASK_COMBAT_PED(clone3, ped, 0, 16);
			TASK_COMBAT_PED(clone4, ped, 0, 16);
			SET_PED_KEEP_TASK(clone, 1);
			SET_PED_KEEP_TASK(clone2, 1);
			SET_PED_KEEP_TASK(clone3, 1);
			SET_PED_KEEP_TASK(clone4, 1);
			SET_PED_SHOOT_RATE(clone, 1000);
			SET_PED_SHOOT_RATE(clone2, 1000);
			SET_PED_SHOOT_RATE(clone3, 1000);
			SET_PED_SHOOT_RATE(clone4, 1000);
			SET_PED_COMBAT_ABILITY(clone, 2);
			SET_PED_COMBAT_ABILITY(clone2, 2);
			SET_PED_COMBAT_ABILITY(clone3, 2);
			SET_PED_COMBAT_ABILITY(clone4, 2);
			SET_PED_COMBAT_ATTRIBUTES(clone, 52, 1);
			SET_PED_COMBAT_ATTRIBUTES(clone2, 52, 1);
			SET_PED_COMBAT_ATTRIBUTES(clone3, 52, 1);
			SET_PED_COMBAT_ATTRIBUTES(clone4, 52, 1);
			SET_PED_COMBAT_RANGE(clone, 0);
			SET_PED_COMBAT_RANGE(clone2, 0);
			SET_PED_COMBAT_RANGE(clone3, 0);
			SET_PED_COMBAT_RANGE(clone4, 0);
			SET_PED_ACCURACY(clone, 100);
			SET_PED_ACCURACY(clone2, 100);
			SET_PED_ACCURACY(clone3, 100);
			SET_PED_ACCURACY(clone4, 100);
			SET_PED_COMBAT_MOVEMENT(clone, 2);
			SET_PED_COMBAT_MOVEMENT(clone2, 2);
			SET_PED_COMBAT_MOVEMENT(clone3, 2);
			SET_PED_COMBAT_MOVEMENT(clone4, 2);
			SET_PED_FIRING_PATTERN(clone, 3337513804U);
			SET_PED_FIRING_PATTERN(clone2, 3337513804U);
			SET_PED_FIRING_PATTERN(clone3, 3337513804U);
			SET_PED_FIRING_PATTERN(clone4, 3337513804U);
			SET_CAN_ATTACK_FRIENDLY(clone, 0, 0);
			SET_CAN_ATTACK_FRIENDLY(clone2, 0, 0);
			SET_CAN_ATTACK_FRIENDLY(clone3, 0, 0);
			SET_CAN_ATTACK_FRIENDLY(clone4, 0, 0);
			SET_PED_MONEY(clone, 1000);
			SET_PED_MONEY(clone2, 1000);
			SET_PED_MONEY(clone3, 1000);
			SET_PED_MONEY(clone4, 1000);
		}
		else if (GET() == 12)
		{
			Ped ped = GET_PLAYER_PED(selected_player);
			Hash hashkey = GET_HASH_KEY("BUZZARD");
			NETWORK_SET_SCRIPT_IS_SAFE_FOR_NETWORK_GAME();
			if (NETWORK_IS_GAME_IN_PROGRESS() && !NETWORK_GET_THIS_SCRIPT_IS_NETWORK_SCRIPT())
			{
				NETWORK_SET_THIS_SCRIPT_IS_NETWORK_SCRIPT(18, 0, -1);
				NETWORK_GET_SCRIPT_STATUS();
			}
			RESERVE_NETWORK_MISSION_VEHICLES(1);
			REQUEST_MODEL(hashkey);
			while (HAS_MODEL_LOADED(hashkey) == false)
				WAIT(0);
			vector3 coord = GET_ENTITY_COORDS(ped, true);
			coord.x += -20.0f;
			coord.y += 20.0f;
			coord.z += 35.0f;
			spawnPed("S_M_Y_SWAT_01", ped);
			Vehicle veh = CREATE_VEHICLE(hashkey, coord, 0, true, 1);

			while (DOES_ENTITY_EXIST(veh) == false)
				WAIT(0);

			int netId = NETWORK_GET_NETWORK_ID_FROM_ENTITY(veh);
			if (NETWORK_DOES_NETWORK_ID_EXIST(netId))
			{
				_SET_ENTITY_REGISTER(veh, true);
				if (NETWORK_GET_ENTITY_IS_NETWORKED(veh))
					SET_NETWORK_ID_EXISTS_ON_ALL_MACHINES(netId, true);

				SET_PED_INTO_VEHICLE(swatBuzz, veh, -1);
				SET_VEHICLE_ENGINE_ON(veh, 1, 1, 0);
				SET_HELI_BLADES_FULL_SPEED(veh);
				int group = CREATE_GROUP(0);
				SET_PED_AS_GROUP_LEADER(swatBuzz, group);
				SET_PED_ARMOUR(swatBuzz, 100);
				ADD_ARMOUR_TO_PED(swatBuzz, 100);
				SET_PED_AS_ENEMY(ped, 1);
				SET_ENTITY_IS_TARGET_PRIORITY(ped, 1, 0);
				TASK_SHOOT_AT_ENTITY(swatBuzz, ped, -1, 3337513804U);
				TASK_COMBAT_PED(swatBuzz, ped, 0, 16);
				SET_PED_KEEP_TASK(swatBuzz, 1);
				SET_PED_SHOOT_RATE(swatBuzz, 1000);
				SET_PED_COMBAT_ABILITY(swatBuzz, 2);
				SET_PED_COMBAT_ATTRIBUTES(swatBuzz, 52, 1);
				SET_PED_COMBAT_RANGE(swatBuzz, 0);
				SET_PED_ACCURACY(swatBuzz, 100);
				SET_PED_COMBAT_MOVEMENT(swatBuzz, 2);
				SET_PED_FIRING_PATTERN(swatBuzz, 3337513804U);
				SET_CAN_ATTACK_FRIENDLY(swatBuzz, 0, 0);
				SET_PED_MONEY(swatBuzz, 1000);
			}
			SET_ENTITY_AS_NO_LONGER_NEEDED(&veh);
			SET_MODEL_AS_NO_LONGER_NEEDED(hashkey);
		}
		else if (GET() == 13)
		{
		    pedforcefield[selected_player] = GET_PLAYER_PED(selected_player);
			playersforcefield[selected_player] = !playersforcefield[selected_player];
		}
		else if (GET() == 14)
		{
			pedhostile[selected_player] = GET_PLAYER_PED(selected_player);
			playershostile[selected_player] = !playershostile[selected_player];
		}
	}

	if (NumMenu == Teleport_Mods)
	{
		AddTitle("Cyber Mod Loader");
		addOption("Teleport to Waypoint");
		addOption("Teleport to closest Vehicle");
		addOption("Save Current Position");
		addOption("Teleport to Saved Position");
		addOption("Outside 10 Car Garage");
		addOption("Mount Chiliad");
		addOption("Fort Zancudo");
		addOption("Police Helipad");
		addOption("Police Station");
		addOption("Far away Beach");
		addOption("Far Island");
		addOption("Ammu Nation");
		addOption("Los Santos Custom");
		addOption("Inside FIB Building");
		addOption("Above the Clouds");
		addOption("Grove Street");
		addOption("On the Beach");
		addOption("Airport");
		AddSubTitle("Teleport Options");

		if (GET() == 1)
		{
			Blip WaypointID = GET_FIRST_BLIP_INFO_ID(8);
			vector3 WaypointCoords = GET_BLIP_COORDS(WaypointID);
			if (WaypointCoords.x != 0 && WaypointCoords.y != 0)
			{
				DO_SCREEN_FADE_OUT(400);
				TeleportWPLoop = true;
				DO_SCREEN_FADE_IN(400);
			}
			else
			{
				print("Specify a waypoint on the Map..", 2000);
			}
		}
		else if (GET() == 2)
		{
			vector3 coords = GET_ENTITY_COORDS(PLAYER_PED_ID(), true);
			Vehicle veh = GET_CLOSEST_VEHICLE(coords, 400.0f, 0, 70);
			if (DOES_ENTITY_EXIST(veh) && IS_VEHICLE_DRIVEABLE(veh, 1))
			{
				SET_PED_INTO_VEHICLE(PLAYER_PED_ID(), veh, -1);
				SET_VEHICLE_ENGINE_ON(veh, 1, 1, 0);
			}
			else
			{
				print("~r~No vehicle found..", 2000);
			}
		}
		else if (GET() == 3)
		{
			vector3 coords = GET_ENTITY_COORDS(PLAYER_PED_ID(), true);
			savedx = coords.x;
			savedy = coords.y;
			savedz = coords.z + 0.2f;
			print("Position saved !!", 2000);
		}
		else if (GET() == 4)
		{
			Entity ent;
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				ent = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			}
			else
			{
				ent = PLAYER_PED_ID();
			}

			if (savedx != 0 && savedy != 0)
			{
				DO_SCREEN_FADE_OUT(400);
				SET_ENTITY_COORDS(ent, savedx, savedy, savedz, true, true, true, true);
				DO_SCREEN_FADE_IN(400);
			}
			else
			{
				print("~r~No Position saved..", 2000);
			}
		}
		else if (GET() == 5)
		{
			Entity ent;
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				ent = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			}
			else
			{
				ent = PLAYER_PED_ID();
			}

			DO_SCREEN_FADE_OUT(400);
			SET_ENTITY_COORDS(ent, -795.9354, 298.6037, 85.2335, true, true, true, true);
			DO_SCREEN_FADE_IN(400);
		}
		else if (GET() == 6)
		{
			Entity ent;
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				ent = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
				DO_SCREEN_FADE_OUT(400);
				SET_ENTITY_COORDS(ent, 498.7187, 5594.4150, 794.8673, true, true, true, true);
				DO_SCREEN_FADE_IN(400);
			}
			else
			{
				ent = PLAYER_PED_ID();
				DO_SCREEN_FADE_OUT(400);
				SET_ENTITY_COORDS(ent, 501.8234, 5604.5048, 797.9092, true, true, true, true);
				DO_SCREEN_FADE_IN(400);
			}
		}
		else if (GET() == 7)
		{
			Entity ent;
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				ent = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			}
			else
			{
				ent = PLAYER_PED_ID();
			}

			DO_SCREEN_FADE_OUT(400);
			SET_ENTITY_COORDS(ent, -2012.8470, 2956.5270, 32.8101, true, true, true, true);
			DO_SCREEN_FADE_IN(400);
		}
		else if (GET() == 8)
		{
			Entity ent;
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				ent = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			}
			else
			{
				ent = PLAYER_PED_ID();
			}

			DO_SCREEN_FADE_OUT(400);
			SET_ENTITY_COORDS(ent, 375.0070, -1595.9239, 36.9500, true, true, true, true);
			DO_SCREEN_FADE_IN(400);
		}
		else if (GET() == 9)
		{
			Entity ent;
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				ent = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			}
			else
			{
				ent = PLAYER_PED_ID();
			}

			DO_SCREEN_FADE_OUT(400);
			SET_ENTITY_COORDS(ent, 441.2090, -983.1136, 30.6895, true, true, true, true);
			DO_SCREEN_FADE_IN(400);
		}
		else if (GET() == 10)
		{
			Entity ent;
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				ent = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			}
			else
			{
				ent = PLAYER_PED_ID();
			}

			DO_SCREEN_FADE_OUT(400);
			SET_ENTITY_COORDS(ent, 178.3295, 7041.8220, 1.8671, true, true, true, true);
			DO_SCREEN_FADE_IN(400);
		}
		else if (GET() == 11)
		{
			Entity ent;
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				ent = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			}
			else
			{
				ent = PLAYER_PED_ID();
			}

			DO_SCREEN_FADE_OUT(400);
			SET_ENTITY_COORDS(ent, 17.8323, 7630.0140, 13.5068, true, true, true, true);
			DO_SCREEN_FADE_IN(400);
		}
		else if (GET() == 12)
		{
			Entity ent;
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				ent = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			}
			else
			{
				ent = PLAYER_PED_ID();
			}

			DO_SCREEN_FADE_OUT(400);
			SET_ENTITY_COORDS(ent, 236.6613, -41.8139, 69.7321, true, true, true, true);
			DO_SCREEN_FADE_IN(400);
		}
		else if (GET() == 13)
		{
			Entity ent;
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				ent = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			}
			else
			{
				ent = PLAYER_PED_ID();
			}

			DO_SCREEN_FADE_OUT(400);
			SET_ENTITY_COORDS(ent, -376.0130, -124.5062, 38.2403, true, true, true, true);
			DO_SCREEN_FADE_IN(400);
		}
		else if (GET() == 14)
		{
			Entity ent;
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				ent = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			}
			else
			{
				ent = PLAYER_PED_ID();
			}

			DO_SCREEN_FADE_OUT(400);
			SET_ENTITY_COORDS(ent, 135.5220, -749.0009, 260.0000, true, true, true, true);
			DO_SCREEN_FADE_IN(400);
		}
		else if (GET() == 15)
		{
			Entity ent;
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				ent = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			}
			else
			{
				ent = PLAYER_PED_ID();
			}

			DO_SCREEN_FADE_OUT(400);
			SET_ENTITY_COORDS(ent, -73.4489, -833.5170, 5841.4240, true, true, true, true);
			DO_SCREEN_FADE_IN(400);
		}
		else if (GET() == 16)
		{
			Entity ent;
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				ent = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			}
			else
			{
				ent = PLAYER_PED_ID();
			}

			DO_SCREEN_FADE_OUT(400);
			SET_ENTITY_COORDS(ent, 82.1790, -1924.9691, 20.3591, true, true, true, true);
			DO_SCREEN_FADE_IN(400);
		}
		else if (GET() == 17)
		{
			Entity ent;
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				ent = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			}
			else
			{
				ent = PLAYER_PED_ID();
			}

			DO_SCREEN_FADE_OUT(400);
			SET_ENTITY_COORDS(ent, -1422.9227, -1330.7756, 3.2089, true, true, true, true);
			DO_SCREEN_FADE_IN(400);
		}
		else if (GET() == 18)
		{
			Entity ent;
			if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
			{
				ent = GET_VEHICLE_PED_IS_USING(PLAYER_PED_ID());
			}
			else
			{
				ent = PLAYER_PED_ID();
			}

			DO_SCREEN_FADE_OUT(400);
			SET_ENTITY_COORDS(ent, -1102.2910, -2894.5160, 13.9467, true, true, true, true);
			DO_SCREEN_FADE_IN(400);
		}
	}

	if (NumMenu == Map_Mods)
	{
		AddTitle("Cyber Mod Loader");
		CheckBox("Pool Party", poolparty);
		CheckBox("Tgsaudoi's House", tgshouse);
		CheckBox("Boxing Ring", boxring);
		CheckBox("Lake Bridge", lakebridge);
		CheckBox("LSC Jungle", lscjungle);
		CheckBox("Oasis Arena", oasis);
		CheckBox("North Yankton", northy);
		CheckBox("UFO", ufomap);
		CheckBox("O'Neil's Farm", oneil);
		CheckBox("Porn Yacht", pornya);
		CheckBox("Final Bank", finbank);
		CheckBox("Jewelry", jewelry);
		CheckBox("Cargo Ship", cargo);
		CheckBox("Heist Aircraft Carrier", aircraft);
		CheckBox("Maze Bank Derby", mbd);
		CheckBox("Big Ramp Maze Bank", bigrampmazebank);
		CheckBox("Bus Spiral to Heaven", bus);
		CheckBox("Extreme Parkour", exparkour);
		CheckBox("Extreme Wallride Stunt", exwallride);
		CheckBox("High Half Loop Wallride", highhalf);
		CheckBox("Loop Casino", loopcasino);
		CheckBox("Loop City", loopcity);
		CheckBox("Monsters vs Runners", monstersrunners);
		CheckBox("Motorcycle Parkour", motoparkour);
		CheckBox("Maze Bank Ramp", rampmaze);
		CheckBox("Rollercoaster Devil", rolldevil);
		CheckBox("Sky Track Race", skytrack);
		CheckBox("Small Ramp Plaza", rampplaza);
		CheckBox("Snipers vs Stunters", stunterssnipers);
		CheckBox("Super Extra Half Loop", superhalf);
		CheckBox("Track Airport", trackairport);
		CheckBox("Track Under the Map", trackmap);
		CheckBox("Twister Airport", twisterairport);
		CheckBox("Basketball Human", basket);
		CheckBox("Twister", twister);
		CheckBox("GP", gp);
		CheckBox("Big Ramp", bigramp1);
		CheckBox("Big Ramp 2", bigramp2);
		CheckBox("Big Ramp 3", bigramp3);
		AddSubTitle("Maps & IPL Loader");

		if (GET() == 1)
		{
			if (DOES_SCRIPT_EXIST("PPtg"))
			{
				poolparty = !poolparty;
				if (poolparty == true)
				{
					REQUEST_SCRIPT("PPtg");
					while (!HAS_SCRIPT_LOADED("PPtg")) WAIT(0);
					START_NEW_SCRIPT("PPtg", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("PPtg");

					print("Loading map, please wait..", 2000);
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("PPtg");
				}
			}
		}
		else if (GET() == 2)
		{
			if (DOES_SCRIPT_EXIST("TgsaudoizHouse"))
			{
				tgshouse = !tgshouse;
				if (tgshouse == true)
				{
					REQUEST_SCRIPT("TgsaudoizHouse");
					while (!HAS_SCRIPT_LOADED("TgsaudoizHouse")) WAIT(0);
					START_NEW_SCRIPT("TgsaudoizHouse", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("TgsaudoizHouse");

					print("Loading map, please wait..", 2000);
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("TgsaudoizHouse");
				}
			}
		}
		else if (GET() == 3)
		{
			if (DOES_SCRIPT_EXIST("Box"))
			{
				boxring = !boxring;
				if (boxring == true)
				{
					REQUEST_SCRIPT("Box");
					while (!HAS_SCRIPT_LOADED("Box")) WAIT(0);
					START_NEW_SCRIPT("Box", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("Box");

					print("Loading map, please wait..", 2000);
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("Box");
				}
			}
		}
		else if (GET() == 4)
		{
			if (DOES_SCRIPT_EXIST("LakeBridge"))
			{
				lakebridge = !lakebridge;
				if (lakebridge == true)
				{
					REQUEST_SCRIPT("LakeBridge");
					while (!HAS_SCRIPT_LOADED("LakeBridge")) WAIT(0);
					START_NEW_SCRIPT("LakeBridge", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("LakeBridge");

					print("Loading map, please wait..", 2000);
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("LakeBridge");
				}
			}
		}
		else if (GET() == 5)
		{
			if (DOES_SCRIPT_EXIST("LSCTG"))
			{
				lscjungle = !lscjungle;
				if (lscjungle == true)
				{
					REQUEST_SCRIPT("LSCTG");
					while (!HAS_SCRIPT_LOADED("LSCTG")) WAIT(0);
					START_NEW_SCRIPT("LSCTG", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("LSCTG");

					print("Loading map, please wait..", 2000);
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("LSCTG");
				}
			}
		}
		else if (GET() == 6)
		{
			if (DOES_SCRIPT_EXIST("OasisTali"))
			{
				oasis = !oasis;
				if (oasis == true)
				{
					REQUEST_SCRIPT("OasisTali");
					while (!HAS_SCRIPT_LOADED("OasisTali")) WAIT(0);
					START_NEW_SCRIPT("OasisTali", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("OasisTali");

					print("Loading map, please wait..", 2000);
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("OasisTali");
				}
			}
		}
		else if (GET() == 7)
		{
			northy = !northy;
			if (northy == true)
			{
				REQUEST_IPL("prologue01");
				REQUEST_IPL("Prologue01c");
				REQUEST_IPL("Prologue01d");
				REQUEST_IPL("Prologue01e");
				REQUEST_IPL("Prologue01f");
				REQUEST_IPL("Prologue01g");
				REQUEST_IPL("prologue01h");
				REQUEST_IPL("prologue01i");
				REQUEST_IPL("prologue01j");
				REQUEST_IPL("prologue01k");
				REQUEST_IPL("prologue01z");
				REQUEST_IPL("prologue02");
				REQUEST_IPL("prologue03");
				REQUEST_IPL("prologue03b");
				REQUEST_IPL("prologue03_grv_cov");
				REQUEST_IPL("prologue03_grv_dug");
				REQUEST_IPL("prologue03_grv_fun");
				REQUEST_IPL("prologue04");
				REQUEST_IPL("prologue04b");
				REQUEST_IPL("prologue04_cover");
				REQUEST_IPL("prologue05");
				REQUEST_IPL("prologue05b");
				REQUEST_IPL("prologue06");
				REQUEST_IPL("prologue06b");
				REQUEST_IPL("prologue06_int");
				REQUEST_IPL("prologuerd");
				REQUEST_IPL("prologuerdb");
				REQUEST_IPL("prologue_DistantLights");
				REQUEST_IPL("prologue_grv_torch");
				REQUEST_IPL("prologue_m2_door");
				REQUEST_IPL("prologue_LODLights");
				REQUEST_IPL("DES_ProTree_start");
				REQUEST_IPL("DES_ProTree_start_lod");

				while (IS_IPL_ACTIVE("DES_ProTree_start_lod") == false)
				{
					WAIT(0);
				}

				if (IS_IPL_ACTIVE("prologue01") && IS_IPL_ACTIVE("prologue02") && IS_IPL_ACTIVE("prologue03") && IS_IPL_ACTIVE("prologue04") && IS_IPL_ACTIVE("prologue05") && IS_IPL_ACTIVE("prologue06") && IS_IPL_ACTIVE("DES_ProTree_start_lod"))
				{
					vector3 coord = { 3595.397f, -4893.727f, 115.8384f };
					if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
					{
						SET_ENTITY_COORDS(GET_VEHICLE_PED_IS_IN(PLAYER_PED_ID(), false), coord.x, coord.y, coord.z, 0, 0, 0, 0);
					}
					else
					{
						SET_ENTITY_COORDS(PLAYER_PED_ID(), coord.x, coord.y, coord.z, 0, 0, 0, 0);
					}
				}
				else
				{
					print("~r~Map not loaded, please retry..", 2000);
					northy = false;
				}
			}
			else
			{
				REMOVE_IPL("prologue01");
				REMOVE_IPL("Prologue01c");
				REMOVE_IPL("Prologue01d");
				REMOVE_IPL("Prologue01e");
				REMOVE_IPL("Prologue01f");
				REMOVE_IPL("Prologue01g");
				REMOVE_IPL("prologue01h");
				REMOVE_IPL("prologue01i");
				REMOVE_IPL("prologue01j");
				REMOVE_IPL("prologue01k");
				REMOVE_IPL("prologue01z");
				REMOVE_IPL("prologue02");
				REMOVE_IPL("prologue03");
				REMOVE_IPL("prologue03b");
				REMOVE_IPL("prologue03_grv_cov");
				REMOVE_IPL("prologue03_grv_dug");
				REMOVE_IPL("prologue03_grv_fun");
				REMOVE_IPL("prologue04");
				REMOVE_IPL("prologue04b");
				REMOVE_IPL("prologue04_cover");
				REMOVE_IPL("prologue05");
				REMOVE_IPL("prologue05b");
				REMOVE_IPL("prologue06");
				REMOVE_IPL("prologue06b");
				REMOVE_IPL("prologue06_int");
				REMOVE_IPL("prologuerd");
				REMOVE_IPL("prologuerdb");
				REMOVE_IPL("prologue_DistantLights");
				REMOVE_IPL("prologue_grv_torch");
				REMOVE_IPL("prologue_m2_door");
				REMOVE_IPL("prologue_LODLights");
				REMOVE_IPL("DES_ProTree_start");
				REMOVE_IPL("DES_ProTree_start_lod");
			}
		}
		else if (GET() == 8)
		{
			ufomap = !ufomap;
			if (ufomap == true)
			{
				REQUEST_IPL("ufo");
				REQUEST_IPL("ufo_eye");

				while (IS_IPL_ACTIVE("ufo_eye") == false)
				{
					WAIT(0);
				}

				if (IS_IPL_ACTIVE("ufo") && IS_IPL_ACTIVE("ufo_eye"))
				{
					vector3 coord = { -2050.7517f, 3243.9318f, 1455.5935f };
					if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
					{
						SET_ENTITY_COORDS(GET_VEHICLE_PED_IS_IN(PLAYER_PED_ID(), false), coord.x, coord.y, coord.z, 0, 0, 0, 0);
					}
					else
					{
						SET_ENTITY_COORDS(PLAYER_PED_ID(), coord.x, coord.y, coord.z, 0, 0, 0, 0);
					}
				}
				else
				{
					print("~r~Map not loaded, please retry..", 2000);
					ufomap = false;
				}
			}
			else
			{
				REMOVE_IPL("ufo");
				REMOVE_IPL("ufo_eye");
			}
		}
		else if (GET() == 9)
		{
			oneil = !oneil;
			if (oneil == true)
			{
				REQUEST_IPL("farmint");
				REQUEST_IPL("farm_props");

				while (IS_IPL_ACTIVE("farm_props") == false)
				{
					WAIT(0);
				}

				if (IS_IPL_ACTIVE("farmint") && IS_IPL_ACTIVE("farm_props"))
				{
					vector3 coord = { 2409.8337f, 4963.3256f, 45.4765f };
					if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
					{
						SET_ENTITY_COORDS(GET_VEHICLE_PED_IS_IN(PLAYER_PED_ID(), false), coord.x, coord.y, coord.z, 0, 0, 0, 0);
					}
					else
					{
						SET_ENTITY_COORDS(PLAYER_PED_ID(), coord.x, coord.y, coord.z, 0, 0, 0, 0);
					}
				}
				else
				{
					print("~r~Map not loaded, please retry..", 2000);
					oneil = false;
				}
			}
			else
			{
				REMOVE_IPL("farmint");
				REMOVE_IPL("farm_props");
			}
		}
		else if (GET() == 10)
		{
			pornya = !pornya;
			if (pornya == true)
			{
				REQUEST_IPL("smBoat");

				while (IS_IPL_ACTIVE("smBoat") == false)
				{
					WAIT(0);
				}

				if (IS_IPL_ACTIVE("smBoat"))
				{
					vector3 coord = { -2046.1260f, -1030.4353f, 11.9807f };
					if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
					{
						SET_ENTITY_COORDS(GET_VEHICLE_PED_IS_IN(PLAYER_PED_ID(), false), coord.x, coord.y, coord.z, 0, 0, 0, 0);
					}
					else
					{
						SET_ENTITY_COORDS(PLAYER_PED_ID(), coord.x, coord.y, coord.z, 0, 0, 0, 0);
					}
				}
				else
				{
					print("~r~Map not loaded, please retry..", 2000);
					pornya = false;
				}
			}
			else
			{
				REMOVE_IPL("smBoat");
			}
		}
		else if (GET() == 11)
		{
			finbank = !finbank;
			if (finbank == true)
			{
				REQUEST_IPL("FINBANK");

				while (IS_IPL_ACTIVE("FINBANK") == false)
				{
					WAIT(0);
				}

				if (IS_IPL_ACTIVE("FINBANK"))
				{
					vector3 coord = { 4.1349f, -665.2984f, 13.1306f };
					if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
					{
						SET_ENTITY_COORDS(GET_VEHICLE_PED_IS_IN(PLAYER_PED_ID(), false), coord.x, coord.y, coord.z, 0, 0, 0, 0);
					}
					else
					{
						SET_ENTITY_COORDS(PLAYER_PED_ID(), coord.x, coord.y, coord.z, 0, 0, 0, 0);
					}
				}
				else
				{
					print("~r~Map not loaded, please retry..", 2000);
					finbank = false;
				}
			}
			else
			{
				REMOVE_IPL("FINBANK");
			}
		}
		else if (GET() == 12)
		{
			jewelry = !jewelry;
			if (jewelry == true)
			{
				REQUEST_IPL("post_hiest_unload");

				while (IS_IPL_ACTIVE("post_hiest_unload") == false)
				{
					WAIT(0);
				}

				if (IS_IPL_ACTIVE("post_hiest_unload"))
				{
					vector3 coord = { -624.7712f, -233.189f, 38.05701f };
					if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
					{
						SET_ENTITY_COORDS(GET_VEHICLE_PED_IS_IN(PLAYER_PED_ID(), false), coord.x, coord.y, coord.z, 0, 0, 0, 0);
					}
					else
					{
						SET_ENTITY_COORDS(PLAYER_PED_ID(), coord.x, coord.y, coord.z, 0, 0, 0, 0);
					}
				}
				else
				{
					print("~r~Map not loaded, please retry..", 2000);
					jewelry = false;
				}
			}
			else
			{
				REQUEST_IPL("post_hiest_unload");
			}
		}
		else if (GET() == 13)
		{
			cargo = !cargo;
			if (cargo == true)
			{
				REQUEST_IPL("cargoShip");

				while (IS_IPL_ACTIVE("cargoShip") == false)
				{
					WAIT(0);
				}

				if (IS_IPL_ACTIVE("cargoShip"))
				{
					vector3 coord = { -141.1365f, -2388.9226f, 6.0014f };
					if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
					{
						SET_ENTITY_COORDS(GET_VEHICLE_PED_IS_IN(PLAYER_PED_ID(), false), coord.x, coord.y, coord.z, 0, 0, 0, 0);
					}
					else
					{
						SET_ENTITY_COORDS(PLAYER_PED_ID(), coord.x, coord.y, coord.z, 0, 0, 0, 0);
					}
				}
				else
				{
					print("~r~Map not loaded, please retry..", 2000);
					cargo = false;
				}
			}
			else
			{
				REMOVE_IPL("cargoShip");
			}
		}
		else if (GET() == 14)
		{
			aircraft = !aircraft;
			if (aircraft == true)
			{
				REQUEST_IPL("hei_carrier");
				REQUEST_IPL("Hei_carrier");
				REQUEST_IPL("hei_carrier_int1");
				REQUEST_IPL("hei_carrier_int2");
				REQUEST_IPL("hei_carrier_int3");
				REQUEST_IPL("hei_carrier_int4");
				REQUEST_IPL("hei_carrier_int5");
				REQUEST_IPL("hei_carrier_int6");
				REQUEST_IPL("hei_carrier_DistantLights");
				REQUEST_IPL("hei_carrier_LODLights");

				while (IS_IPL_ACTIVE("hei_carrier_LODLights") == false)
				{
					WAIT(0);
				}

				if (IS_IPL_ACTIVE("hei_carrier") && IS_IPL_ACTIVE("hei_carrier_LODLights") && IS_IPL_ACTIVE("hei_carrier_int1") && IS_IPL_ACTIVE("hei_carrier_int2") && IS_IPL_ACTIVE("hei_carrier_int3") && IS_IPL_ACTIVE("hei_carrier_int4") && IS_IPL_ACTIVE("hei_carrier_int5") && IS_IPL_ACTIVE("hei_carrier_int6"))
				{
					vector3 coord = { 3060.4377f, -4642.3623f, 15.2613f };
					if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID(), false))
					{
						SET_ENTITY_COORDS(GET_VEHICLE_PED_IS_IN(PLAYER_PED_ID(), false), coord.x, coord.y, coord.z, 0, 0, 0, 0);
					}
					else
					{
						SET_ENTITY_COORDS(PLAYER_PED_ID(), coord.x, coord.y, coord.z, 0, 0, 0, 0);
					}
				}
				else
				{
					print("~r~Map not loaded, please retry..", 2000);
					aircraft = false;
				}
			}
			else
			{
				REMOVE_IPL("hei_carrier");
				REMOVE_IPL("Hei_carrier");
				REMOVE_IPL("hei_carrier_int1");
				REMOVE_IPL("hei_carrier_int2");
				REMOVE_IPL("hei_carrier_int3");
				REMOVE_IPL("hei_carrier_int4");
				REMOVE_IPL("hei_carrier_int5");
				REMOVE_IPL("hei_carrier_int6");
				REMOVE_IPL("hei_carrier_DistantLights");
				REMOVE_IPL("hei_carrier_LODLights");
			}
		}
		else if (GET() == 15)
		{
			if (DOES_SCRIPT_EXIST("MAZE BANK DERBY"))
			{
				mbd = !mbd;
				if (mbd == true)
				{
					REQUEST_SCRIPT("MAZE BANK DERBY");
					while (!HAS_SCRIPT_LOADED("MAZE BANK DERBY")) WAIT(0);
					START_NEW_SCRIPT("MAZE BANK DERBY", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("MAZE BANK DERBY");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("MAZE BANK DERBY");
				}
			}
		}
		else if (GET() == 16)
		{
			if (DOES_SCRIPT_EXIST("BIG RAMP IN MAZE BANK"))
			{
				bigrampmazebank = !bigrampmazebank;
				if (bigrampmazebank == true)
				{
					REQUEST_SCRIPT("BIG RAMP IN MAZE BANK");
					while (!HAS_SCRIPT_LOADED("BIG RAMP IN MAZE BANK")) WAIT(0);
					START_NEW_SCRIPT("BIG RAMP IN MAZE BANK", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("BIG RAMP IN MAZE BANK");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("BIG RAMP IN MAZE BANK");
				}
			}
		}
		else if (GET() == 17)
		{
			if (DOES_SCRIPT_EXIST("BUS SPIRAL TO HEAVEN"))
			{
				bus = !bus;
				if (bus == true)
				{
					REQUEST_SCRIPT("BUS SPIRAL TO HEAVEN");
					while (!HAS_SCRIPT_LOADED("BUS SPIRAL TO HEAVEN")) WAIT(0);
					START_NEW_SCRIPT("BUS SPIRAL TO HEAVEN", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("BUS SPIRAL TO HEAVEN");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("BUS SPIRAL TO HEAVEN");
				}
			}
		}
		else if (GET() == 18)
		{
			if (DOES_SCRIPT_EXIST("EXTREME PARKOUR"))
			{
				exparkour = !exparkour;
				if (exparkour == true)
				{
					REQUEST_SCRIPT("EXTREME PARKOUR");
					while (!HAS_SCRIPT_LOADED("EXTREME PARKOUR")) WAIT(0);
					START_NEW_SCRIPT("EXTREME PARKOUR", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("EXTREME PARKOUR");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("EXTREME PARKOUR");
				}
			}
		}
		else if (GET() == 19)
		{
			if (DOES_SCRIPT_EXIST("EXTREME WALLRIDE STUNT"))
			{
				exwallride = !exwallride;
				if (exwallride == true)
				{
					REQUEST_SCRIPT("EXTREME WALLRIDE STUNT");
					while (!HAS_SCRIPT_LOADED("EXTREME WALLRIDE STUNT")) WAIT(0);
					START_NEW_SCRIPT("EXTREME WALLRIDE STUNT", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("EXTREME WALLRIDE STUNT");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("EXTREME WALLRIDE STUNT");
				}
			}
			
		}
		else if (GET() == 20)
		{
			if (DOES_SCRIPT_EXIST("HIGH HALFLOOP WALLRIDE"))
			{
				highhalf = !highhalf;
				if (highhalf == true)
				{
					REQUEST_SCRIPT("HIGH HALFLOOP WALLRIDE");
					while (!HAS_SCRIPT_LOADED("HIGH HALFLOOP WALLRIDE")) WAIT(0);
					START_NEW_SCRIPT("HIGH HALFLOOP WALLRIDE", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("HIGH HALFLOOP WALLRIDE");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("HIGH HALFLOOP WALLRIDE");
				}
			}
		}
		else if (GET() == 21)
		{
			if (DOES_SCRIPT_EXIST("LOOP CASINO 1") && DOES_SCRIPT_EXIST("LOOP CASINO 2"))
			{
				loopcasino = !loopcasino;
				if (loopcasino == true)
				{
					REQUEST_SCRIPT("LOOP CASINO 1");
					while (!HAS_SCRIPT_LOADED("LOOP CASINO 1")) WAIT(0);
					START_NEW_SCRIPT("LOOP CASINO 1", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("LOOP CASINO 1");

					REQUEST_SCRIPT("LOOP CASINO 2");
					while (!HAS_SCRIPT_LOADED("LOOP CASINO 2")) WAIT(0);
					START_NEW_SCRIPT("LOOP CASINO 2", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("LOOP CASINO 2");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("LOOP CASINO 1");
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("LOOP CASINO 2");
				}
			}
		}
		else if (GET() == 22)
		{
			if (DOES_SCRIPT_EXIST("LOOP IN THE CITY"))
			{
				loopcity = !loopcity;
				if (loopcity == true)
				{
					REQUEST_SCRIPT("LOOP IN THE CITY");
					while (!HAS_SCRIPT_LOADED("LOOP IN THE CITY")) WAIT(0);
					START_NEW_SCRIPT("LOOP IN THE CITY", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("LOOP IN THE CITY");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("LOOP IN THE CITY");
				}
			}
		}
		else if (GET() == 23)
		{
			if (DOES_SCRIPT_EXIST("Monsters VS Runners"))
			{
				monstersrunners = !monstersrunners;
				if (monstersrunners == true)
				{
					REQUEST_SCRIPT("Monsters VS Runners");
					while (!HAS_SCRIPT_LOADED("Monsters VS Runners")) WAIT(0);
					START_NEW_SCRIPT("Monsters VS Runners", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("Monsters VS Runners");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("Monsters VS Runners");
				}
			}
		}
		else if (GET() == 24)
		{
			if (DOES_SCRIPT_EXIST("MOTORCYCLE PARKOUR 1") && DOES_SCRIPT_EXIST("MOTORCYCLE PARKOUR 2"))
			{
				motoparkour = !motoparkour;
				if (motoparkour == true)
				{
					REQUEST_SCRIPT("MOTORCYCLE PARKOUR 1");
					while (!HAS_SCRIPT_LOADED("MOTORCYCLE PARKOUR 1")) WAIT(0);
					START_NEW_SCRIPT("MOTORCYCLE PARKOUR 1", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("MOTORCYCLE PARKOUR 1");

					REQUEST_SCRIPT("MOTORCYCLE PARKOUR 2");
					while (!HAS_SCRIPT_LOADED("MOTORCYCLE PARKOUR 2")) WAIT(0);
					START_NEW_SCRIPT("MOTORCYCLE PARKOUR 2", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("MOTORCYCLE PARKOUR 2");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("MOTORCYCLE PARKOUR 1");
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("MOTORCYCLE PARKOUR 2");
				}
			}
		}
		else if (GET() == 25)
		{
			if (DOES_SCRIPT_EXIST("RAMP IN MAZE BANK"))
			{
				rampmaze = !rampmaze;
				if (rampmaze == true)
				{
					REQUEST_SCRIPT("RAMP IN MAZE BANK");
					while (!HAS_SCRIPT_LOADED("RAMP IN MAZE BANK")) WAIT(0);
					START_NEW_SCRIPT("RAMP IN MAZE BANK", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("RAMP IN MAZE BANK");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("RAMP IN MAZE BANK");
				}
			}
		}
		else if (GET() == 26)
		{
			if (DOES_SCRIPT_EXIST("ROLLERCOASTER DEVIL"))
			{
				rolldevil = !rolldevil;
				if (rolldevil == true)
				{
					REQUEST_SCRIPT("ROLLERCOASTER DEVIL");
					while (!HAS_SCRIPT_LOADED("ROLLERCOASTER DEVIL")) WAIT(0);
					START_NEW_SCRIPT("ROLLERCOASTER DEVIL", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("ROLLERCOASTER DEVIL");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("ROLLERCOASTER DEVIL");
				}
			}
		}
		else if (GET() == 27)
		{
			if (DOES_SCRIPT_EXIST("SKY TRACK RACE"))
			{
				skytrack = !skytrack;
				if (skytrack == true)
				{
					REQUEST_SCRIPT("SKY TRACK RACE");
					while (!HAS_SCRIPT_LOADED("SKY TRACK RACE")) WAIT(0);
					START_NEW_SCRIPT("SKY TRACK RACE", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("SKY TRACK RACE");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("SKY TRACK RACE");
				}
			}
		}
		else if (GET() == 28)
		{
			if (DOES_SCRIPT_EXIST("SMALL RAMP RFPLAZA"))
			{
				rampplaza = !rampplaza;
				if (rampplaza == true)
				{
					REQUEST_SCRIPT("SMALL RAMP RFPLAZA");
					while (!HAS_SCRIPT_LOADED("SMALL RAMP RFPLAZA")) WAIT(0);
					START_NEW_SCRIPT("SMALL RAMP RFPLAZA", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("SMALL RAMP RFPLAZA");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("SMALL RAMP RFPLAZA");
				}
			}
		}
		else if (GET() == 29)
		{
			if (DOES_SCRIPT_EXIST("STUNTERS VS SNIPERS"))
			{
				stunterssnipers = !stunterssnipers;
				if (stunterssnipers == true)
				{
					REQUEST_SCRIPT("STUNTERS VS SNIPERS");
					while (!HAS_SCRIPT_LOADED("STUNTERS VS SNIPERS")) WAIT(0);
					START_NEW_SCRIPT("STUNTERS VS SNIPERS", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("STUNTERS VS SNIPERS");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("STUNTERS VS SNIPERS");
				}
			}
		}
		else if (GET() == 30)
		{
			if (DOES_SCRIPT_EXIST("SUPER EXTRA HALF LOOP"))
			{
				superhalf = !superhalf;
				if (superhalf == true)
				{
					REQUEST_SCRIPT("SUPER EXTRA HALF LOOP");
					while (!HAS_SCRIPT_LOADED("SUPER EXTRA HALF LOOP")) WAIT(0);
					START_NEW_SCRIPT("SUPER EXTRA HALF LOOP", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("SUPER EXTRA HALF LOOP");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("SUPER EXTRA HALF LOOP");
				}
			}
		}
		else if (GET() == 31)
		{
			if (DOES_SCRIPT_EXIST("TRACK IN THE AIRPORT"))
			{
				trackairport = !trackairport;
				if (trackairport == true)
				{
					REQUEST_SCRIPT("TRACK IN THE AIRPORT");
					while (!HAS_SCRIPT_LOADED("TRACK IN THE AIRPORT")) WAIT(0);
					START_NEW_SCRIPT("TRACK IN THE AIRPORT", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("TRACK IN THE AIRPORT");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("TRACK IN THE AIRPORT");
				}
			}
		}
		else if (GET() == 32)
		{
			if (DOES_SCRIPT_EXIST("TRACK UNDER THE MAP"))
			{
				trackmap = !trackmap;
				if (trackmap == true)
				{
					REQUEST_SCRIPT("TRACK UNDER THE MAP");
					while (!HAS_SCRIPT_LOADED("TRACK UNDER THE MAP")) WAIT(0);
					START_NEW_SCRIPT("TRACK UNDER THE MAP", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("TRACK UNDER THE MAP");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("TRACK UNDER THE MAP");
				}
			}
		}
		else if (GET() == 33)
		{
			if (DOES_SCRIPT_EXIST("TWISTER AIRPORT"))
			{
				twisterairport = !twisterairport;
				if (twisterairport == true)
				{
					REQUEST_SCRIPT("TWISTER AIRPORT");
					while (!HAS_SCRIPT_LOADED("TWISTER AIRPORT")) WAIT(0);
					START_NEW_SCRIPT("TWISTER AIRPORT", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("TWISTER AIRPORT");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("TWISTER AIRPORT");
				}
			}
		}
		else if (GET() == 34)
		{
			if (DOES_SCRIPT_EXIST("BASKETBALL HUMAN"))
			{
				basket = !basket;
				if (basket == true)
				{
					REQUEST_SCRIPT("BASKETBALL HUMAN");
					while (!HAS_SCRIPT_LOADED("BASKETBALL HUMAN")) WAIT(0);
					START_NEW_SCRIPT("BASKETBALL HUMAN", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("BASKETBALL HUMAN");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("BASKETBALL HUMAN");
				}
			}
		}
		else if (GET() == 35)
		{
			if (DOES_SCRIPT_EXIST("TWISTER"))
			{
				twister = !twister;
				if (twister == true)
				{
					REQUEST_SCRIPT("TWISTER");
					while (!HAS_SCRIPT_LOADED("TWISTER")) WAIT(0);
					START_NEW_SCRIPT("TWISTER", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("TWISTER");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("TWISTER");
				}
			}
		}
		else if (GET() == 36)
		{
			if (DOES_SCRIPT_EXIST("GP"))
			{
				gp = !gp;
				if (gp == true)
				{
					REQUEST_SCRIPT("GP");
					while (!HAS_SCRIPT_LOADED("GP")) WAIT(0);
					START_NEW_SCRIPT("GP", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("GP");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("GP");
				}
			}
		}
		else if (GET() == 37)
		{
			if (DOES_SCRIPT_EXIST("BIG RAMP 2"))
			{
				bigramp1 = !bigramp1;
				if (bigramp1 == true)
				{
					REQUEST_SCRIPT("BIG RAMP 2");
					while (!HAS_SCRIPT_LOADED("BIG RAMP 2")) WAIT(0);
					START_NEW_SCRIPT("BIG RAMP 2", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("BIG RAMP 2");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("BIG RAMP 2");
				}
			}
		}
		else if (GET() == 38)
		{
			if (DOES_SCRIPT_EXIST("BIG RAMP 3"))
			{
				bigramp2 = !bigramp2;
				if (bigramp2 == true)
				{
					REQUEST_SCRIPT("BIG RAMP 3");
					while (!HAS_SCRIPT_LOADED("BIG RAMP 3")) WAIT(0);
					START_NEW_SCRIPT("BIG RAMP 3", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("BIG RAMP 3");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("BIG RAMP 3");
				}
			}
		}
		else if (GET() == 39)
		{
			if (DOES_SCRIPT_EXIST("BIG RAMP 5"))
			{
				bigramp3 = !bigramp3;
				if (bigramp3 == true)
				{
					REQUEST_SCRIPT("BIG RAMP 5");
					while (!HAS_SCRIPT_LOADED("BIG RAMP 5")) WAIT(0);
					START_NEW_SCRIPT("BIG RAMP 5", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("BIG RAMP 5");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("BIG RAMP 5");
				}
			}
		}
	}

	if (NumMenu == Models_Menu)
	{
		AddTitle("Cyber Mod Loader");
		addOption("Random Outfits Variation");
		addOption("Set Custom Model");
		addOption("Beach Girl");
		addOption("Stripper Girl");
		addOption("Zombie");
		addOption("Alien");
		addOption("Jesus");
		addOption("Chic Girl");
		addOption("Astronaut");
		addOption("Black Ops");
		addOption("Clown");
		addOption("Michael");
		addOption("Trevor");
		addOption("Franklin");
		addOption("Pig");
		addOption("Mountain Lion");
		addOption("Monkey");
		AddSubTitle("Outfits and Models Menu");

		if (GET() == 1)
		{
			SET_PED_RANDOM_COMPONENT_VARIATION(PLAYER_PED_ID(), 1);
		}
		else if (GET() == 2)
		{
			g_bKeyBoardDisplayed3 = true;
			DISPLAY_ONSCREEN_KEYBOARD(0, "FMMC_KEY_TIP8", "", "", "", "", "", 40);
		}
		else if (GET() == 3)
		{
			changeModel("a_f_y_beach_01");
		}
		else if (GET() == 4)
		{
			changeModel("S_F_Y_STRIPPER_02");
		}
		else if (GET() == 5)
		{
			changeModel("U_M_Y_Zombie_01");
		}
		else if (GET() == 6)
		{
			changeModel("S_M_M_MovAlien_01");
		}
		else if (GET() == 7)
		{
			changeModel("u_m_m_jesus_01");
		}
		else if (GET() == 8)
		{
			changeModel("a_f_y_genhot_01");
		}
		else if (GET() == 9)
		{
			changeModel("S_M_M_MovSpace_01");
		}
		else if (GET() == 10)
		{
			changeModel("s_m_y_blackops_01");
		}
		else if (GET() == 11)
		{
			changeModel("S_M_Y_Clown_01");
		}
		else if (GET() == 12)
		{
			changeModel("s_m_y_cop_01");
		}
		else if (GET() == 13)
		{
			changeModel("player_two");
		}
		else if (GET() == 14)
		{
			changeModel("player_one");
		}
		else if (GET() == 15)
		{
			changeModel("a_c_pig");
		}
		else if (GET() == 16)
		{
			changeModel("a_c_mtlion");
		}
		else if (GET() == 17)
		{
			changeModel("a_c_rhesus");
		}
	}

	if (NumMenu == Main_Scripts)
	{
		AddTitle("Cyber Mod Loader");
		CheckBoxScript("AP II Intense", Apii, buttonR1, buttonSquare);
		CheckBoxScript("K&K Dark Horse", KK, buttonL1, buttonR1);
		CheckBoxScript("NotYourDope Menu", NYD, buttonR1, buttonDown);
		CheckBoxScript("Revolution Menu", Revolution, buttonRight, buttonSquare);
		CheckBoxScript("Arabic Guy Menu", Arabic, buttonRight, buttonX);
		CheckBoxScript("iLLuminate Menu", Illuminate, buttonRight, buttonX);
		CheckBoxScript("Unrestrained Menu", Unrestrained, buttonL1, buttonSquare);
		CheckBoxScript("ProjectCL Menu", ProjCL, buttonRight, buttonSquare);
		CheckBoxScript("Console Trainer V", ConsoleTrainer, buttonR1, buttonLeft);
		CheckBoxScript("Spawn Car Design Menu", spawncardesign, buttonL1, buttonTriangle);
		CheckBoxScript("Funny Cars Loader", FunnyCar, buttonRight, buttonR3);
		CheckBoxScript("Ultimate Teleport Menu", UltimateTelep, buttonR1, buttonCircle);
		CheckBoxScript("Antraxx Map Menu", Antraxx, buttonL1, buttonCircle);
		CheckBoxScript("Garage Editor", GarageEditor, buttonRight, buttonX);
		AddSubTitle("Main Mod Menus");

		if (GET() == 1)
		{
			if (DOES_SCRIPT_EXIST("rock_menu2"))
			{
				Apii = !Apii;
				if (Apii == true)
				{
					REQUEST_SCRIPT("rock_menu2");
					while (!HAS_SCRIPT_LOADED("rock_menu2")) WAIT(0);
					START_NEW_SCRIPT("rock_menu2", 2024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("rock_menu2");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("rock_menu2");
				}
			}
		}
		else if (GET() == 2)
		{
			if (DOES_SCRIPT_EXIST("darkhorse"))
			{
				KK = !KK;
				if (KK == true)
				{
					REQUEST_SCRIPT("darkhorse");
					while (!HAS_SCRIPT_LOADED("darkhorse")) WAIT(0);
					START_NEW_SCRIPT("darkhorse", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("darkhorse");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("darkhorse");
				}
			}
		}
		else if (GET() == 3)
		{
			if (DOES_SCRIPT_EXIST("NotYourDope"))
			{
				NYD = !NYD;
				if (NYD == true)
				{
					REQUEST_SCRIPT("NotYourDope");
					while (!HAS_SCRIPT_LOADED("NotYourDope")) WAIT(0);
					START_NEW_SCRIPT("NotYourDope", 2024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("NotYourDope");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("NotYourDope");
				}
			}
		}
		else if (GET() == 4)
		{
			if (DOES_SCRIPT_EXIST("Revolution"))
			{
				Revolution = !Revolution;
				if (Revolution == true)
				{
					REQUEST_SCRIPT("Revolution");
					while (!HAS_SCRIPT_LOADED("Revolution")) WAIT(0);
					START_NEW_SCRIPT("Revolution", 2024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("Revolution");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("Revolution");
				}
			}
		}
		else if (GET() == 5)
		{
			if (DOES_SCRIPT_EXIST("ArabicGuy"))
			{
				Arabic = !Arabic;
				if (Arabic == true)
				{
					REQUEST_SCRIPT("ArabicGuy");
					while (!HAS_SCRIPT_LOADED("ArabicGuy")) WAIT(0);
					START_NEW_SCRIPT("ArabicGuy", 6304);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("ArabicGuy");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("ArabicGuy");
				}
			}
		}
		else if (GET() == 6)
		{
			if (DOES_SCRIPT_EXIST("iLLuminate"))
			{
				Illuminate = !Illuminate;
				if (Illuminate == true)
				{
					REQUEST_SCRIPT("iLLuminate");
					while (!HAS_SCRIPT_LOADED("iLLuminate")) WAIT(0);
					START_NEW_SCRIPT("iLLuminate", 2024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("iLLuminate");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("iLLuminate");
				}
			}
		}
		else if (GET() == 7)
		{
			if (DOES_SCRIPT_EXIST("Unrestrained"))
			{
				Unrestrained = !Unrestrained;
				if (Unrestrained == true)
				{
					REQUEST_SCRIPT("Unrestrained");
					while (!HAS_SCRIPT_LOADED("Unrestrained")) WAIT(0);
					START_NEW_SCRIPT("Unrestrained", 2024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("Unrestrained");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("Unrestrained");
				}
			}
		}
		else if (GET() == 8)
		{
			if (DOES_SCRIPT_EXIST("ProjectCL"))
			{
				ProjCL = !ProjCL;
				if (ProjCL == true)
				{
					REQUEST_SCRIPT("ProjectCL");
					while (!HAS_SCRIPT_LOADED("ProjectCL")) WAIT(0);
					START_NEW_SCRIPT("ProjectCL", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("ProjectCL");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("ProjectCL");
				}
			}
		}
		else if (GET() == 9)
		{
			if (DOES_SCRIPT_EXIST("console_trainer_v"))
			{
				ConsoleTrainer = !ConsoleTrainer;
				if (ConsoleTrainer == true)
				{
					REQUEST_SCRIPT("console_trainer_v");
					while (!HAS_SCRIPT_LOADED("console_trainer_v")) WAIT(0);
					START_NEW_SCRIPT("console_trainer_v", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("console_trainer_v");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("console_trainer_v");
				}
			}
		}
		else if (GET() == 10)
		{
		if (DOES_SCRIPT_EXIST("Spawncar"))
		{
			spawncardesign = !spawncardesign;
			if (spawncardesign == true)
			{
				REQUEST_SCRIPT("Spawncar");
				while (!HAS_SCRIPT_LOADED("Spawncar")) WAIT(0);
				START_NEW_SCRIPT("Spawncar", 1024);
				SET_SCRIPT_AS_NO_LONGER_NEEDED("Spawncar");
			}
			else
			{
				TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("Spawncar");
			}
		}
		}
		else if (GET() == 11)
		{
			if (DOES_SCRIPT_EXIST("FCLoader"))
			{
				FunnyCar = !FunnyCar;
				if (FunnyCar == true)
				{
					REQUEST_SCRIPT("FCLoader");
					while (!HAS_SCRIPT_LOADED("FCLoader")) WAIT(0);
					START_NEW_SCRIPT("FCLoader", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("FCLoader");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("FCLoader");
				}
			}
		}
		else if (GET() == 12)
		{
			if (DOES_SCRIPT_EXIST("franklinz"))
			{
				UltimateTelep = !UltimateTelep;
				if (UltimateTelep == true)
				{
					REQUEST_SCRIPT("franklinz");
					while (!HAS_SCRIPT_LOADED("franklinz")) WAIT(0);
					START_NEW_SCRIPT("franklinz", 2024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("franklinz");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("franklinz");
				}
			}
		}
		else if (GET() == 13)
		{
			if (DOES_SCRIPT_EXIST("MapLoader"))
			{
				Antraxx = !Antraxx;
				if (Antraxx == true)
				{
					REQUEST_SCRIPT("MapLoader");
					while (!HAS_SCRIPT_LOADED("MapLoader")) WAIT(0);
					START_NEW_SCRIPT("MapLoader", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("MapLoader");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("MapLoader");
				}
			}
		}
		else if (GET() == 14)
		{
			if (DOES_SCRIPT_EXIST("GarageEditor"))
			{
				GarageEditor = !GarageEditor;
				if (GarageEditor == true)
				{
					REQUEST_SCRIPT("GarageEditor");
					while (!HAS_SCRIPT_LOADED("GarageEditor")) WAIT(0);
					START_NEW_SCRIPT("GarageEditor", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("GarageEditor");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("GarageEditor");
				}
			}
		}
	}

	if (NumMenu == Other_Scripts)
	{
		AddTitle("Cyber Mod Loader");
		CheckBoxScript("Unknown Menu", Unknown, buttonL1, buttonSquare);
		CheckBoxScript("3Sock's Online Trainer", SocksOnline, buttonL1, buttonSquare);
		CheckBoxScript("HUD Editor", HudEditor, buttonL1, buttonSquare);
		CheckBoxScript("Mini Menyoo", MiniMenyoo, buttonR1, buttonUp);
		CheckBoxScript("Slinky Menu", SlinkyMenu, buttonR1, buttonX);
		CheckBoxScript("Slinky Animation Menu", SlinkyAnim, buttonR1, buttonRight);
		CheckBoxScript("TheDonBro Menu", TheDonBro, buttonR1, buttonSquare);
		CheckBoxScript("White Menu", White, buttonR1, buttonTriangle);
		CheckBoxScript("Zero Menu", ZeroMenu, buttonL1, buttonCircle);
		CheckBoxScript("Custom Camera", CustomCam, buttonR1, buttonR3);
		CheckBoxScript("Particle Menu", ParticleMenu, buttonRight, buttonSquare);
		CheckBoxScript("Ragdoll Mod", ragdollmod, "", "");
		CheckBoxScript("SuperMan Mode", superman, "", "");
		CheckBoxScript("Fuel Mod", Fuel, "", "");
		CheckBoxScript("Script Loader", scriptloader, "", "");
		CheckBoxScript("Script Loader 2024", scriptloader2, "", "");
		addOption("Add Script");
		AddSubTitle("Other Mod Menus");

		if (GET() == 1)
		{
			if (DOES_SCRIPT_EXIST("Unknown"))
			{
				Unknown = !Unknown;
				if (Unknown == true)
				{
					REQUEST_SCRIPT("Unknown");
					while (!HAS_SCRIPT_LOADED("Unknown")) WAIT(0);
					START_NEW_SCRIPT("Unknown", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("Unknown");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("Unknown");
				}
			}
		}
		if (GET() == 2)
		{
			if (DOES_SCRIPT_EXIST("3s_onlinetrainer1"))
			{
				SocksOnline = !SocksOnline;
				if (SocksOnline == true)
				{
					REQUEST_SCRIPT("3s_onlinetrainer1");
					while (!HAS_SCRIPT_LOADED("3s_onlinetrainer1")) WAIT(0);
					START_NEW_SCRIPT("3s_onlinetrainer1", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("3s_onlinetrainer1");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("3s_onlinetrainer1");
				}
			}
		}
		else if (GET() == 3)
		{
			if (DOES_SCRIPT_EXIST("HudEditorv1"))
			{
				HudEditor = !HudEditor;
				if (HudEditor == true)
				{
					REQUEST_SCRIPT("HudEditorv1");
					while (!HAS_SCRIPT_LOADED("HudEditorv1")) WAIT(0);
					START_NEW_SCRIPT("HudEditorv1", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("HudEditorv1");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("HudEditorv1");
				}
			}
		}
		else if (GET() == 4)
		{
			if (DOES_SCRIPT_EXIST("minimenyoo1"))
			{
				MiniMenyoo = !MiniMenyoo;
				if (MiniMenyoo == true)
				{
					REQUEST_SCRIPT("minimenyoo1");
					while (!HAS_SCRIPT_LOADED("minimenyoo1")) WAIT(0);
					START_NEW_SCRIPT("minimenyoo1", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("minimenyoo1");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("minimenyoo1");
				}
			}
		}
		else if (GET() == 5)
		{
			if (DOES_SCRIPT_EXIST("slinkymodmenu1"))
			{
				SlinkyMenu = !SlinkyMenu;
				if (SlinkyMenu == true)
				{
					REQUEST_SCRIPT("slinkymodmenu1");
					while (!HAS_SCRIPT_LOADED("slinkymodmenu1")) WAIT(0);
					START_NEW_SCRIPT("slinkymodmenu1", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("slinkymodmenu1");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("slinkymodmenu1");
				}
			}
		}
		else if (GET() == 6)
		{
			if (DOES_SCRIPT_EXIST("slinky_anim1"))
			{
				SlinkyAnim = !SlinkyAnim;
				if (SlinkyAnim == true)
				{
					REQUEST_SCRIPT("slinky_anim1");
					while (!HAS_SCRIPT_LOADED("slinky_anim1")) WAIT(0);
					START_NEW_SCRIPT("slinky_anim1", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("slinky_anim1");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("slinky_anim1");
				}
			}
		}
		else if (GET() == 7)
		{
			if (DOES_SCRIPT_EXIST("TheDonBro1"))
			{
				TheDonBro = !TheDonBro;
				if (TheDonBro == true)
				{
					REQUEST_SCRIPT("TheDonBro1");
					while (!HAS_SCRIPT_LOADED("TheDonBro1")) WAIT(0);
					START_NEW_SCRIPT("TheDonBro1", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("TheDonBro1");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("TheDonBro1");
				}
			}
		}
		else if (GET() == 8)
		{
			if (DOES_SCRIPT_EXIST("White"))
			{
				White = !White;
				if (White == true)
				{
					REQUEST_SCRIPT("White");
					while (!HAS_SCRIPT_LOADED("White")) WAIT(0);
					START_NEW_SCRIPT("White", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("White");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("White");
				}
			}
		}
		else if (GET() == 9)
		{
			if (DOES_SCRIPT_EXIST("zeromenu1"))
			{
				ZeroMenu = !ZeroMenu;
				if (ZeroMenu == true)
				{
					REQUEST_SCRIPT("zeromenu1");
					while (!HAS_SCRIPT_LOADED("zeromenu1")) WAIT(0);
					START_NEW_SCRIPT("zeromenu1", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("zeromenu1");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("zeromenu1");
				}
			}
		}
		else if (GET() == 10)
		{
			if (DOES_SCRIPT_EXIST("custom_cam"))
			{
				CustomCam = !CustomCam;
				if (CustomCam == true)
				{
					REQUEST_SCRIPT("custom_cam");
					while (!HAS_SCRIPT_LOADED("custom_cam")) WAIT(0);
					START_NEW_SCRIPT("custom_cam", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("custom_cam");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("custom_cam");
				}
			}
		}
		else if (GET() == 11)
		{
			if (DOES_SCRIPT_EXIST("ParticleMenuV03"))
			{
				ParticleMenu = !ParticleMenu;
				if (ParticleMenu == true)
				{
					REQUEST_SCRIPT("ParticleMenuV03");
					while (!HAS_SCRIPT_LOADED("ParticleMenuV03")) WAIT(0);
					START_NEW_SCRIPT("ParticleMenuV03", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("ParticleMenuV03");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("ParticleMenuV03");
				}
			}
		}
		else if (GET() == 12)
		{
			if (DOES_SCRIPT_EXIST("JRRagdollMod"))
			{
				ragdollmod = !ragdollmod;
				if (ragdollmod == true)
				{
					REQUEST_SCRIPT("JRRagdollMod");
					while (!HAS_SCRIPT_LOADED("JRRagdollMod")) WAIT(0);
					START_NEW_SCRIPT("JRRagdollMod", 128);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("JRRagdollMod");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("JRRagdollMod");
				}
			}
		}
		else if (GET() == 13)
		{
			if (DOES_SCRIPT_EXIST("superman"))
			{
				superman = !superman;
				if (superman == true)
				{
					REQUEST_SCRIPT("superman");
					while (!HAS_SCRIPT_LOADED("superman")) WAIT(0);
					START_NEW_SCRIPT("superman", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("superman");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("superman");
				}
			}
		}
		else if (GET() == 14)
		{
			if (DOES_SCRIPT_EXIST("FuelMod"))
			{
				Fuel = !Fuel;
				if (Fuel == true)
				{
					REQUEST_SCRIPT("FuelMod");
					while (!HAS_SCRIPT_LOADED("FuelMod")) WAIT(0);
					START_NEW_SCRIPT("FuelMod", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("FuelMod");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("FuelMod");
				}
			}
		}
		else if (GET() == 15)
		{
			if (DOES_SCRIPT_EXIST("loader"))
			{
				scriptloader = !scriptloader;
				if (scriptloader == true)
				{
					REQUEST_SCRIPT("loader");
					while (!HAS_SCRIPT_LOADED("loader")) WAIT(0);
					START_NEW_SCRIPT("loader", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("loader");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("loader");
				}
			}
		}
		else if (GET() == 16)
		{
			if (DOES_SCRIPT_EXIST("loader2"))
			{
				scriptloader2 = !scriptloader2;
				if (scriptloader2 == true)
				{
					REQUEST_SCRIPT("loader2");
					while (!HAS_SCRIPT_LOADED("loader2")) WAIT(0);
					START_NEW_SCRIPT("loader2", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("loader2");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("loader2");
				}
			}
		}
		else if (GET() == 17)
		{
			DISPLAY_ONSCREEN_KEYBOARD(0, "FMMC_KEY_TIP8", "", "", "", "", "", 40);
			WAIT(100);
			if (UPDATE_ONSCREEN_KEYBOARD() == 1)
			{
				const char *txt = GET_ONSCREEN_KEYBOARD_RESULT();
				if (DOES_SCRIPT_EXIST(txt))
				{
					REQUEST_SCRIPT(txt);
					while (!HAS_SCRIPT_LOADED(txt)) WAIT(0);
					START_NEW_SCRIPT(txt, 2024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED(txt);
					print("Script loaded", 2000);
				}
				else
				{
					print("~r~Script not found", 2000);
				}
			}
		}
	}

	if (NumMenu == Recovery_Scripts)
	{
		AddTitle("Cyber Mod Loader");
		CheckBoxScript("2much4u Recovery Menu", muchRecovery, buttonRight, buttonX);
		CheckBoxScript("JR Recovery Menu", JRRecovery, buttonRight, buttonR3);
		CheckBoxScript("Danii Recovery Menu", DaniiRecovery, buttonL1, buttonCircle);
		CheckBoxScript("Slinky Recovery Menu", SlinkyRecovery, buttonR1, buttonLeft);
		AddSubTitle("Recovery Mod Menus");

		if (GET() == 1)
		{
			if (DOES_SCRIPT_EXIST("Recoveryv3"))
			{
				muchRecovery = !muchRecovery;
				if (muchRecovery == true)
				{
					REQUEST_SCRIPT("Recoveryv3");
					while (!HAS_SCRIPT_LOADED("Recoveryv3")) WAIT(0);
					START_NEW_SCRIPT("Recoveryv3", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("Recoveryv3");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("Recoveryv3");
				}
			}
		}
		else if (GET() == 2)
		{
			if (DOES_SCRIPT_EXIST("JRrecovery"))
			{
				JRRecovery = !JRRecovery;
				if (JRRecovery == true)
				{
					REQUEST_SCRIPT("JRrecovery");
					while (!HAS_SCRIPT_LOADED("JRrecovery")) WAIT(0);
					START_NEW_SCRIPT("JRrecovery", 1820);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("JRrecovery");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("JRrecovery");
				}
			}
		}
		else if (GET() == 3)
		{
			if (DOES_SCRIPT_EXIST("Recoveryv2"))
			{
				DaniiRecovery = !DaniiRecovery;
				if (DaniiRecovery == true)
				{
					REQUEST_SCRIPT("Recoveryv2");
					while (!HAS_SCRIPT_LOADED("Recoveryv2")) WAIT(0);
					START_NEW_SCRIPT("Recoveryv2", 2024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("Recoveryv2");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("Recoveryv2");
				}
			}
		}
		else if (GET() == 4)
		{
			if (DOES_SCRIPT_EXIST("slinkyrecovery1"))
			{
				SlinkyRecovery = !SlinkyRecovery;
				if (SlinkyRecovery == true)
				{
					REQUEST_SCRIPT("slinkyrecovery1");
					while (!HAS_SCRIPT_LOADED("slinkyrecovery1")) WAIT(0);
					START_NEW_SCRIPT("slinkyrecovery1", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("slinkyrecovery1");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("slinkyrecovery1");
				}
			}
		}
	}

	if (NumMenu == Protections_Scripts)
	{
		AddTitle("Cyber Mod Loader");
		CheckBoxScript("Helper Menu", HelperMenu, buttonLeft, buttonSquare);
		CheckBoxScript("Limox Menu", Limox, buttonR1, buttonL1);
		CheckBoxScript("Modder Protex Menu", modderprotex, buttonRight, buttonSquare);
		CheckBoxScript("Anti Cheater", AntiCheater, buttonL1, buttonX);
		CheckBoxScript("Freeze Protection", FrzProtex, "", "");
		AddSubTitle("Protection Mod Menus");

		if (GET() == 1)
		{
			if (DOES_SCRIPT_EXIST("HelperMenu"))
			{
				HelperMenu = !HelperMenu;
				if (HelperMenu == true)
				{
					REQUEST_SCRIPT("HelperMenu");
					while (!HAS_SCRIPT_LOADED("HelperMenu")) WAIT(0);
					START_NEW_SCRIPT("HelperMenu", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("HelperMenu");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("HelperMenu");
				}
			}
		}
		else if (GET() == 2)
		{
			if (DOES_SCRIPT_EXIST("SCRIPT"))
			{
				Limox = !Limox;
				if (Limox == true)
				{
					REQUEST_SCRIPT("SCRIPT");
					while (!HAS_SCRIPT_LOADED("SCRIPT")) WAIT(0);
					START_NEW_SCRIPT("SCRIPT", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("SCRIPT");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("SCRIPT");
				}
			}
		}
		else if (GET() == 3)
		{
			if (DOES_SCRIPT_EXIST("protection"))
			{
				modderprotex = !modderprotex;
				if (modderprotex == true)
				{
					REQUEST_SCRIPT("protection");
					while (!HAS_SCRIPT_LOADED("protection")) WAIT(0);
					START_NEW_SCRIPT("protection", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("protection");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("protection");
				}
			}
		}
		else if (GET() == 4)
		{
			if (DOES_SCRIPT_EXIST("AntiCheater1"))
			{
				AntiCheater = !AntiCheater;
				if (AntiCheater == true)
				{
					REQUEST_SCRIPT("AntiCheater1");
					while (!HAS_SCRIPT_LOADED("AntiCheater1")) WAIT(0);
					START_NEW_SCRIPT("AntiCheater1", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("AntiCheater1");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("AntiCheater1");
				}
			}
		}
		else if (GET() == 5)
		{
			if (DOES_SCRIPT_EXIST("frzprotex"))
			{
				FrzProtex = !FrzProtex;
				if (FrzProtex == true)
				{
					REQUEST_SCRIPT("frzprotex");
					while (!HAS_SCRIPT_LOADED("frzprotex")) WAIT(0);
					START_NEW_SCRIPT("frzprotex", 1024);
					SET_SCRIPT_AS_NO_LONGER_NEEDED("frzprotex");
				}
				else
				{
					TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME("frzprotex");
				}
			}
		}
	}
	
	Setup_System();
}

void main()
{
    NETWORK_SET_SCRIPT_IS_SAFE_FOR_NETWORK_GAME();
	if (NETWORK_IS_GAME_IN_PROGRESS() && !NETWORK_GET_THIS_SCRIPT_IS_NETWORK_SCRIPT())
	{
		NETWORK_SET_THIS_SCRIPT_IS_NETWORK_SCRIPT(18, 0, -1);
		NETWORK_GET_SCRIPT_STATUS();
	}
	REQUEST_STREAMED_TEXTURE_DICT("timerbars", false);
	REQUEST_STREAMED_TEXTURE_DICT("mpleaderboard", false);
	REQUEST_STREAMED_TEXTURE_DICT("mpinventory", false);
	REQUEST_STREAMED_TEXTURE_DICT("mprankbadge", false);
	REQUEST_STREAMED_TEXTURE_DICT("commonmenu", false);
	REQUEST_STREAMED_TEXTURE_DICT("commonmenutu", false);
	REQUEST_STREAMED_TEXTURE_DICT("speedometers", false);
	WAIT(100);
	do
	{
		if (SetGlobal(2394218 + 550 + 6 , NULL, 1) == 0)
		{
			GlareX = 1.1149;
			GlareY = 0.4350;
		}
		if (SetGlobal(2394218 + 550 + 6, NULL, 1) == 0)
		{
			ENABLE_ALL_CONTROL_ACTIONS(2);
			ENABLE_ALL_CONTROL_ACTIONS(0);
			NumMenu = Closed;
		}
		if ((SetGlobal(10434 + 1, NULL, 1) == 10) || (SetGlobal(10434 + 1, NULL, 1) == 9))
		{
			int Global_1688 = SetGlobal(1688, NULL, 1);
			SET_BIT(&Global_1688, 16);
		}
			
		SetGlobal(11729, 5, 0);
		int Global_1687 = SetGlobal(1687, NULL, 1);
		SET_BIT(&Global_1687, 30);
		CLEAR_BIT(&Global_1687, 30);
		WAIT(0);
		SetupButtons();
		Menu();

		if (notifok == false)
		{
			_SET_NOTIFICATION_TEXT_ENTRY("STRING");
			ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME("Cyber Mod Loader v2.4.4 \nOpen with ~b~L3 + X");
			_DRAW_NOTIFICATION(0, 1);

			_SET_NOTIFICATION_TEXT_ENTRY("STRING");
			ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME("~r~Respect other players !!");
			_DRAW_NOTIFICATION(1, 1);

			if (NumMenu != Closed)
			{
				notifok = true;
			}
		}

		SuperJump_Func();
		SuperPunch_Func();
		IperJump_Func();
		SuperRun_Func();
		SuperMan_Function();
		NeverWant_Func();
		ExplosiveAmmo_Func();
		FireAmmo_Func();
		Godmode_Func();
		Boss_Func();
		SMoneyDrop_Func();
		GodmodeVeh_Func();
		StickGround_Func();
		Speedom_Func();
		TireLoop_Func();
		ResprayLoop_Func();
		DoorsLoop_Func();
		VehJumpLoop_Func();
		NOS_Func();
		Stop_Func();
		Forcefield_Func();
		KeyboardVeh_Check();
		KeyboardModel_Check();
		telepWayp();
		AllPlayersExplode();
		HostileNearPeds();
		FPSDisp();
		SetNeons();
		LightGen();
	} 
	while (true);
}
