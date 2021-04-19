using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target_move : MonoBehaviour
{
    public Transform[] points;
    private int destPoint ;
    public float speed;
   private float arrive = 1f;
    // Start is called before the first frame update
    void Start()
    {
        destPoint = (destPoint) % points.Length;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, points[destPoint].transform.position, speed * Time.deltaTime);
     
        if (Vector3.Distance(points[destPoint].transform.position, transform.position) < arrive)
        {
            destPoint++;
        }

        if(destPoint == points.Length)
        {
            destPoint = 0;
        }
    
    }
}
