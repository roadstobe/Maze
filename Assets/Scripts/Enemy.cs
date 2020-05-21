using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody _rigidbody;
    public float _forwardForse;
    public int lastPositionX;
    private bool hasRight = true;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        lastPositionX = (int)transform.position.x;
        //Debug.Log("start");
    }

    void FixedUpdate()
    {
        if (hasRight)
        {
            _rigidbody.AddForce(Vector3.right * _forwardForse * Time.deltaTime, ForceMode.VelocityChange);
        }else
        {
            _rigidbody.AddForce(Vector3.left * _forwardForse * Time.deltaTime, ForceMode.VelocityChange);
        }
       
        
    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Wall")
        {
            hasRight = !hasRight;

        }
        //else
        //{
        //    Debug.Log(collisionInfo.collider.tag);
        //}
    }
}
