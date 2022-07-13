using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float time = 2;

    private void Awake()
    {

        Destroy(gameObject, time);

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="player")
        {

            Destroy(gameObject);

        }


    }
}
