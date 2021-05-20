using UnityEngine;
using System.Collections;

public class midi1 : MonoBehaviour {
	//public  float a;
	//public  float b;
	//public  float c;
	//public  float d;
	//public GameObject midi2;//追加文
	public GameObject NanoKontrol3;

	void Start () {
		RenderSettings.fog = true;	
		RenderSettings.fogMode = FogMode.Linear;
		RenderSettings.fogColor = Color.gray;
		NanoKontrol3 = GameObject.Find( "NanoKontrol2" );//オブジェクトがどこにあるのか
	}

	void Update ()
	{
		NanoKontrol2 midi3 = NanoKontrol3.GetComponent<NanoKontrol2>();//OSCControllerで得た値を取得




		//if (Input.GetKey (KeyCode.Q)) 
		//{
		//	c = c + 100;
		//}
		//if (Input.GetKey (KeyCode.W)) {
		//	d = d + 100;
		//}
		//if (Input.GetKey (KeyCode.A)) {
		//	c = c - 100;
		//}
		//if (Input.GetKey (KeyCode.S)) {
	//		d = d - 100;
		//}
		RenderSettings.fogStartDistance = midi3.Slider3*(30000/128);
		RenderSettings.fogEndDistance = 30000;	
	}
}

