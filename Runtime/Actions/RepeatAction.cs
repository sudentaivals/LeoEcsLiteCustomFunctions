using UnityEngine;

namespace LeoEcsLiteCustomFunctions.Actions
{
    [CreateAssetMenu(menuName = "My Assets/Actions/Create repeat game action")]
    public class RepeatAction : GameAction
    {
        [SerializeField] int _repeatCount;
        [SerializeField] GameAction _action;

        public override void Action(int senderEntity, int? takerEntity, ConditionAndActionArgs conditionAndActionArgs = null)
        {
            for (int i = 0; i < _repeatCount; i++)
            {
                _action.Action(senderEntity, takerEntity, conditionAndActionArgs);
            }
        }
    }
}
