using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class CharacterInteraction : MonoBehaviour 
//{
//	private GameObject pickUp;
//	public GameObject cupboard;
//	private bool handsFull = false;
//	private bool open;
//	// Use this for initialization
//	void Start () 
//	{
//		pickUp = GameObject.FindGameObjectWithTag ("PickUp");
//		cupboard = GameObject.FindGameObjectWithTag ("Cupboard Door");
//	}
//	
//	// Update is called once per frame
//	void Update () 
//	{
//
//	}
//
//	void OnTriggerStay(Collider other)
//	{
////		open = cupboard.GetComponent<CabinetOpen> ().open;
//		// Tells the object wether or not to be "picked up"
//		if (other.tag == "PickUp") 
//		{
//			if (handsFull == false) 
//			{
//				if (Input.GetKeyDown (KeyCode.Mouse0)) 
//				{
//					pickUp.GetComponent<PickUp> ().held = true;
//					pickUp.GetComponent<Rigidbody> ().useGravity = false;
//					handsFull = true;
//				}
//			} else if (handsFull == true) 
//			{
//				if (Input.GetKeyDown (KeyCode.Mouse0)) 
//				{
//					pickUp.GetComponent<PickUp> ().held = false;
//					pickUp.GetComponent<Rigidbody> ().useGravity = true;
//					handsFull = false;
//				}
//			}
//		}
//
//		if (other.tag == "Cupboard") 
//		{
//			Debug.Log ("1");
//			if (open == true) 
//			{
//				if (Input.GetKeyDown (KeyCode.Mouse0)) 
//				{
//					cupboard.GetComponent<CabinetOpen> ().open = false;
//				}
//			}
//			else if (open == false) 
//			{
//				if (Input.GetKeyDown (KeyCode.Mouse0)) 
//				{
//					cupboard.GetComponent<CabinetOpen> ().open = true;
//				}
//			}
//		}
//	}
//}
