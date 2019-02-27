using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{

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
        Invoke("Spawn", 0.1f);

    }
    void Spawn()
    {


        switch (openingDirection)
        {
            case 1:
                {
                    //need bottom door
                    rand = Random.Range(0, templates.bottomRooms.Length);
                    Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);

                    break;
                }

            case 2:
                {
                    //need top door
                    rand = Random.Range(0, templates.topRooms.Length);
                    Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);
                    break;
                }

            case 3:
                {
                    //need left door
                    rand = Random.Range(0, templates.leftRooms.Length);
                    Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation);
                    break;
                }

            case 4:
                {
                    //need top door
                    //need right door
                    rand = Random.Range(0, templates.rightRooms.Length);
                    Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation);
                    break;
                }
            default:
                break;
        }

         void OnTriggerEnter2D(Collider2D other) {
            if(other.CompareTag("SpawnPoint") && other.GetComponent<RoomSpawner>().spawned == true)
           {
              Destroy(gameObject);
           }
         }
    }
}
