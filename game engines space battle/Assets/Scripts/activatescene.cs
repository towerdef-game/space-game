using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activatescene : MonoBehaviour
{

    public GameObject hanger;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
         //   scene.SetActive(true);
            hanger.SetActive(true);
        }
    }

}
