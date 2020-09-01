using System;
using System.Collections.Generic;
using System.Text;

namespace LootDemo
{
    class chapter2
    {
        
        public static void Write(string sentence)
        {
            Console.WriteLine(sentence);
        }
        public static void Read()
        {
            Console.ReadLine();
        }
        public static void chapterTwo(player newPlayer)
        {
            partyMembers member = new partyMembers();
            bool isAlive = true;
            enemies Enemy = new enemies();


            Console.WriteLine("As the trio continues north, the Green Dome gate becomes visible in the distance.");
            Console.WriteLine("You look behind you, seeing Red Sands grotto off in the distance, hidden slightly by the artificial atmosphere.");
            Console.ReadLine();
            Console.WriteLine("STU: I'm not gonna miss that place. So many dumpfolk and other trash roam that place, sulking in their own damn misery.");
            Console.WriteLine("SAI: Not far off from Cratertown. Only difference is the violent thugs get dealt with by the police force.");
            Console.WriteLine("STU: Thats a step up, at the least.");
            Console.ReadLine();
            Console.WriteLine("As the gate gets closer, you see several guards standing by.");
            Console.WriteLine("STU: We're approaching the checkpoint. Let me handle this, I'm hoping I can get us in there.");
            Console.ReadLine();
            Console.WriteLine("GUARD: Stay back. Present your ID.");
            Console.WriteLine("STU: Hail, sir. We have important business in Cratertown.");
            Console.WriteLine("GUARD: Is that right? Let me go... discuss this with upper management.");
            Console.WriteLine("STU: Hopefully they just let us pass. I've not heard of them being super strict here before.");
            Console.ReadLine();
            Console.WriteLine("The guards return, approaching Stu.");
            Console.WriteLine("GUARD: Alright, Stu, follow me. We'll get you sorted out.");
            Console.WriteLine("Stu backs off a bit.");
            Console.ReadLine();
            Console.WriteLine("STU: You know my name?");
            Console.WriteLine("GUARD: Hmm. You're pretty popular around here, Stu. We've been wondering when you'd show up.");
            Console.WriteLine("STU: I think we're just gonna... go.");
            Console.ReadLine();
            Console.WriteLine("GUARD: No, I don't think so. We've got some questions we need to ask you. You're coming with us.");
            Write("STU: You're with Baris. Why are you posted here?");
            Write("GUARD: Heh. Baris and the police force struck a deal. Long story short, we have permission to kill you on sight.");
            Read();
            Write("STU: Look, " + newPlayer.name + ", I'll explain this later. Let's just take care of these guys.");
            Write("GUARD: Take care of us? You guys hear that? Well, we'll see about that.");
            Read();
            isAlive = Combat.combat(Enemy.RedSandsGuard, newPlayer, 2);
        }
    }
}
