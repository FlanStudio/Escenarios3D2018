using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tp : MonoBehaviour {
    public GameObject player;
    
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            player.transform.position =new Vector3( 302,130,284);
        }
       
    }

}
