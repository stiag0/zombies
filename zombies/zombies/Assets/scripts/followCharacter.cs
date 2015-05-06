using UnityEngine;
using System.Collections;

public class followCharacter : MonoBehaviour {

	Transform target;
	int move_speed = 10;
	int rotation_speed = 3;
	Transform zombie_position;

	void awake(){
		zombie_position = transform;
	}

	void Start () {
		target = GameObject.FindWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		zombie_position.rotation = Quaternion.Slerp(zombie_position.rotation,Quaternion.LookRotation(target.position - zombie_position.position),rotation_speed*Time.deltaTime);
		zombie_position.position += zombie_position.forward * move_speed * Time.deltaTime;
	}
}
