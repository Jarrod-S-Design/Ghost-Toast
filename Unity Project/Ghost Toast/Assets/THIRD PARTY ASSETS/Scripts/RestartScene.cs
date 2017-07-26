using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartScene : MonoBehaviour {

	//Can change this within the inspector
	public KeyCode KeyToPress = KeyCode.R;

	// Use this for initialization
	void Start () {
		
	}

//If Key 'KeyToPress' is pressed, restarts the current scene.
	void Update () {
		if (Input.GetKeyDown (KeyToPress))
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
