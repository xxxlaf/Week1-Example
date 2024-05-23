using UnityEngine;

public class TriggerExample : MonoBehaviour
{
    [SerializeField]
    [Header("Int Example")]
    private int scoreAmount;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (AudioManager.instance != null)
            {
                //AudioManager.instance.PlayAudio();
                GameManager.instance.ChangeScore(scoreAmount);
                Destroy(this.gameObject);
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + " Exited Trigger");
    }

    public void OnCollisionEnter(Collision other)
    {
        
    }

    public void OnCollisionExit(Collision other)
    {
        Debug.Log("No Longer Colliding With Object");
    }
}