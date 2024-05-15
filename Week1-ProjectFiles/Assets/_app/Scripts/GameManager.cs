using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    private int playerScore;

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

    public void IncreaseScore()
    {
        playerScore++;
    }
}
