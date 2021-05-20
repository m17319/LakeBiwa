using UnityEngine;
using System.Collections;

public class abc : MonoBehaviour {
	public  float a;
	public  float b;
	public  float c;
	public  float d;

	void Start () {
		RenderSettings.fog = true;	
		RenderSettings.fogMode = FogMode.Linear;
		RenderSettings.fogColor = Color.gray;
	}

	void Update ()
	{
		a = 50;
		b = 3000;



		if (Input.GetKey (KeyCode.Q)) 
		{
			c = c + 100;
		}
		if (Input.GetKey (KeyCode.W)) {
			d = d + 100;
		}
		if (Input.GetKey (KeyCode.A)) {
			c = c - 100;
		}
		if (Input.GetKey (KeyCode.S)) {
			d = d - 100;
		}
		RenderSettings.fogStartDistance = a+c;
		RenderSettings.fogEndDistance = b+d;	
	}
}

