using UnityEngine;
using System.Collections;

public class CloseButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag.Equals("Pointer"))
			{				
				this.transform.parent.parent.gameObject.SetActive (false);
			}
	}
}
