using UnityEngine;
using UnityEngine.InputSystem;
using Vector2 = UnityEngine.Vector2;

public class CharacterController : MonoBehaviour
{    public void PlayerMovement(InputAction.CallbackContext context)
    {
        transform.Translate(context.ReadValue<Vector2>() * Time.deltaTime);
        Debug.Log(context.ReadValue<Vector2>().ToString());
    }
}
