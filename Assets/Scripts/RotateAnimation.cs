﻿using UnityEngine;
using System.Collections;

public class RotateAnimation : MonoBehaviour 
{
	
	// Update is called once per frame
	void Update () 
	{
		// Multiply by Time.deltaTime to make the animation smooth.
		transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}
}
