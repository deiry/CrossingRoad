using UnityEngine;
using System.Collections;

public class Calle : MonoBehaviour {
	public Carros [] carros;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void aumentarVelocidad(){
		
		for (int i = 0; i < carros.Length; i++) {
			carros [i].velocidad = carros [i].velocidad + 1;
		}

	}
}
