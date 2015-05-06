using UnityEngine;
using System.Collections;

public class municion : MonoBehaviour {
	public GameObject guns;
	public disparar script1;
	int a;
	void Start () {
		//guns = GameObject.Find("character/gun");
		//script1 = guns./*.GetComponent<disparar>*/;
		//GameObject.Find("guns").disparar.municionExtra();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision collision){
		Debug.Log("intento Reacargar2");
		//script1 = guns.disparar;
		//script1.municionExtra();
		if(collision.gameObject.tag == "gun"){
			//guns = GameObject.Find("character/gun");
			//script1.municionExtra();
			Debug.Log("Municion Adquirida");
		}
	}
}
