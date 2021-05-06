using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public float delay;
    public ParticleSystem explosioneffct;
    public GameObject scene1camera;
    public GameObject scene2camera;
   // public AudioClip bang;
    public AudioSource cam;
    public GameObject scene2;
    public GameObject scene1;
    public AudioSource alarm;
    // Start is called before the first frame update
  
    IEnumerator changecamera()
    {
        yield return new WaitForSeconds(delay);
        scene1camera.SetActive(false);
        scene2camera.SetActive(true);
        scene2.SetActive(true);
        scene1.SetActive(false);
        alarm.Play();
    }
    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "ship")
        {
            Debug.Log("ship");
            StartCoroutine(changecamera() );
            explosioneffct.Play();
            cam.Play();
        }
       
    }
}
