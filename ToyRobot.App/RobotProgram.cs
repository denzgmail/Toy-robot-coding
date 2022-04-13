using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using ToyRobot.App.Entities;
using ToyRobot.App.Utilities;

namespace ToyRobot.App
{
    class RobotProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MessageText.OpenningMessage);
            Console.Write(MessageText.PromptMessage);
            var keyValue =  ' ';
            for(; ; )//this will wait until Y or N was pressed.
            {
                ConsoleKeyInfo keypressed = Console.ReadKey(true);
                if (new Regex(@"^[YN]$").IsMatch(keypressed.KeyChar.ToString().ToUpper()))
                {
                    keyValue = keypressed.KeyChar;
                    Console.WriteLine(keyValue);
                    break;
                }
            }
            List<string> commandList = new List<string>();
            if (keyValue.ToString().ToUpper() == "Y" )
            {
                Console.Write(MessageText.InputFilenamePrompt);
                string fielname = Console.ReadLine();
                if (File.Exists(fielname) && (Path.GetExtension(fielname) == ".txt"))
                {
                    commandList = File.ReadAllLines(fielname).ToList();
                }
                else
                {
                    Console.WriteLine(MessageText.InvailidTextFile);
                    Console.Write(MessageText.TheCorrectCommandText);
                    Console.WriteLine(MessageText.PressAnykey);
                    Console.ReadKey(true);
                    return;
                }
            }
            else if (keyValue.ToString().ToUpper() == "N")
            {
                Console.Write(MessageText.InputCommandSeqPrompt);
                string inputCommand = "";
                do
                {
                    inputCommand = Console.ReadLine();
                    commandList.Add(inputCommand);
                }
                while (inputCommand.ToUpper() != "REPORT");
            }
            string[] commands = commandList.ToArray();
            RobotProgram robotProgram = new RobotProgram();
            Console.WriteLine(robotProgram.ExecuteCommand(commands));
            Console.WriteLine(MessageText.PressAnykey);
            Console.ReadKey(true);

        }
        public string ExecuteCommand(string[] commands)
        {
            string _message = "";
            RoboCommand roboCommand = new RoboCommand();
            if (roboCommand != null)
            {
                _message = roboCommand.ProcessNow(commands);
            }
            return _message;
        }
    }
}
