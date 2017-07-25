using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour 
{
	
	public GameObject grab;
	public GameObject cursorSmall;
	public GameObject cursorBig;

	private bool handsFull = false;
	private bool canPickUp = false;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		/// Raycast
		RaycastHit hit = new RaycastHit ();
		// Is there a thing in front of my face
		Vector3 fwd = transform.TransformDirection (Vector3.forward) *5;
		Debug.DrawRay (transform.position, fwd, Color.green);

		if (Physics.Raycast (transform.position, fwd, 5)) 
		{
			print ("There is something in front of the object");
		}

		// Finds the object you are looking at and stores it, clears it if you arn't looking at anything
		// Also keeps track of if you can pick something up
		if (Physics.Raycast (transform.position, fwd, out hit, 5)) 
		{
			grab = hit.collider.gameObject;
			canPickUp = true;
		} else 
		{
			grab = null;
			canPickUp = false;
		}

		ReticleResize ();

		if (handsFull == false) 
		{
		// Finds if the player is looking at a pick up or a door
			if (Input.GetKeyDown (KeyCode.Mouse0)) 
			{
				if (grab.tag == "PickUp") 
				{
					grab.GetComponent<PickUp> ().held = true;
					grab.GetComponent<Rigidbody> ().useGravity = false;
					handsFull = true;
				} else if (grab.tag == "Door") 
				{
					grab.GetComponent<CabinetOpen> ().door++;
				}
					
			}
		} else if (handsFull == true) 
		{
			if (Input.GetKeyDown (KeyCode.Mouse0)) 
			{
				grab.GetComponent<PickUp> ().held = false;
				grab.GetComponent<Rigidbody> ().useGravity = true;
				handsFull = false;
			}
		}
	}

	void ReticleResize ()
	{
		if (grab.tag == "PickUp" || grab.tag == "Door") {
			cursorBig.SetActive (true);
			cursorSmall.SetActive (false);
		} else
		{
			cursorBig.SetActive (false);
			cursorSmall.SetActive (true);
		}
	}
}
