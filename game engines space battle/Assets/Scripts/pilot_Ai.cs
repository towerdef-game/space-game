using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class pilot_Ai : MonoBehaviour
{
    public NavMeshAgent brain;
    public Transform Destination;
   

    // Start is called before the first frame update
    void Start()
    {
        brain = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        brain.destination = Destination.position;
    }
 
}
