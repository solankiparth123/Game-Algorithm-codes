using UnityEngine;

public class PlayerJump3D : MonoBehaviour
{
    public float jumpForce = 5f; // Strength of the jump
    private Rigidbody rb;        // Rigidbody reference
    private bool isGrounded = true; // Check if player is on the ground

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get the Rigidbody component
    }

    // Method to trigger the jump
    public void Jump()
    {
        if (isGrounded) // Only allow jumping when grounded
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // Apply jump force
            isGrounded = false; // Prevent multiple jumps
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the player touches the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
