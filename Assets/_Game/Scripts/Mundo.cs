using UnityEngine;
using System.Collections;


public class Mundo : MonoBehaviour {
	public GameObject[] pisos;


	public GameObject[] piso;


	private int		pos = 0;

	public static Mundo singleton;

	void Start () 
	{
		if(singleton != null)
		{
			Destroy(gameObject);
		}else{
			singleton = this;
		}
		for (int i = 0; i < 6; i++) {
			CrearPiso();
		}

	}

	void Update () 
	{
	
	}

	public void CrearPiso()
	{	
		if (!Personaje.vivo)
			return;
		int cualPiso = Random.Range(0, piso.Length);
		Instantiate(piso[cualPiso],Vector3.right*pos,Quaternion.identity);
		pos++;

		aumentarVel ();
	}

	public void aumentarVel(){
		//Types a = typeof(Calle);
		for (int i = 0; i < piso.Length; i++) {
			//if (piso [i].GetType().Equals(a)) {
				print ("entro a aumentar velociada como calle");
			//}
		}

	}


}
