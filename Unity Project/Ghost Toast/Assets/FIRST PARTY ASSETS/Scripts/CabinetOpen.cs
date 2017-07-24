using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinetOpen : MonoBehaviour 
{
	public float openAngle;
	private bool open;
	public int door = 0;
	// Use this for initialization
	void Start () 
	{
		
	}
	// 105 255
	// Update is called once per frame
	void Update () 
	{
		if (door == 1) 
		{
			open = true;
		}
		if (door == 2) 
		{
			open = false;
			door = 0;
		}

		var rotationVector = transform.rotation.eulerAngles;
//		if (open == true) 
//		{
//			Quaternion.identity = startPosition - Quaternion.identity- 
//		}
		if (open == true) 
		{
			rotationVector.y = openAngle;
			transform.rotation = Quaternion.Euler (rotationVector);
		}
		if (open == false) 
		{
			rotationVector.y = 180;
			transform.rotation = Quaternion.Euler (rotationVector);
		}
	}
}
