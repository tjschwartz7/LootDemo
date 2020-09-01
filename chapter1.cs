using System;
using System.Collections.Generic;
using System.Text;

namespace LootDemo
{
    class chapter1
    {
        public static void chapterOne(player newPlayer)
        {
            partyMembers member = new partyMembers();
            bool isAlive = true;
            enemies Enemy = new enemies();
            Console.WriteLine("A pale blue dot in a sun beam.");
            Console.WriteLine("A cold, red planet millions of miles away.");
            Console.WriteLine("A young boy is looking towards the pale blue dot. He can just barely glimpse it through Mars' nonexistent atmosphere.");
            Console.WriteLine("Little does it matter. Life is a fickle thing. One second its there, one second its ceases to be.");
            Console.WriteLine("Same goes for the pale blue dot. As the dot fades into obscurity, tears fall in remembrance of what once was, and what now remains.");
            Console.WriteLine("Where once was life now remains darkness. Its almost as if nothing ever existed there at all.");
            Console.WriteLine("Questions linger, as to the meaning of it all.");
            Console.WriteLine("But the boy will have to find answers for himself.");
            Console.ReadLine();
            Console.WriteLine("16 YEARS LATER...");
            Console.ReadLine();
            Console.WriteLine("RAHL: Okay. So you're telling me you don't have any money? At all?");
            Console.WriteLine("RAHL: What if I told you that if you don't pay up I'll just take it off your corpse?");
            Console.WriteLine("STU: I, I mean, i'm not interested in that deal.");
            Console.WriteLine("STU: Hey, you! What's your name, pal?");
            Console.WriteLine("Enter your name: ");
            newPlayer.name = Console.ReadLine();
            Console.WriteLine("STU: " + newPlayer.name + ", huh? Pleased to meet ya, now, could you help me deal with this guy? Here's some weapons for ya.");
            GunPulled Chub = new GunPulled("MarsWares", "Pistol", "Chub", Math.Pow(7, 2) * newPlayer.level, 9, 70, 20, 2);
            newPlayer.gunPrimary = Chub;
            newPlayer.gunEquip = newPlayer.gunPrimary;

            GunPulled Dagger = new GunPulled("MarsWares", "Melee", "Dagger", Math.Pow(14, 2) * newPlayer.level, 3, 80, 20, 3);
            newPlayer.gunSecondary = Dagger;
            isAlive = Combat.combat(Enemy.Rahl, newPlayer, 1);
            Console.WriteLine("STU: Whew, you saved my hide there.");
            Console.WriteLine("STU: Hey, what're you doing here anyways?");
            Console.ReadLine();
            Console.WriteLine("STU: This seems like an odd place for a gunslinger to hang out, you know.");
            Console.WriteLine("STU: I just came here to have some booze and forget about, you know... whatever.");
            Console.WriteLine("(1): I'm just passing through.");
            Console.WriteLine("(2): None of your business.");
            Console.WriteLine("(3): I'm just wandering aimlessly, to be honest.");
            Console.WriteLine("(4): If I knew where I was going I wouldn't be caught dead here, I'll tell you that much.");
            Console.WriteLine("(5): I dunno. Where are we, anyways?");
            int choice;
            int.TryParse(Console.ReadLine(), out choice);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("STU: That's it, huh? Nowhere specific in mind? I'd be keen on getting down to Cratertown, myself.\nSTU: If I had the means, anyway.");
                    break;
                case 2:
                    Console.WriteLine("STU: Hey, I was just askin'. No need to get worked up.");
                    break;
                case 3:
                    Console.WriteLine("STU: Nothing wrong with that. Troubled times as of the moment, not surprised you're so effective with a firearm.\nSTU: If'n you got the means, might as well ya head down to Cratertown. Safest place you'll find this side a'Mars.");
                    break;
                case 4:
                    Console.WriteLine("STU: Ha. Fair, fair. If I were you I'd head straight for Cratertown, leave this dump.");
                    break;
                case 5:
                    Console.WriteLine("STU: Why this is the Red Sands Bar, dump side of the Red Sands region.");
                    Console.WriteLine("STU: If you were looking for a slum, you just found it here.");
                    break;
                default:
                    Console.WriteLine("STU: Quiet guy, huh? Why is this damn neighborhood full of weirdos?");
                    break;
            }
            Console.WriteLine("STU: Alright, I'll tell you what. As thanks for saving my hide, I'll escort you to Cratertown. Free of charge.");
            Console.WriteLine("STU: Also, it'll help get me out of this dump, so there's that.");
            Console.WriteLine("STU: You'll let me tag along, right?");
            Console.WriteLine("Yes or No?");
            string stringInput = Console.ReadLine();
            if (stringInput.ToLower() == "yes")
            {
                Console.WriteLine("STU: Excellent. Let's get the hell out of here.");
            }
            else
            {
                Console.WriteLine("STU: I insist, you can't just leave me here! No, no, I'm coming with you.");
            }
            Console.ReadLine();
            Console.WriteLine("Stu has joined your party!");
            Console.ReadLine();
            Console.WriteLine("You have gained a party member! Some party members will do different things for you during combat.");
            Console.WriteLine("Stu will sometimes stun the enemies with a handmade flash grenade, forcing them to skip their turn.");
            Console.WriteLine("Sometimes a party member's ability won't be so obvious, so you'll have to keep an eye out.");
            Console.ReadLine();
         

            Console.WriteLine("With Stu's guidance, you head out of the dank bar and into the streets of Red Sands grotto.");
            Console.WriteLine("The buildings are all run down and decrepit. A huge glass dome surrounds you.");
            Console.ReadLine();
            Console.WriteLine("STU: If we just head north, we can go towards the north gate and into the Green Dome\nFrom there if we continue west we'll find the Cratertown gate.");
            Console.WriteLine("You head north, up the streets. You pass several shady looking people sitting by oil fires.");
            Console.ReadLine();
            Console.WriteLine("STU: Watch out through here. Some people will just up and kill ya if they think you've got anything that can pay for dinner.");
            Console.WriteLine("STU: Ah, here come some dumpfolk. Great, just what we needed right now.");
            Console.ReadLine();
            Console.WriteLine("THUG: Hey you, give us yer valuables or else... I, I'll pierce ya through meself!");
            Console.ReadLine();
            isAlive = Combat.combat(Enemy.Thug, newPlayer, 2);
            Console.WriteLine("STU: Damn, you're not bad. Two people at once? I'm glad you're on my side, pal.");
            Console.WriteLine("(1): I'm not bad.");
            Console.WriteLine("(2): Why are you even here? I hope you aren't planning on being a freeloader.");
            Console.WriteLine("(3): Thanks, glad to have you here, Stu.");
            Console.WriteLine("(4): I've noticed your flash grenades, where'd you get them from?");
            int.TryParse(Console.ReadLine(), out choice);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("STU: Not bad? I guess that's one way to put it.\nSTU: You're a real killer, " + newPlayer.name + ". I'd better not tick you off.");
                    break;
                case 2:
                    Console.WriteLine("STU: I already told you, I'm trying to get out of the Red Sands region. It's god awful there.");
                    break;
                case 3:
                    Console.WriteLine("STU: Thanks, " + newPlayer.name + ".\nSTU: Hopefully we can get into the Cratertown Dome with no hassle, I'd sooner sleep in a beef beast nest than Red Sands bar. I'd probably be safer.");
                    break;
                case 4:
                    Console.WriteLine("STU: I handcraft them. I was once an explosives engineer, but... things have changed.\nSTU: I've been working on something special also. I might try it out sometime, but uh... I don't have many, so I'll likely hold off.");
                    break;
                default:
                    Console.WriteLine("STU: Nothing to say? Is that modesty, or..? Well, you do you I suppose.");
                    break;
            }
            Console.WriteLine("STU: Well, let's just keep moving. We need to keep north for now.");
            Console.WriteLine("STU: We'll be walking for probably another hour or so. Then we'll reach the Green Dome gate.");
            Console.ReadLine();
            Console.WriteLine("You walk along the road, leaving Red Sands grotto behind you.");
            Console.WriteLine("You are now on open highway, your left and right both containing vast expanses of red sand.");
            Console.WriteLine("Ahead of you on your right is a rover station, with a bill board posted outside of it.");
            Console.WriteLine("The billboard reads \"Don't just drink smart... Drink Ultra Smart! Your Ultra source of nutrients and bullet mending technology!\"");
            Console.ReadLine();
            Console.WriteLine("STU: Shockingly, that stuff actually works. I don't know how many years its taken off my life at this point, but at least its kept me from bein' dead more times than I can count.");
            Console.WriteLine("STU: Let's check this rover station. Maybe he's got some deals for us in there.");
            Console.ReadLine();
            Console.WriteLine("You walk into the rover station, whose slogan reads \"Where rovers refill for a voyage beyond the stars!\"");
            Console.WriteLine("You walk into the station building itself, a small building with some windows. It's lined with shelves of general purpose stuff, like sugar drinks and booze.");
            Console.WriteLine("The man behind the cash register looks up at you, seemingly surprised at having anyone enter his shop.");
            Console.ReadLine();
            Console.WriteLine("MAN: Why hello, isn't it a beautiful day today under these martian skies? A wonderful day for some Ultra Smart, for certain!");
            Console.WriteLine("STU: Don't you think you're laying it on a bit thick? We're heading to the Green Dome, and were looking to pick up some supplies.");
            Console.ReadLine();
            Console.WriteLine("MAN: Thick?! Whatever could you... oh screw it. Ultra Corp is really pressuring me to sell this stuff, alright? If I don't sell enough of it, they're putting me out of business!");
            Console.WriteLine("MAN: Could you just buy some of this stuff? Please? In fact, they're just pressuring me to get it off the shelves, so I'll sell a bunch of it to you for dirt cheap. Just take some, please?");
            Console.ReadLine();
            Console.WriteLine("STU: Uh, ok. I'll take however many you want to sell me.");
            Console.WriteLine("STU: Oh, and, " + newPlayer.name + ", don't worry about it. These are on me.");
            Console.ReadLine();
            Console.WriteLine("MAN: Oh, thank you so much. If I don't sell enough of these this month I'll be put out of damn business.");
            Console.WriteLine("You have received 8 Ultra Smart drinks.");
            newPlayer.ultraSmartDrinks += 8;
            Console.WriteLine("You now have some Ultra Smart drinks!\nDon't think too hard about what negative consequences this might have on your body,");
            Console.WriteLine("rather you should be thinking about how alive you'll be when you use it! - sponsored by Ultra Corp TM");
            Console.WriteLine("Use this in battle by using the 'h' option, and you'll be healed for half of your max hp.");
            Console.ReadLine();
            Console.WriteLine("STU: Here ya go, pal. These should help out in a pinch.");
            Console.WriteLine("MAN: Uh, so I wouldn't recommend you drink too many of those at once. You, know, its, uh, it wouldn't be good for you. Lot of sugar, right? Haha, ha.");
            Console.ReadLine();
            Console.WriteLine("STU: Thanks for the advice? We'll take our leave now, thanks.");
            Console.WriteLine("You head out of the rover station, and back under the huge Red Sands dome. Some people are walking down the road, armed with rocket launchers.");
            Console.ReadLine();
            Console.WriteLine("STU: Uh, let's go hide inside for now.");
            Console.WriteLine("As you head back towards the station, you notice that the man has locked the door and is nowhere to be seen.");
            Console.ReadLine();
            Console.WriteLine("STU: Well, this isn't how I planned today to go. Three gunfights in one day? What a miraculous turn of events.");
            Console.WriteLine("STU: Look, maybe we can avoid a fight. These guys are raiders, they roam the open areas in the domes and kill anyone who might have anything of value to them.");
            Console.WriteLine("STU: Just don't make eye contact.");
            Console.ReadLine();
            Console.WriteLine("The raiders notice you, however. They walk straight up to you, rpg's out.");
            Console.WriteLine("RAIDER: Isn't it your lucky day? I'll take everything you've got. Also, make it quick. I've gotta go take a leak.");
            Console.ReadLine();
            Console.WriteLine("STU: We don't have nuthin', I'm sorry to say.");
            Console.ReadLine();
            Console.WriteLine("RAIDER: Is that right? These fellas sound like they're putting up a fight, would you agree Sai?");
            Console.WriteLine("SAI: Hmph.");
            Console.WriteLine("STU: So much for not having to fight...");
            Console.ReadLine();
            isAlive = Combat.combat(Enemy.raiderRPG, newPlayer, 2);
            Console.WriteLine("STU: Huh, guys had a lot of gusto for being such weaklings. And you, Sai was it?");
            Console.WriteLine("STU: You weren't fighting with them. Who are you?");
            Console.ReadLine();
            Console.WriteLine("SAI: Please don't kill me. They dragged me along with them because I'm a medic. Otherwise, they would have killed me by now.");
            Console.WriteLine("SAI: Look, if you don't kill me I can join you. I'll provide medic capabilities in combat.");
            Console.ReadLine();
            Console.WriteLine("STU: Well, " + newPlayer.name + ", I think we should give him a chance. What say you?");
            Console.WriteLine("Yes or No?");
            string option = Console.ReadLine();
            if(option.ToLower() == "yes")
            {
                Console.WriteLine("STU: I agree. Alright Sai, you're coming with us.");
            }
            else
            {
                Console.WriteLine("STU: Don't you think that's a bit harsh?\nSTU: This isn't a democracy, I'm just gonna pretend you said yes. No need to be a jerk.");
            }
            Console.ReadLine();
            Console.WriteLine("Sai has joined your party!");
            member.Sai.inParty = true;
            Console.ReadLine();
            Console.WriteLine("SAI: Alright, thanks for having me. I swear I'll make this up to you, I might even save your life at some point!");
            Console.WriteLine("STU: We're going to Cratertown. Heard only nice things about it.");
            Console.ReadLine();
            Console.WriteLine("SAI: I used to live there at one point. It's actually patrolled by the Mars Police Force, so its not quite as lawless as Red Sands.");
            Console.WriteLine("STU: That sounds like what I've 'erd. We're almost to Green Dome gate now, so let's hit the road.");
            Console.WriteLine("SAI: Got it. Let's go, then.");
            Console.ReadLine();

            Console.WriteLine("END OF CHAPTER 1");
            Console.ReadLine();
            Console.Clear();
            
                
        }
    }
}
