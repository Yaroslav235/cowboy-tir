using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollIgmore : MonoBehaviour
{

    public List<Collider> cols = new List<Collider>();
    // Start is called before the first frame update
    void Start()
    {
        foreach(Collider collider in cols)
        {
            Physics.IgnoreCollision(collider, GetComponent<Collider>());
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
