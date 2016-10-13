using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Rompecabezas : MonoBehaviour {
	public GameObject[] fotos;
	public int index = -1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void mostrar(){
		index++;
		fotos [index].SetActive (true);
	}



}
