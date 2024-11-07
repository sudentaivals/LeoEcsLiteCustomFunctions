using UnityEngine;

namespace LeoEcsLiteCustomFunctions.Conditions
{
    public class BaseGameCondition : ScriptableObject
    {
        public virtual bool CheckCondition(int senderEntity, int? takerEntity, ConditionAndActionArgs conditionArgs = null)
        {
            return true;
        }
    }
}

