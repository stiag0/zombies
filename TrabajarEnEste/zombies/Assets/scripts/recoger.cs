using UnityEngine;
using System.Collections;

public class recoger : MonoBehaviour {

	public Transform personaje;
	float rotationSpeed = 3f; 
	bool agarrado = false;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (agarrado == true){
			transform.position = new Vector3 (personaje.position.x /*- 1.28f*/, personaje.position.y/* + 0.83f*/, personaje.position.z /*+ 0.47f*/);
			//transform.Rotate(0, personaje.rotation.y, 0);
		}
		if(Input.GetKey(KeyCode.T)){
			agarrado = false;
		}
	}
	
	void OnCollisionEnter(Collision collision){
		
		if((collision.gameObject.tag == "Player") && Input.GetKey(KeyCode.R)){
			Debug.Log("recogido");
			transform.Translate(0,0.3f,0);
			agarrado = true;
		}
	}
}
