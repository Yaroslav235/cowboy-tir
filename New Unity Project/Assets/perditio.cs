using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perditio : MonoBehaviour
{
	
	public GameObject ObgectOld;
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
			
			ObgectOld.SetActive(false);
			
		}

    }
	void OnCollisionEnter(Collision col)
	{
		if(col.collider.tag == "Destroy")
		{
			Health -= 1;
		}
	}
}
