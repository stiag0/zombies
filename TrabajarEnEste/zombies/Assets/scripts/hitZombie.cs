using UnityEngine;
using System.Collections;

public class hitZombie : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision collision){
		if((collision.gameObject.tag == "bullet") || (collision.gameObject.tag == "sword")){
			Destroy(gameObject);
		}
	}
}
