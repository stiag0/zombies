using UnityEngine;
using System.Collections;

public class CrearZ : MonoBehaviour {

	public GameObject zombie_prefab;
	float timer = 0;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer+= Time.deltaTime;
		if(timer >= 2){
			Instantiate(zombie_prefab,new Vector3(transform.position.x+1f,transform.position.y,transform.position.z+1f),transform.rotation);
			timer = 0;
		}
	}
}
