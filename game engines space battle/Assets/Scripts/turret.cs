using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret : MonoBehaviour
{
    public float smoothing = 1f;
    public Transform target;
    public GameObject bullet;
    public Transform barrel;
    private Quaternion lookrotation;
    private Vector3 direction;
    public bool canaim = false;
    public float rateoffire;
    public bool canshoot;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Deploying());
    }
    IEnumerator Deploying()
    {
        yield return new WaitForSeconds(3f);
        canaim = true;
    }
    IEnumerator FireRate()
    {
        yield return new WaitForSeconds(rateoffire);
        canshoot = true;
    }
    // Update is called once per frame
    void Update()
    {
        direction = (target.position - transform.position).normalized;
        lookrotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookrotation, Time.deltaTime * smoothing);
        
        if(canshoot == true)
        {
            Instantiate(bullet, barrel.position, barrel.rotation);
            canshoot = false;
        }
    }
}
