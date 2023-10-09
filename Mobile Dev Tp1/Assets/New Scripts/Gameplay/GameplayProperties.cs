using UnityEngine;

using Game.Enums;

namespace Game.Gameplay
{
    public class GameplayProperties : MonoBehaviour
    {
        private GameStates gameState;
        
        public GameStates GameState 
        {
            set
            { 
                gameState = value; 
            }
            get 
            { 
                return gameState;
            }
        }
    }
}