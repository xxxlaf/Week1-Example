using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TMP_Text scoreText;
    public int playerScore;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        } 
        else 
        {
            instance = this;
        }
    }

    public void ChangeScore(int scoreAmount)
    {
        playerScore += scoreAmount;
        scoreText.text = $"Player Score: { playerScore.ToString() }";
    }

    private void OnEnable()
    {
        DelegateManager.scoreEvent += OnScore;
        DelegateManager.deathEvent += OnDeath;
    }

    public void OnScore()
    {
        playerScore++;
        Debug.Log(playerScore);
    }

    public void OnDeath()
    {
        playerScore = 0;
        Debug.Log("Game over, score reset.");
    }
}
