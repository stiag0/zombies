using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	int velocidad = 8;
	int rotacion = 3;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0, Input.GetAxis ("Horizontal") * velocidad * Time.deltaTime);
		transform.Rotate (0,  Input.GetAxis ("Vertical") * rotacion,0,Space.World );
		//transform.Translate (Input.GetAxis ("Turn") * velocidad * Time.deltaTime,0,Input.GetAxis ("Turn") * velocidad * Time.deltaTime );
		//transform.Rotate(Input.GetAxis("Turn"),Time.deltaTime,Space.Self);
		//transform.Rotate(Input.GetAxis("Turn"), Time.deltaTime);
	}
}
