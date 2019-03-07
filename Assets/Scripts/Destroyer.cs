using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "Player")
        {}
        else
        {
            if (other.gameObject.tag == "Bullet")
            { }
            else
            {
                Destroy(other.gameObject);
            }
        }
	}
    
}
