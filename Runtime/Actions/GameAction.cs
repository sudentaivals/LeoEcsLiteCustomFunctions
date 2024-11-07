using UnityEngine;

namespace LeoEcsLiteCustomFunctions.Actions
{
    public class GameAction : ScriptableObject
    {
        public virtual void Action(int senderEntity, int? takerEntity, ConditionAndActionArgs conditionAndActionArgs = null)
        {

        }
    }
}
