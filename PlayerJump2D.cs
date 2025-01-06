using UnityEngine;

public class PlayerJump2D : MonoBehaviour
{
    public float jumpForce = 5f; // Strength of the jump
    private Rigidbody2D rb;      // Rigidbody2D reference
    private bool isGrounded = true; // Check if player is on the ground

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component
    }

    // Method to trigger the jump
    public void Jump()
    {
        if (isGrounded) // Only allow jumping when grounded
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce); // Apply jump force
            isGrounded = false; // Prevent multiple jumps
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player touches the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
