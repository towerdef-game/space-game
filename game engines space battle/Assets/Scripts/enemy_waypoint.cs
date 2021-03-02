using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy_waypoint : MonoBehaviour
{

    public GameObject player;
   //Patrol
    public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;
    public float speed;
    public float turning;
    private float fly;
    public GameObject destination;
    public float arrive;
    //ai sight

    
  

    void Start()
    {
        
        Angle();

        destPoint = (destPoint + 1) % points.Length;
    }


   
    void Update()
    {
       
        transform.position = Vector3.MoveTowards(transform.position, points[destPoint].transform.position, speed * Time.deltaTime);
        Quaternion rotterget = Quaternion.LookRotation(destination.transform.position + this.transform.position);
        this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, rotterget, turning * Time.deltaTime);

        if (Vector3.Distance(points[destPoint].transform.position, transform.position) < arrive)
        {
            destPoint++;
        }

    }

   
    void Angle()
    {

     


        //  agent.destination = points[destPoint].position;
       
    }

  
   
}


