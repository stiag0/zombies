using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class disparar : MonoBehaviour
{
	public GameObject contMuni;
	public GameObject bala;
	public GameObject bala_prefab;
	public int balas;
	public int maxbalas;
	Text h;
	int i;
	void Start ()
	{
		balas = 8;
		maxbalas = 32;
		i = 1;
	}
	void recarga(){
		if(balas == 0 && maxbalas > 0){
		Debug.Log("RECARGANDO" + " " + i);
			if(maxbalas >= 8){
				balas = balas + 8;
				maxbalas = maxbalas -8;
			}else{
				balas = maxbalas;
				maxbalas = 0;
			}
			i++;
		}
	}

	void Update ()
	{	

		h = contMuni.GetComponent<Text> ();
		h.text = balas.ToString();

		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			if(balas > 0){
			RaycastHit hit;
			Vector3 ray = transform.forward;
			bala = Instantiate (bala_prefab,new Vector3(transform.position.x,transform.position.y,transform.position.z + 1f), transform.rotation) as GameObject;
			bala.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 70, ForceMode.Impulse);
				balas--;
			if (Physics.Raycast (transform.position, ray, out hit)) {
				Debug.DrawLine (transform.position, hit.point);
			} 
			}else{
				Debug.Log("SIN MUNICION");
				Debug.ClearDeveloperConsole();
			}
		}
		recarga();
	}
	
	public void municionExtra(){
		maxbalas = 32;
		balas = 8;
	}
	
	void OnCollisionEnter(Collision collision){
		Debug.Log("intento Reacargar");
		if(collision.gameObject.tag == "Municion"){
			maxbalas = 32;
			balas = 8;
			Debug.Log("Municion Adquirida");
		}
	}

}
