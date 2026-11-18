using UnityEngine;
using TMPro;


public class ScorePosition : MonoBehaviour
{
    [SerializeField] private Transform transformePlayer;
    [SerializeField] private TextMeshProUGUI scoreText;

 
    void Update()
    {
        scoreText.text = "Bonjour";
    }
}
