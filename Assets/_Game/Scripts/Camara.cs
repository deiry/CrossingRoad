using UnityEngine;
using System.Collections;

public class Camara : MonoBehaviour {
	public static float posX = 0.0f;
	//Distancia que hay entre la camara y el personaje
	public Vector3 offset;
	void Start () {
		offset = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 nPos = (Vector3.right * posX) + offset;
		//Cortar el la posicion por intervalo, desde donde estoy, hasta donde quiero, valor del intervalo
		transform.position = Vector3.Lerp (transform.position, nPos, 0.3f);
	}
}
