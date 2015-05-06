using UnityEngine;
using System.Collections;

public class movementZ : MonoBehaviour {

	int velocidad = -2;
	void Start () {
	
	}
	
	void Update () {
		transform.Translate(0,0,velocidad*Time.deltaTime);
	}
}
