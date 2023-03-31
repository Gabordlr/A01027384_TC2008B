using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI scoreText;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    public void addPoints(int value)
    {
        score += value;
        scoreText.text = "Score: " + score;
        Debug.Log("Score: " + score);
    }
}
