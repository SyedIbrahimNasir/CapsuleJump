using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectCoin : MonoBehaviour
{
    public int points = 0;
    public TextMeshProUGUI scoreText;

    public void UpdateScore ()
    { 
    scoreText.SetText("Score: " + points);
    }
    
}
