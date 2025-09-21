using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int scoring;
    public ScoreManager ScoreManager;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            ScoreManager.AddScore(scoring);
            other.GetComponent<direction>().resetpos();
        }
    }
}
