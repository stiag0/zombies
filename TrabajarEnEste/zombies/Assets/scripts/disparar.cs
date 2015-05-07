using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class disparar : MonoBehaviour
{
	public GameObject bala;
	public GameObject bala_prefab;
	public int balas;
	public int maxbalas;
	int i;
	public GameObject cont_muni;
	Text contador_balas;
	float recargar_tiempo = 5f;
	void Start ()
	{
		balas = 8;
		maxbalas = 32;
		i = 1;
	}
	void recarga(){
		if(balas == 0 && maxbalas > 0){
			//StartCoroutine(llenar_municion());
			 if(maxbalas >= 8){
			 StartCoroutine(llenar_municion());
				
			}else{
				balas = maxbalas;
				maxbalas = 0;
			}
			i++;  // nos dice cuantas veces hemos recargado
		}
	}
	
	IEnumerator llenar_municion(){
		balas = 8;
		maxbalas = maxbalas - 8;
		yield return new WaitForSeconds(recargar_tiempo); // arreglar que el texto "recargando" salga mas tiempo
		contador_balas.text = "Recargando";
		
	}

	void Update ()
	{
		contador_balas = cont_muni.GetComponent<Text>();  //imprimir balas
		contador_balas.text = balas.ToString();
		
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
				contador_balas.text = "Sin Municion";
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
