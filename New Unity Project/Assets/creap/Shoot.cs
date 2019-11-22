using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
   // public Transform bullet;
   // public GameObject point;
    public GameObject BulletPrefab;
    public Transform Transform;
    

    
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        //if (Input.GetButtonDown("Fire1") && timer > 1)
        
        
            
          
            if (gameObject.GetComponent<OVRGrabbable>().isGrabbed == true)
            {
                if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) == true)
                {
                    Instantiate(BulletPrefab, Transform.position, Transform.rotation).GetComponent<Rigidbody>().AddForce(transform.forward * 2000);
                    
                }
            }
        
    }
}
