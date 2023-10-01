using UnityEngine;

public class LevelDifficulty : MonoBehaviour
{
    private const DifficultyEnum DefaultDifficulty = DifficultyEnum.NORMAL;

    private DifficultyEnum difficulty;
    
    public DifficultyEnum Difficulty
    {
        set
        { 
            difficulty = value; 
        }
        get 
        {
            return difficulty;
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        difficulty = DefaultDifficulty;
    }

    public void SetDifficultyEasy() 
    {
        difficulty = DifficultyEnum.EASY;        
    }

    public void SetDifficultyNormal()
    {
        difficulty = DifficultyEnum.NORMAL;        
    }

    public void SetDifficultyHard()
    {
        difficulty = DifficultyEnum.HARD;        
    }
}