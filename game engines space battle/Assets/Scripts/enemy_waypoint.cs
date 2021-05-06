using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy_waypoint : MonoBehaviour
{


   //Patrol
    public Transform[] points;
    private int destPoint = 0;
  
    public float speed;
    public float turning;
    public destroy_door door;
   // public float threshold;
  
    public GameObject destination;
    public GameObject destination2;
    public float arrive;
    public TrailRenderer engine;
  
    public Animator turrets;
    public float delay;
    //ai sight

    
  

    void Start()
    {
        destPoint = (destPoint ) % points.Length;
        StartCoroutine(Deploying());
    }

    IEnumerator Deploying()
    {
        yield return new WaitForSeconds(delay);
        turrets.enabled = true;
    }

    void Update()
    {
       
        transform.position = Vector3.MoveTowards(transform.position, points[destPoint].transform.position, speed * Time.deltaTime);
      

        if (Vector3.Distance(points[destPoint].transform.position, transform.position) < arrive)
        {
            destPoint++;
        }
        if(destPoint >= 3)
        {
            Quaternion rotterget = Quaternion.LookRotation(destination2.transform.position + this.transform.position);
            this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, rotterget, turning * Time.deltaTime);
            door.candestroy = true;
        }
        else
            if(destPoint<= 3)
        {
            Quaternion rotterget = Quaternion.LookRotation(destination.transform.position + this.transform.position);
            this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, rotterget, turning * Time.deltaTime);
        }
        if (destPoint >= 5)
        {
            engine.enabled = true;
        }
    }

   
   

  
   
}


