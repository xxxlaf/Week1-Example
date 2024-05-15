using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [Header("Movement Variables")]
    public float movementSpeed;
    public Vector3 movementVector;
    public Vector3 jumpForce;
    public bool crouching;

    [Header("Player Components")]
    public Rigidbody rb;
    public Camera playerCamera;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerJump();
            GameManager.instance.IncreaseScore();
        }

        if (Input.GetKey(KeyCode.W))
        {
            movementVector.x = 1;
        }
        if (Input.GetKey(KeyCode.S)) {
            movementVector.x = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movementVector.z = 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movementVector.z = -1;
        }

        PlayerMovement();
    }

    private void PlayerJump()
    {
        rb.AddForce(jumpForce, ForceMode.Impulse);
    }

    private void PlayerMovement()
    {
        transform.Translate(new Vector3(movementVector.x, movementVector.y, movementVector.z) 
                            * (movementSpeed * Time.deltaTime));
    }
}
