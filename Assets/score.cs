using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class score : MonoBehaviour {
    public Transform trans;
    public float a;
    public Text text;
    public float c;
	public GameObject Cube1;
	public GameObject NanoKontrol3;
	public float d;
	public float x;
	public float y;
	public float z;
	// Use this for initialization
	void Start () {

		Cube1 = GameObject.Find( "Cube" );//オブジェクトがどこにあるのか
		NanoKontrol3=GameObject.Find("NanoKontrol2");

    }
	
	// Update is called once per frame
	void Update () {
		
        Debug.Log(trans.localEulerAngles); //選択したオブジェクトの角度を取得
        Debug.Log(trans.position);//選択したオブジェクトの座標を取得


	
		NanoKontrol2 midi=NanoKontrol3.GetComponent<NanoKontrol2>();//NanoKontrol2で得た値を取得
		OSCController OSCC = Cube1.GetComponent<OSCController>();//OSCControllerで得た値を取得
        Vector4 po = trans.position;
        Vector3 b = trans.localEulerAngles;
        a = b.x;//bのxの座標をaに代入

        if (a < 90) a = -a;//もしaが90より小さかったら
        if (a > 90) a = 360 - a;//もしaが90より大きかったら
		d=(Mathf.Round(a));
        c = Mathf.Sqrt(Mathf.Pow(po.x, 2)+Mathf.Pow(po.z,2));//3平方の定理で距離を求める
		x=(Mathf.Round(c));
		y=(Mathf.Round(trans.position.y));
		text.text = "高さ" + y + "ピッチ" + d + "距離" + x + "速度";//+"スライダー"+midi.Slider1+"ノブ"+midi.knob1;//HUDに表示させるもの				             
    }
}
