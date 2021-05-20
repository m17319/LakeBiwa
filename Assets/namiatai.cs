using UnityEngine;
using System.Collections;

public class namiatai : MonoBehaviour {
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
		r = midi.Slider8;

		if (a >= 63) {
			j = a - 63;
			k = j * 0.02f;
			l = 0.14f - k;//波の高さx
		}
		if (a < 63) {
			j = a - 62;
			k = b * 0.02f;
			l = 0.14f + k;//波の高さx
		}
		if (b >= 63) {
			j = b - 63;
			k = j * 0.02f;
			m = 0.76f - k;
		}
		if (b < 63) {
			j = e - 62;
			k = b * 0.02f;
			m = 0.76f + k;
		}
		if (c >= 63) {
			j = c - 63;
			k = j * 0.02f;
			n = 0.18f - k;
		}
		if (c < 63) {
			j = c - 62;
			k = j * 0.02f;
			n = 0.18f + k;
		}
		if (d >= 63) {
			j = d - 63;
			k = j * 0.02f;
			o = 0.23f - k;
		}
		if (d < 63) {
			j = d - 62;
			k = j * 0.02f;
			o = 0.23f + k;
		}
		material.SetVector ("_GAmplitude", new Vector4 (l,m,n,o));//波の高さ
		if (e >= 63) {
			j = d - 63;
			k = j * 0.02f;
			l = 1.44f - k;
		}
		if (e < 63) {
			j = d - 63;
			k = j * 0.02f;
			l = 1.44f + k;
		}
		if (f >= 63) {
			j = d - 63;
			k = j * 0.02f;
			m = 0.24285f - k;
		}
		if (f < 63) {
			j = d - 63;
			k = j * 0.02f;
			m = 0.24285f + k;
		}
		if (g >= 63) {
			j = d - 63;
			k = j * 0.02f;
			n = 1.853064f - k;
		}
		if (g < 63) {
			j = d - 63;
			k = j * 0.02f;
			n = 1.853064f + k;
		}
		material.SetVector("_DistortParams",new Vector4 (l,m,n,-0.5314f));//波の歪み
		if (h >= 63) {
			j = d - 63;
			k = j * 0.02f;
			l = 0.5f - k;
		}
		if (h < 63) {
			j = d - 63;
			k = j *0.02f;
			l = 0.5f + k;
		}
		if (i >= 63) {
			j = d - 63;
			k = j * 0.02f;
			m = 0.38f - k;
		}
		if (i < 63) {
			j = d - 63;
			k = j * 0.02f;
			m = 0.38f + k;
		}
		if (r >= 63) {
			j = d - 63;
			k = j * 0.02f;
			n = 0.59f - k;
		}
		if (r < 63) {
			j = d - 63;
			k = j * 0.02f;
			n = 0.59f + k;
		}
		material.SetVector("_GFrequency",new Vector4(l,m,n,0.6f));//波の間隔
	}
}
