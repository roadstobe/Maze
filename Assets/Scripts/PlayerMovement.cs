using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody _rigidbody;
    public float _sideForse;
    

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            _rigidbody.AddForce(Vector3.left * _sideForse * Time.deltaTime, ForceMode.VelocityChange);
        }else if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            _rigidbody.AddForce(Vector3.right * _sideForse * Time.deltaTime, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            _rigidbody.AddForce(Vector3.forward * _sideForse * Time.deltaTime, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            _rigidbody.AddForce(Vector3.back * _sideForse * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (_rigidbody.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        


    }
}
