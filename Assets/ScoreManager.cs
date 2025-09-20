using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText1;
    public TextMeshProUGUI scoreText2;
    int p1score = 0;
    int p2score = 0;

    void Start()
    {
        scoreText1.text = p1score.ToString();
        scoreText2.text = p2score.ToString();
    }

    public void AddScore(int number)
    {
        if (number == 1)
        {
            p1score++;
            scoreText1.text = p1score.ToString();
        }
        else if (number == 2)
        {
            p2score++;
            scoreText2.text = p2score.ToString();
        }
    }
}
