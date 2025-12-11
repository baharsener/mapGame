using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickToParent : MonoBehaviour
{
    void LateUpdate()
    {
        transform.localPosition = new Vector3(0, 1, 0);
    }
}