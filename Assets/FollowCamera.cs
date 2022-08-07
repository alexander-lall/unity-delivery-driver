using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    [SerializeField] float offset = 2;

    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0, offset, -1);
    }
}
