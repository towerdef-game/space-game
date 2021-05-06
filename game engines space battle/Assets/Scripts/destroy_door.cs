using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_door : MonoBehaviour
{
    public float health;
    public bool candestroy;
    void OnTriggerEnter(Collider other)
    {
        if (candestroy == true)
        {
            if (other.tag == "bullet")
            {
                health--;
            }
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
    public void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
