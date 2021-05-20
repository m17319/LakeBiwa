using UnityEngine;
using System.Collections;


public class namiseigyo : MonoBehaviour {
	public Renderer nami;
	public GameObject NanoKontrol;
	public Shader nami2;

	private Material material;
	NanoKontrol2 midi;

	// Use this for initialization
	void Start () {
		NanoKontrol=GameObject.Find("NanoKontrol2");
		midi=NanoKontrol.GetComponent<NanoKontrol2>();
		nami = GetComponent<Renderer> ();
		//nami.material.shader = Shader.Find ("FX/Water4");//("FX/Water4")
		nami2 = GetComponent<Shader> ();

		//Shader.SetGlobalFloat("_GerstnerIntensity", 1);
	}
	
	// Update is called once per frame
	void Update () {
		//Shader.SetGlobalFloat("_GerstnerIntensity", 1.0f);
		
		nami.material.SetFloat ("_GerstnerIntensity", 1.0f);
		nami.material.SetVector("_GAmplitude", new Vector4(1,1,1,1));

	}
}
