using UnityEngine;

public class ChangeToMainMenuWithTimer : MonoBehaviour
{
    [SerializeField] private float timeToChangeToMainMenu;

    private float _timer;
    
    void Start()
    {
        _timer = timeToChangeToMainMenu;
    }

    void Update()
    {
        if (_timer > 0.0f) 
        {
            _timer -= Time.deltaTime;

            if (_timer <= 0.0f) 
            {
                SceneChanger.ChangeToMainMenu();
            }
        }
    }
}