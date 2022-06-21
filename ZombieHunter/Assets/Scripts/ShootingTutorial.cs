using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingTutorial : MonoBehaviour
{
    public float damage = 10f;
    public float range = 10f;

    public Camera aimCam;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    // Update is called once per frame
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(aimCam.transform.position, aimCam.transform.forward, out hit, range)){
            Debug.Log(hit.transform.name);
        }
    }
}
