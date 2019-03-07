using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {
    public float fireSpeed;
    public int Direction;

    private void Update()
    {
        if (Direction == 1)
        {
            transform.Translate(Vector2.up * fireSpeed * Time.deltaTime *25);
        }
        if (Direction == 2)
        {
            transform.Translate(Vector2.right * fireSpeed * Time.deltaTime * 25);
        }
        if (Direction == 3)
        {
            transform.Translate(Vector2.down * fireSpeed * Time.deltaTime *25);
        }
        if (Direction == 4)
        {
            transform.Translate(Vector2.left * fireSpeed * Time.deltaTime * 25);
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
