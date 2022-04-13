using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobot.App.Utilities
{
    public class MessageText
    {
        public const string OpenningMessage = "You may choose to proceed by specifying the text file path or by manually typing the series of commands.";
        public const string PromptMessage = "Would you like to process from text file? (Y/N)";
        public const string InvailidTextFile = "Not a valid text file. Please try again.";
        public const string TheCorrectCommandText = @"The correct command formats are as follows:
         ----------------------
         PLACE X,Y,DIRECTION  --- x and y should be 0-4 and direction should be NORTH, SOUTH, EAST or WEST 
         MOVE
         LEFT
         RIGHT
         REPORT -- This will terminate the simulation
         ---------------------
         Kindly check your file and try again.";
        public const string PressAnykey = "\n\rpress any key to exit.";
        public const string InputCommandSeqPrompt = "\n\rPlease input series of command \r\n";
        public const string InputFilenamePrompt = "Please enter filepath and filename: ";
        public const string InvalidInputs = "The inputs are not correct";
    }
}
