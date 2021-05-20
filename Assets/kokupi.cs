using UnityEngine;
using System.Collections;

public class kokupi : MonoBehaviour {
	public GameObject NanoKontrol;
	new Rigidbody rigidbody;
	public Vector3 move;
	public Vector3 rotation;
	public Vector3 drotation;
	public float a;
	public float b;
	public float c;
	public float d;
	public float e;
	public float f;
	public float g;
	public float h;
	public float i;

	NanoKontrol2 midi;

	void Start () {
		NanoKontrol=GameObject.Find("NanoKontrol2");
		midi=NanoKontrol.GetComponent<NanoKontrol2>();//NanoKontrol2で得た値を取得
		GameObject hontai= GameObject.Find("Cube");
		rigidbody = hontai.GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//NanoKontrol2 midi=NanoKontrol.GetComponent<NanoKontrol2>();//NanoKontrol2で得た値を取得
		Vector3 tmp=GameObject.Find("Cube").transform.position;
		Vector3 kaku = GameObject.Find ("Cube").transform.localEulerAngles;
		a = -midi.knob1;
		b = a * 1.4f+90;
		c = midi.Slider1;
		d = c * 3.937f;
		e = d * Mathf.Tan (-61);

		rotation.x = b;
		//drotation.x = d;
	
		f = midi.Slider2 * 0.110236f;
		g = f - 2.0f;
		h = midi.knob2*1.42f-151;

		//rigidbody.drotation = transform.position (drotation.x, drotation.y, 10);
		move.x=e;
		move.y = g;
		move.z = d;
		rigidbody.position = move;
		rigidbody.rotation = Quaternion.Euler(rotation.x,h, 0);
		//GameObject.Find ("Cube").transform.position = new Vector3 (,g,tmp.z)


	}
}
