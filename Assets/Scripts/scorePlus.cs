using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scorePlus : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int scoreNum;

    public void UpdateScore()
    {
        scoreText.text =  "" + scoreNum++.ToString();
    }
}
