using UnityEngine;
using System.Collections;

public class sword : MonoBehaviour {

	float timer = 0;
	bool espadaso = true;
	public GameObject espada;
	bool paralelo = true;
	void Start () {
		//espada = GameObject.FindGameObjectWithTag("sword");
	}
	
	IEnumerator tiempo_que_la_espada_va_a_esperar(){
		yield return new WaitForSeconds(1f);
		paralelo = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse0) && espadaso && paralelo){	
			transform.Rotate(0,100f,0);
			espadaso = false;
			paralelo = false;
			espada.GetComponent<Collider>().enabled = true;
		}
		if(timer < 0.1f && !espadaso){
			timer+= Time.deltaTime;
		}
		if(timer > 0.1f && !espadaso){
			transform.Rotate(0,-100f,0);
			espadaso = true;
			timer = 0;
			espada.GetComponent<Collider>().enabled = false;
			StartCoroutine(tiempo_que_la_espada_va_a_esperar());
		}	
	}
}
