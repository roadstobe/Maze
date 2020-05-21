using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform _playerTransform;
    public Vector3 offset;
    public Vector3 offsetRotation;

    void LateUpdate()
    {
        transform.position = _playerTransform.position + offset;
    }
}
