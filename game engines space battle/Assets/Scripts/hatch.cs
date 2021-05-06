using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hatch : MonoBehaviour
{
    // Start is called before the first frame update
    public enemy_waypoint ship;
  //  public AIController drone;
    public Animator tachi;
    void Start()
    {
        
    }

  public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("enter");
            ship.enabled = true;
         //   drone.targetObj = ship.gameObject;
       //     tachi.enabled = true;
            Destroy(other.gameObject);

        }
    }
}
