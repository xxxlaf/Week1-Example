using UnityEngine;

public class TriggerExample : MonoBehaviour
{
    [Header("Int Example")]
    public int count;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log(other.name + " Entered Trigger");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + " Exited Trigger");
    }

    public void OnCollisionEnter(Collision other)
    {
        CountUp();
    }

    public void OnCollisionExit(Collision other)
    {
        Debug.Log("No Longer Colliding With Object");
    }

    public void CountUp()
    {
        count++;
    }
}