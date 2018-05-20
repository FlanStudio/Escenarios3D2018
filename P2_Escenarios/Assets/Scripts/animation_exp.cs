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

	void OnCollisionEnter(Collision player_col)
	{
		if(player_col.gameObject.CompareTag("Player"))
        {
            anim.Play("explosion");
        }
	}

}
