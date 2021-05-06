using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerachange : MonoBehaviour
{
    public GameObject lastscene;
    public GameObject newscene;
    public GameObject hallway;
    public bool getridofscene;
    public bool destroy;
   // public GameObject scene3;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            lastscene.SetActive(false);
            newscene.SetActive(true);
            if(getridofscene == true)
            {
                hallway.SetActive(false);
            }
            if(destroy == true)
            {
                Destroy(hallway);
            }
            Destroy(gameObject);
        }
    }
}
