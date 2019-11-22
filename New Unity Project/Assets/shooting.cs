using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour

{
    public GameObject Obgesctoid;
    public int Health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            Obgesctoid.SetActive(false);
            
        }
        /*
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 100f))
            {
                print(hit.collider.gameObject);
                Destroy(hit.collider.gameObject);
            }
                
        }
        */
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Destroy")
        {
            Health -= 10;
        }
    }

    //private void OnCollisionEnter(Collision collision)
    // {
    // Destroy(gameObject);
    // }
}
