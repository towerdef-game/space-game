using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play_effect : MonoBehaviour
{
    public GameObject effect;
    public AudioSource sound;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
      if(other.tag == "Player")
        {
            effect.SetActive(true);
            sound.Play();
            Debug.Log("explode");
        }  
    }
}
