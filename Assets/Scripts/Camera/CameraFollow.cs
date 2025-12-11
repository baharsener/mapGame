using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;           // this is where the 'Participant' goes
    public Vector3 offset = new Vector3(0, 20, 0);  // This fixes the height above the player
    // //but avoids rotating camera exactly the way the participant would rotate like in the perspective view.

    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.position + offset;
        }
    }
}

