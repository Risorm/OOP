using System;
using System.Collections.Generic;
using Multimedia_Shop.Interfaces;
using Multimedia_Shop.Models;


namespace Multimedia_Shop.CoreLogic
{
    class Engine
    {
        private Dictionary<IItem, int> supplies;
        public void Run()
        {
            while (true)
            {
                string command = Console.ReadLine();
                // TODO: Execute command
                
            }
        }

        private Dictionary<string, string> parseInput(string command)
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            string[] pairs = command.Split('&');

            foreach (var pair in pairs)
            {
                string[] keyValuePair = pair.Split('=');
                keyValuePairs[keyValuePair[0]] = keyValuePair[1];
            }
            return keyValuePairs;
        }
    }
}
