using UnityEngine;

using Game.Enums;

namespace Game.ScriptableObjectsDeclarations 
{
    [CreateAssetMenu(fileName = "GameplayConfigs", menuName = "ScriptableObjects/GameplayConfigs", order = 1)]
    public class StartingGameplayConfigs : ScriptableObject
    {
        public GameStates gameStates;
    }
}