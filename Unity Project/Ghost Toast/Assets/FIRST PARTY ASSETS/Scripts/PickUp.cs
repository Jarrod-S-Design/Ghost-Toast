using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour 
{

	public Transform hands;
	public float speed;
	public bool held = true;

	// Update is called once per frame
	void Update () 
	{
		float step = speed * Time.deltaTime;
		if (held) 
		{
			transform.position = Vector3.MoveTowards (transform.position, hands.position, step);
		}
	}
}
