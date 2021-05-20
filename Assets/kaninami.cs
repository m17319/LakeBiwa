using UnityEngine;
using System.Collections;

public class kaninami : MonoBehaviour {
	public Material material;
	public GameObject NanoKontrol;
	NanoKontrol2 midi;
	public int a;
	public int b;
	public int c;
	public int d;
	public int e;
	public int f;
	public int g;
	public int h;
	public int i;
	public float j;
	public float k;
	public float l;
	public float m;
	public float n;
	public float o;
	public float p;
	public float q;
	public float r;
	public float s;
	public float t;

	void Start () {
		NanoKontrol=GameObject.Find("NanoKontrol2");
		midi=NanoKontrol.GetComponent<NanoKontrol2>();
	}

	void Update () {
		a = midi.knob4;
		b = midi.Slider4;
		c = midi.knob5;
		d = midi.Slider5;
		e = midi.knob6;
		f = midi.Slider6;
		g = midi.knob7;
		h = midi.Slider7;
		i = midi.knob8;
		s = midi.Slider8;
		j = a * 0.01574f;
		k = c * 0.110236f;
		l = d * 0.15748f-10;
		m = e * 0.01574f;
		n = f * 0.01574f;
		//o = f * 0.01f;//波の歪みy
		//p = g * 0.02f;//波の反射z
		q = b * 0.019685f;
		//r = i * 0.02f;//波の間隔y
		//t = s * 0.02f;//波の間隔z
		material.SetVector ("_GAmplitude", new Vector4 (j, 0, 0, 0));
		//material.SetVector("_DistortParams",new Vector4 (n,o,p,-0.5314f));
		material.SetVector("_GFrequency",new Vector4(q,0,0,0.6f));
		material.SetVector("_GSteepness",new Vector4(k,0,0,0));
		material.SetVector("_GSpeed",new Vector4(l,0,0,0));
		material.SetVector("_GDirectionAB",new Vector4(m,n,0,0));
	}
}
