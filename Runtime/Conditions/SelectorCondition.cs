using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LeoEcsLiteCustomFunctions.Conditions
{
    [CreateAssetMenu(menuName = "My Assets/Conditions/Pack/Selector")]
    public sealed class SelectorCondition : BaseGameCondition
    {
        [SerializeField] private List<BaseGameCondition> _conditions;

        public sealed override bool CheckCondition(int senderEntity, int? takerEntity, ConditionAndActionArgs conditionArgs = null)
        {
            if(_conditions == null || _conditions.Count == 0) return true;

            foreach (var condition in _conditions)
            {
                if (condition.CheckCondition(senderEntity, takerEntity, conditionArgs)) return true;
            }

            return false;
        }
    }
}

