using UnityEngine;
using System.Collections;

public class kiri : MonoBehaviour {
	public GameObject NanoKontrol;

	NanoKontrol2 midi;

	// Use this for initialization
	void Start () {
		NanoKontrol=GameObject.Find("NanoKontrol2");
		midi=NanoKontrol.GetComponent<NanoKontrol2>();
		RenderSettings.fog = true;
		RenderSettings.fogEndDistance = 30000;
		RenderSettings.fogStartDistance = 50;
	
	}
	
	// Update is called once per frame
	void Update () {
		RenderSettings.fogEndDistance=30000-midi.Slider3*161;
		
	
	}
}
