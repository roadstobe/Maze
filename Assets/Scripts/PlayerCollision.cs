using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public Text KeysText;
    public PlayerMovement playerMovementComponent;
    Rigidbody _rigidbody;
    int keys;
    int needKeys;

    void Start()
    {
        needKeys = FindObjectOfType<GameManager>().needKeys;
        _rigidbody = GetComponent<Rigidbody>();
        KeysText.text = keys.ToString() + " / " + needKeys.ToString();
    }



    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Enemy")
        {
            playerMovementComponent.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    private void OnTriggerEnter(Collider colliderInfo)
    {
        if (colliderInfo.tag == "Key")
        {
            Destroy(colliderInfo.gameObject);
            keys++;
            KeysText.text = keys.ToString() + " / " + needKeys.ToString();
            if(keys == needKeys)
            {
                FindObjectOfType<GameManager>().FinishGame();
            }

        }
    }
}
