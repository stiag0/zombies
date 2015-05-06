using UnityEngine;
using System.Collections;
using UnityEngine.UI; //libreria inportada

public class hearts : MonoBehaviour {
	public GameObject corazon1;
	public GameObject corazon2;
	public GameObject corazon3;
	public int vida;
	public float invulnerable = 6;
	bool check = true;
	bool par;
	int i;
	public int j;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (vida < 3) {
			corazon1.GetComponent<Image> ().enabled = false;
		} else { 
			corazon1.GetComponent<Image> ().enabled = true;	
		}
		if (vida < 2) {
			corazon2.GetComponent<Image> ().enabled = false;
		} else { 
			corazon2.GetComponent<Image> ().enabled = true;	
		}
		if (vida < 1) {
			corazon3.GetComponent<Image> ().enabled = false;
		} else { 
			corazon3.GetComponent<Image> ().enabled = true;	
		}

		i++;
		if(i>j){
			i=0;
		}

		if(i>=5){
			par = !par;
		}

		if(!check){

			if(vida == 2){
				corazon1.GetComponent<Image> ().enabled = par;
			}
			if(vida == 1){
				corazon2.GetComponent<Image> ().enabled = par;
			}
			if(vida == 0){
				corazon3.GetComponent<Image> ().enabled = par;
			}
		}
		

	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "zombie" && check == true) {
			vida --;
			StartCoroutine( delay ());
			//StartCoroutine( parpadeo());
			}
	}
	IEnumerator delay (){
		float tiempo;
		check = false;
		yield return new WaitForSeconds(invulnerable);
		print (invulnerable);
		check = true;
		/*
		for(tiempo = 0;tiempo < invulnerable;){
		tiempo += Time.deltaTime;
		print (tiempo);
		}
		*/
	}
	/*
	IEnumerator parpadeo (){


	}
	*/
}
