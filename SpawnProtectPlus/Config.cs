using Exiled.API.Features;
using Exiled.API.Features.Roles;
using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpawnProtectPlus
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
    }
    public class Plugin : Plugin<Config>
    {
        public override string Name => "SpawnProtectPlus";

        /// <inheritdoc>
        public override string Prefix => "SProtect+";

        /// <inheritdoc>
        public override string Author => "ShirakamiAme";

        /// <inheritdoc>
        public override Version Version => new Version(0,0,1);
        private EventHandlers eventHandlers;
        public override void OnEnabled()
        {
            eventHandlers = new EventHandlers();
            Exiled.Events.Handlers.Player.Hurting += eventHandlers.OnHurting;//Subscribe Player's HurtingEvents.订阅玩家受伤的事件
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            base.OnDisabled();
        }

    }
}
