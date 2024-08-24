using CustomPlayerEffects;
using Exiled.API.Enums;
using Exiled.API.Extensions;
using Exiled.Events.EventArgs.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpawnProtectPlus
{
    internal class EventHandlers
    {
        public void OnHurting(HurtingEventArgs ev)
        {
            foreach (StatusEffectBase statusEffectBase in ev.Player.ActiveEffects)//Traversal player's ActiveEffects.遍历玩家的已激活效果
            {
                if (statusEffectBase.GetEffectType() == EffectType.SpawnProtected)//If player is SpawnProtected.如果玩家有出生保护
                {
                    ev.IsAllowed = false;//Then Nullify the damage.直接把伤害无效
                }
            }
        }
    }
}
