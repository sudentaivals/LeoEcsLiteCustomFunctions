using System;
using LeoEcsLiteCustomFunctions.Actions;
namespace  LeoEcsLiteCustomFunctions.EcsEventBus
{
    public class RegisterTimedActionEventArgs : EventArgs
    {
        public int? TakerEntity {get;set;}
        public GameAction Action {get;set;}
        public float Timer {get;set;}
        public ConditionAndActionArgs Args {get;set;}
    }

}

