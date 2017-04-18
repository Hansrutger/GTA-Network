using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTANetworkServer;
using GTANetworkShared;

namespace CEFResource
{
    public class CEFCommands : Script
    {
        public CEFCommands()
        {
            API.onClientEventTrigger += OnClientTriggered;
        }

        public void OnClientTriggered(Client player, string eventName, params object[] arguments)
        {
            switch (eventName)
            {
                case "BackToTheFuture":
                    API.sendNotificationToPlayer(player, "We're back where we started.");
                    break;
            }
        }

        [Command("test")]
        public void TestFunction(Client player)
        {
            API.triggerClientEvent(player, "testjs");
        }
    }
}
