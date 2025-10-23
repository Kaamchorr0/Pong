using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using Unity.VisualScripting.FullSerializer;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText1;
    public TextMeshProUGUI scoreText2;
    public TextMeshProUGUI winText;
    public GameObject WinPanel;
    int p1score = 0;
    int p2score = 0;
    private int Index;
    
    void Awake()
    {
        Index = SceneManager.GetActiveScene().buildIndex;
    }

    void Start()
    {
        
        WinPanel.SetActive(false);
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
        winner();
    }
    void winner()
    {
        if (p1score == 10)
        {
            winscreen(1);
        }
        else if(p2score== 10)
        {
            winscreen(2);
        }
    }
    void winscreen(int pnumber)
    {
        if (Index == 3)
        {
            WinPanel.SetActive(true);
            winText.text = "Player " + pnumber + "Wins!";
        }
        else
        {
            if (pnumber == 1)
            {
                WinPanel.SetActive(true);
                winText.text = "Computer Won!";
            }
            else
            {
                WinPanel.SetActive(true);
                winText.text = "You Won!";
            }
        }
    }
}
