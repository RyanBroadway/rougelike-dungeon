﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour {

    public int openingDirection;
    //1 = bottom door
    //2 = top door
    //3 = left door
    //4 = right door

    private RoomTemplates templates;
    private int rand;
    private bool spawned = false;

    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("Spawn", 0.1f);
    }
	void Spawn(){
        if (spawned == false) {
            if (openingDirection == 1)
            {
                //need bottom door
                rand = Random.Range(0, templates.bottomRooms.Length);
                Instantiate(templates.bottomRooms[rand], transform.position,Quaternion.identity);
            }
            else if (openingDirection == 2)
            {
                //need top door
                rand = Random.Range(0, templates.topRooms.Length);
                Instantiate(templates.topRooms[rand], transform.position,Quaternion.identity);
            }
            else if (openingDirection == 3)
            {
                //need left door
                rand = Random.Range(0, templates.leftRooms.Length);
                Instantiate(templates.leftRooms[rand], transform.position,Quaternion.identity);
            }
            else if (openingDirection == 4)
            {
                //need right door
                rand = Random.Range(0, templates.rightRooms.Length);
                Instantiate(templates.rightRooms[rand], transform.position,Quaternion.identity);
            }
            spawned = true;
        }
	}
    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("SpawnPoint") && other.GetComponent<RoomSpawner>().spawned == true)
        {
            Destroy(gameObject);
        }
    }
}
