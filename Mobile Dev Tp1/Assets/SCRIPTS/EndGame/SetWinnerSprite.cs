using UnityEngine;
using UnityEngine.UI;

public class SetWinnerSprite : MonoBehaviour
{
    [SerializeField] private bool showWinner;

    [SerializeField] private Sprite[] _playersWinningSprites;

    [SerializeField] private Image _targetImage;

    [SerializeField] public bool ShowWinner;

    void Start()
    {
        if (showWinner) 
        {
            _targetImage.enabled = true;

            if (WinnerData.Winner == WinningEnum.PLAYER_ONE) 
            {
                _targetImage.sprite = _playersWinningSprites[0];
            }            
            else 
            {
                _targetImage.sprite = _playersWinningSprites[1];
            }
        }
        else
        {
            _targetImage.enabled = false;
        }
    }
}