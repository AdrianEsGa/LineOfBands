using System;
using System.Collections.Generic;
using OPCAutomation;

namespace LineOfBands.Opc
{
    public static class OpcManager
    {
        public static List<string> GetOpcServers()
        {
            var opcServerNames = new List<string>();
            var opcServers = new OPCServer().GetOPCServers();
            var servers = ((Array)(opcServers));

            for (var i = 1; i <= servers.Length; i++)
            {
                opcServerNames.Add((string)servers.GetValue(i));
            }

            return opcServerNames;
        }
    }
}
