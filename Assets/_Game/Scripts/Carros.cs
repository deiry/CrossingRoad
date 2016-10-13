using UnityEngine;
using System.Collections;

public class Carros : MonoBehaviour {
	public float 	velocidad = 5;
	public float 	posRetorno = 14;
	void Start () 
	{
		velocidad = 5;
	
	}

	void Update () 
	{
		transform.Translate(Vector3.forward * velocidad*Time.deltaTime);
		if (transform.position.z >= posRetorno)
		{
			transform.Translate(-2*posRetorno*Vector3.forward);
		}
	}
}
