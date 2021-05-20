using UnityEngine;
using System.Collections;

public class kesu : MonoBehaviour {
	public GameObject objkokupi;
	public GameObject NanoKontrol;

	NanoKontrol2 midi;

	// Use this for initialization
	void Start () {
		objkokupi = GameObject.Find ("untitled");
		NanoKontrol=GameObject.Find("NanoKontrol2");
		midi=NanoKontrol.GetComponent<NanoKontrol2>();

	
	}
	//public static void Showball(){
		
		// Update is called once per frame
	void Update () {
		if (midi.Slider8 < 3) {
			
			objkokupi.SetActive (true);
		}
		if (midi.Slider8 > 123) {
			objkokupi.SetActive (false);
		}

		//objkokupi = GameObject.Find ("untitled");


	
	}
}
