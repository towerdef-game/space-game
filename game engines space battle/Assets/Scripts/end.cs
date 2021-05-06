using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    IEnumerator endgame()
    {
        yield return new WaitForSeconds(5);
        Application.Quit();
        Debug.Log("quit");
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("quitting");
            StartCoroutine(endgame());
           
        }
    }
}
