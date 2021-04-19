using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour

    {
    public float speed;




    void Update()
    {
        transform.position += (transform.forward * Time.deltaTime * speed);
    }

    void OnCollisionEnter(Collision other)
    {


        if (other.gameObject.tag == "enemy")
        {
            //  other.gameObject.GetComponent<Rigidbody>

            Destroy(this.gameObject);
            Debug.Log("hit");
        }
        if (other.gameObject)
        {

            Destroy(this.gameObject);

        }


        if (speed == 0)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Debug.Log("hit");
        }
    }
}

