using UnityEngine;
using System.Collections;

public class movecamera : MonoBehaviour {
	
	public Transform personaje; 
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (personaje.position.x,transform.position.y, personaje.position.z);
	}
}

