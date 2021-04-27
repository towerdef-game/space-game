using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public float health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
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
