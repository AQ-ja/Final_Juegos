using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCont : MonoBehaviour
{
    public int score;
    public Text scoredis;

    private void Update()
    {
        scoredis.text = score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            score++;
            Debug.Log(score);
        }
    }
}
