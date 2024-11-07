using System.Collections.Generic;
using LeoEcsLiteCustomFunctions.Conditions;
using UnityEngine;

namespace LeoEcsLiteCustomFunctions.Actions
{
    [CreateAssetMenu(menuName = "My Assets/Actions/Create action package")]
    public class ActionPackage : GameAction
    {
        [SerializeField] List<GameAction> _actions;

        public override void Action(int senderEntity, int? takerEntity, ConditionAndActionArgs conditionAndActionArgs = null)
        {
            if(_actions == null) return;
            foreach (var gameAction in _actions)
            {
                gameAction.Action(senderEntity, takerEntity, conditionAndActionArgs);
            }
        }
    }
}
