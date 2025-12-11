using UnityEngine;

public class IconRotate : MonoBehaviour
{
    public Transform player; // Assign the Participant here

    void Update()
    {
        // Get movement input from PlayerController
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(moveX, 0, moveZ);

        if (move != Vector3.zero)
        {
            // Rotate icon to face movement direction
            transform.forward = move.normalized;
        }
        else
        {
            // Keep facing forward if no input
            transform.forward = Vector3.forward;
        }

        // Optional: keep icon above player
        if (player != null)
        {
            transform.position = player.position + new Vector3(0, 0.5f, 0);
        }
    }
}
