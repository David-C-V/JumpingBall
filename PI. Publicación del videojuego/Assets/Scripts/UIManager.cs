using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Text currentScoreText;
    public Text bestScoreText;

    private void Update()
    {
        currentScoreText.text = "Score:" + GameManager.singleton.currentScore;

        bestScoreText.text = "Best:" + GameManager.singleton.bestScore;
    }


}
