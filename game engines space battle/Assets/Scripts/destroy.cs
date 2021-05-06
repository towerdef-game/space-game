using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public float health;
  
  
    void OnTriggerEnter(Collider other)
    {
       if(other.tag == "bullet")
        {
            health--;
        } 
       if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
