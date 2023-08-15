using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerRenderer : MonoBehaviour
{
    [Header("Dependecies")]
    public SpriteRenderer spriteRenderer;

    public void OnMovement(InputAction.CallbackContext value)
    {
        Vector2 movementInput = value.ReadValue<Vector2>();
        if(movementInput.x > 0f && PlayerIsLookingLeft())
        {
            spriteRenderer.flipX = false;
        }
        else if (movementInput.x < 0f && !PlayerIsLookingLeft())
        {
            spriteRenderer.flipX = true;
        }
    }
    private bool PlayerIsLookingLeft()
    {
        return spriteRenderer.flipX;
    }
}
