using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;

public class CameraRendering : MonoBehaviour {

	private Camera playercam;
	// Use this for initialization
	void Start () 
	{
		playercam = this.gameObject.GetComponent<Camera>();
		float[] distances = new float[32];
		distances [8] = 1000;
		playercam.layerCullDistances = distances;
	}
}
