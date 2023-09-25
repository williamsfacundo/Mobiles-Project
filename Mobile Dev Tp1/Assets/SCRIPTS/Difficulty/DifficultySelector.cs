using UnityEngine;

public class DifficultySelector : MonoBehaviour
{
    [SerializeField] private DifficultyEnum buttonDifficulty;

    public DifficultyEnum Difficulty
    {
        get 
        {
            return buttonDifficulty;
        }
    }
}