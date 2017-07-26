using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressKeyToTrigger : MonoBehaviour {
	
	//This value is the distance of units the player needs to be before pressing "E" to interact.
	public float distanceToCheck = 2;

	//Game Object you would like to turn on.
	public GameObject objectToToggleOn;
	public GameObject soundToToggleOn;

	//Change the Key to Press in the inspector
	public KeyCode KeyToPress = KeyCode.E;

	//Place your player character within this gameobject
	public GameObject player;


	//Initially sets the object you'd like to turn on, off.
	void Start () 
	{
		objectToToggleOn.SetActive (false);
	}
	
	//Checking the distance between the player and this object to check if within range.
	void Update () 
	{
		CheckDistance ();
	}
		

	// If the distance between this gameobjects transform.position and the gameobject(Player) transform.position  is less then the distanceToCheck value
	// the player can do the following.
	// If "E" is pressed objectToToggleOn turns on, and this gameobject will turn off.
	void CheckDistance()
	{
		if(Vector3.Distance(transform.position, player.transform.position) < distanceToCheck)
		{
//			if (Input.GetKey (KeyToPress)) 
//			{
			objectToToggleOn.SetActive (true);
//			soundToToggleOn.SetActive (true);
			this.gameObject.SetActive (false);
//			}
		}
	}
}