using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hatch : MonoBehaviour
{
    // Start is called before the first frame update
    public enemy_waypoint ship;
    public Animator tachi;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("enter");
            ship.enabled = true;
       //     tachi.enabled = true;
            Destroy(other.gameObject);

        }
    }
}
