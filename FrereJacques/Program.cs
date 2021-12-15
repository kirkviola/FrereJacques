using System;
using System.Speech.Synthesis;
using System.Threading;
using System.Threading.Tasks;

namespace FrereJacques
{
    class Program
    {
        static void Main(string[] args)
        {
            RoboReader();
            Celebrate();

           
        }

        private static void PlayFrereJacques()
        {
            Console.Beep(294, 500); // D
            Console.Beep(330, 500); // E
            Console.Beep(370, 500); // F#
            Console.Beep(294, 500); // D

            Console.Beep(294, 500); // D
            Console.Beep(330, 500); // E
            Console.Beep(370, 500); // F#
            Console.Beep(294, 500); // D

            Console.Beep(370, 500); // F#
            Console.Beep(392, 500); // G
            Console.Beep(440, 1000); // A

            Console.Beep(370, 500); // F#
            Console.Beep(392, 500); // G
            Console.Beep(440, 1000); // A

            Console.Beep(440, 250); // A
            Console.Beep(494, 250); // B
            Console.Beep(440, 250); // A
            Console.Beep(392, 500); // G
            Console.Beep(370, 500); // F#
            Console.Beep(294, 500); // D

            Console.Beep(440, 250); // A
            Console.Beep(494, 250); // B
            Console.Beep(440, 250); // A
            Console.Beep(392, 500); // G
            Console.Beep(370, 500); // F#
            Console.Beep(294, 500); // D

            Console.Beep(294, 500); // D
            Console.Beep(440, 500); // A
            Console.Beep(294, 1000); // D

            Console.Beep(294, 500); // D
            Console.Beep(440, 500); // A
            Console.Beep(294, 1000); // D
        }

        private static void PlayOdeToJoy()
        {
            Console.Beep(370, 500); // F#
            Console.Beep(370, 500); // F#
            Console.Beep(392, 500); // G
            Console.Beep(440, 250); // A
            Console.Beep(440, 250); // A
            Console.Beep(392, 500); // G
            Console.Beep(370, 500); // F#
            Console.Beep(330, 500); // E
            Console.Beep(294, 500); // D
            Console.Beep(294, 500); // D
            Console.Beep(330, 500); // E
            Console.Beep(370, 500); // F#
            Console.Beep(370, 750); // F#
            Console.Beep(330, 250); // E
            Console.Beep(330, 1000); // E

            Console.Beep(370, 500); // F#
            Console.Beep(370, 500); // F#
            Console.Beep(392, 500); // G
            Console.Beep(440, 250); // A
            Console.Beep(440, 250); // A
            Console.Beep(392, 500); // G
            Console.Beep(370, 500); // F#
            Console.Beep(330, 500); // E
            Console.Beep(294, 500); // D
            Console.Beep(294, 500); // D
            Console.Beep(330, 500); // E
            Console.Beep(370, 500); // F#
            Console.Beep(330, 750); // E
            Console.Beep(294, 250); // D
            Console.Beep(294, 1000); // D

            Console.Beep(330, 500); // E
            Console.Beep(330, 500); // E
            Console.Beep(370, 500); // F#
            Console.Beep(294, 500); // D
            Console.Beep(330, 500); // E
            Console.Beep(370, 250); // F#
            Console.Beep(392, 250); // G
            Console.Beep(370, 500); // F#
            Console.Beep(294, 500); // D
            Console.Beep(330, 500); // E
            Console.Beep(370, 250); // F#
            Console.Beep(392, 250); // G
            Console.Beep(370, 500); // F#
            Console.Beep(330, 500); // E
            Console.Beep(294, 500); // D
            Console.Beep(330, 500); // E
            Console.Beep(440, 1000); // A

            Console.Beep(370, 500); // F#
            Console.Beep(370, 500); // F#
            Console.Beep(392, 500); // G
            Console.Beep(440, 250); // A
            Console.Beep(440, 250); // A
            Console.Beep(392, 500); // G
            Console.Beep(370, 500); // F#
            Console.Beep(330, 500); // E
            Console.Beep(294, 500); // D
            Console.Beep(294, 500); // D
            Console.Beep(330, 500); // E
            Console.Beep(370, 500); // F#
            Console.Beep(330, 750); // E
            Console.Beep(294, 250); // D
            Console.Beep(294, 1000); // D
        }

        private static void RoboReader()
        {
            SpeechSynthesizer robot = new SpeechSynthesizer();
            robot.SelectVoiceByHints(VoiceGender.Male);
            Console.WriteLine("What would you like me to say?");
            robot.Speak(Console.ReadLine());
            //RoboReader();
        }

        private static void GetHacked()
        {
            SpeechSynthesizer robot = new SpeechSynthesizer();
            robot.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            robot.Speak("Get hacked noob.");
        }

        private static void ShaveAndHaircut()
        {
            Console.Beep(587, 500);
            Console.Beep(440, 250);
            Console.Beep(440, 250);
            Console.Beep(494, 500);
            Console.Beep(440, 500);
            Thread.Sleep(500);
            Console.Beep(554, 500);
            Console.Beep(587, 500);
        }

        private static void WompWomp()
        {
            Console.Beep(392, 500);
            Console.Beep(370, 500);
            Console.Beep(349, 1000);
        }

        private static void Celebrate()
        {
            Console.Beep(392, 1500);
            Console.Beep(370, 500);
            Console.Beep(392, 500);
            Console.Beep(370, 500);
            Console.Beep(330, 500);
            Console.Beep(440, 250);
            Console.Beep(440, 250);
        }
    }
}
