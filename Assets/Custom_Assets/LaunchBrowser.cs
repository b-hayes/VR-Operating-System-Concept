using UnityEngine;
using System.Collections;

public class LaunchBrowser : MonoBehaviour {

	public GameObject toHide;
	public GameObject toShow;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		toHide.SetActive (false);
		toShow.SetActive (true);
	}
}
