using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI score;
    private int scoreAmount = 0;

    void Start()
    {
        scoreAmount=0;
        score=GetComponent<TextMeshProUGUI>();
        // Button button = GetComponent<Button>();
        // button.onClick.AddListener(IncrementScore);
    }

    private void Update(){
        score.text=scoreAmount.ToString();
    }

    public void IncrementScore()
    {
        scoreAmount++;
    }

    public void ResetScore(){
        scoreAmount=0;
    }
}
