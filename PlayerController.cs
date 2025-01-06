using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of movement

    void Update()
    {
        // Optional: This handles keyboard input for testing.
        HandleKeyboardInput();
    }

    // Function to move the player up
    public void MoveUp()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
    }

    // Function to move the player down
    public void MoveDown()
    {
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
    }

    // Function to move the player right
    public void MoveRight()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }

    // Function to move the player left
    public void MoveLeft()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }

    // Optional: Handle keyboard input for testing
    private void HandleKeyboardInput()
    {
        if (Input.GetKey(KeyCode.W))
            MoveUp();
        if (Input.GetKey(KeyCode.S))
            MoveDown();
        if (Input.GetKey(KeyCode.D))
            MoveRight();
        if (Input.GetKey(KeyCode.A))
            MoveLeft();
    }
}
