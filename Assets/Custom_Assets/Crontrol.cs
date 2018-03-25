using UnityEngine;
using System.Collections;

public class Crontrol : MonoBehaviour {

	public GameObject AppsWindow;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("space")) {
			AppsWindow.SetActive (true);
		}
	}


}
