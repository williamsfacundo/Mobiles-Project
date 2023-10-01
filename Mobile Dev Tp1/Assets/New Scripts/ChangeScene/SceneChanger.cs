using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    static public void ChangeToMainMenu() 
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    static public void ChangeToGameplay() 
    {
        SceneManager.LoadScene("Gameplay");
    }

    static public void ChangeToEndGame() 
    {
        SceneManager.LoadScene("EndGame");
    }

    static public void ChangeToCredits()
    {
        SceneManager.LoadScene("Credits");
    }
}