using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacking : MonoBehaviour
{
    float fire1;
    float fire2;
    public float fireTime;
    public GameObject[] Bullet;

    void Update()
    {
        fire1 = Input.GetAxisRaw("Fire1");
        fire2 = Input.GetAxisRaw("Fire2");
    }
    void FixedUpdate()
    {
        if (fire1 == 1)
        {
            Instantiate()
        }
        if (fire1 == -1)
        {
            Debug.Log("down");
        }
        if (fire2 == 1)
        {
            Debug.Log("right");
        }
        if (fire2 == -1)
        {
            Debug.Log("left");
        }
    }
}
