using UnityEngine;
using System.Collections;

public class oyako : MonoBehaviour {
	public GameObject ko;

	void Start () {
		transform.parent = GameObject.Find ("OVRCameraRig").transform;
	}
	
	// Update is called once per frame
	void Update ()
	{
		ko = GameObject.Find ("DefaultCanvas");
		if (Input.GetKey (KeyCode.Z)) {
			ko.transform.parent = null;
			transform.parent = GameObject.Find ("Cube").transform;
			ko.transform.position = new Vector3 (0.0f, 1.1f, 0.0f);
		}
		if (Input.GetKey (KeyCode.X)) {
			transform.parent = GameObject.Find ("OVRCameraRig").transform;	
		}
	}
}
