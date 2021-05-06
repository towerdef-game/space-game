using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyalarm : MonoBehaviour
{
    public AudioSource alarm;
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            alarm.Stop();
        }
    }
}
