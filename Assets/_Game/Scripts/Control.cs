using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {

	Vector3 p1		= Vector3.zero;
	Vector3 p2		= Vector3.zero;
	Vector3 deltaP	= Vector3.zero;

	public float 		tamDelta = 20;
	public Personaje	personaje;

	void Start () 
	{
	
	}

	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			p1 = Input.mousePosition;
		}

		if(Input.GetMouseButtonUp(0)&& (Personaje.vivo))
		{
			p2 = Input.mousePosition;
			deltaP = p2 - p1;
			if (deltaP.sqrMagnitude > tamDelta*tamDelta) 
			{
				if(Mathf.Abs(deltaP.x) > Mathf.Abs(deltaP.y))
				{
					if (deltaP.x > 0)
					{
						print("Derecha");
						personaje.CaminarDerecha();
					}else{
						print("Izquierda");
						personaje.CaminarIzquierda();
					}
				}else{
					if (deltaP.y > 0)
					{
						print("Arriba");
						personaje.CaminarFrente();
						Camara.posX ++;
					}else{
						print("Abajo");
						personaje.CaminarAtras();
					}
				}
			}else{
				personaje.CaminarFrente();
				Camara.posX ++;
			}
		}
	}
}
