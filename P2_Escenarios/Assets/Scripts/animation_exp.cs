using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_exp : MonoBehaviour {

	public Animator anim;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter(Collider player_col)
	{
		if(player_col.gameObject.tag == "Player")
        {
			anim.Play ("explosion");
        }
	}

}
