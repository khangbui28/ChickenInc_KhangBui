using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private int currentScore = 0;

    [SerializeField] TextMeshProUGUI score;


    private void OnEnable()
    {
        EventManager.OnAddPoints += HandleAddPoints;
    }

    private void OnDisable()
    {
        EventManager.OnAddPoints -= HandleAddPoints;
    }

    private void HandleAddPoints(int points)
    {
        currentScore += points;
        score.text = currentScore.ToString();
    }
}
