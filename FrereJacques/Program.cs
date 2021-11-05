﻿using System;
using System.Speech.Synthesis;
using System.Threading;
using System.Threading.Tasks;

namespace FrereJacques
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowVoices();
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
            Console.WriteLine("What would you like me to say?");
            robot.Speak(Console.ReadLine());
        }

        private static void ShowVoices()
        {
            SpeechSynthesizer robot = new SpeechSynthesizer();
            var voices = robot.GetInstalledVoices();
       
            
        }
    }
}
