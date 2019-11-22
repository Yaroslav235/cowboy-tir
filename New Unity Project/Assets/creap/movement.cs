
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float Ver, Hor;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ver = Input.GetAxis("Vertical") * Time.deltaTime;
        Hor = Input.GetAxis("Horizontal") * Time.deltaTime;
        transform.Translate(new Vector3(Hor, 0, Ver));
    }
}
