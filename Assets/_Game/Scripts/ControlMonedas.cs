using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlMonedas : MonoBehaviour {
	public Fichas []fichas;
	public float posicionY;
	public Vector2 posicionZ;
	public int fichasRecogidas = 0;
	public Text txtFichas;
	public Rompecabezas rompeCabezas;

	void Start () {
		for(int i=0; i< fichas.Length; i++){
			Vector3 nuevaPos = new Vector3 (fichas [i].posicion, posicionY, Random.Range (posicionZ.x, posicionZ.y));
			Instantiate (fichas [i].objeto, nuevaPos, Quaternion.identity);
		}
		txtFichas.text = "Fichas: " + 00;
	}

	void Update () {
	
	}
	public void SumarFIchas(){
		fichasRecogidas++;
		txtFichas.text = "Fichas: " + fichasRecogidas.ToString("00");
		rompeCabezas.mostrar ();

	}
}
