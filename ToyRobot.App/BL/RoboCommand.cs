using System;
using System.Text.RegularExpressions;
using ToyRobot.App.BL;
using ToyRobot.App.Utilities;

namespace ToyRobot.App.Entities
{
    public class RoboCommand
    {
        public Table Table = new Table(5, 5);//hard coded this since the instruction says it is always 5x5
        public MovementSimulator movementSimulation;
        
        public bool IsOnTableTop;
        public string _message = string.Empty;
        public string _invalidInputText = MessageText.InvalidInputs;

        public string ProcessNow(string[] commands)
        {
            movementSimulation = new MovementSimulator(Table);
            foreach (string command in commands)
            {
                _message = _invalidInputText;
                if (IsOnTableTop)
                {
                    _message = "";
                    ProcessCommand(command);
                }
                else if (Regex.IsMatch(command, "PLACE"))
                {
                    IsOnTableTop = true;
                    _message = "";
                    ProcessCommand(command);
                }

                //BREAK WHEN ENCOUNTER ERROR
                if (_message == _invalidInputText)
                {
                    break;
                }

                if (_message.Length > 1)
                {
                    Console.WriteLine(_message);
                    _message = "";
                }
            }
            return _message;
        }

        public void ProcessCommand(string command)
        {
            //PARSING COMMAND STRING AND EXECURE THE RIGHT FUNCTION FOR THE COMMAND
            /*NOTE 
                I ADDED TO UPPER CONDITION FOR THE COMMAND SO THAT IF THE USER INPUTS LOWER CASE OR COMBINATION OF LOWER AND UPPER, 
                THE CODE WILL STILL ACCEPT IT AS VALID INPUT*/
            if (Regex.IsMatch(command.ToUpper(), "^PLACE"))
            {
                string[] locationCoordinates = command.Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
                if (locationCoordinates.Length == 4)
                {
                    int east;
                    int north;
                    bool eastTest = Int32.TryParse(locationCoordinates[1], out east);
                    bool northTest = Int32.TryParse(locationCoordinates[2], out north);
                    if (eastTest && northTest)
                    {
                        movementSimulation.Place(east, north, locationCoordinates[3]);
                    }
                }
                if (movementSimulation.robot == null)
                {
                    _message = _invalidInputText;
                }
            }
            else if (Regex.IsMatch(command.ToUpper(), "^MOVE") || Regex.IsMatch(command.ToUpper(), "^RIGHT") || Regex.IsMatch(command.ToUpper(), "^LEFT"))
            {
                movementSimulation.Move(command.ToLower());
            }
            else if (Regex.IsMatch(command.ToUpper(), "^REPORT"))
            {
                _message = movementSimulation.Report();
            }
            else
            {
                _message = _invalidInputText;
            }
        }
    }
}
