using UnityEngine;
using System.Collections;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
public class Personaje : MonoBehaviour {
	public int 	posX	= -1;
	public int 	posZ	= 0;
	[Range(0,1)]	
	public float velocidad = 0.3f;
	public Behaviour[] objetosADeshabilitar;
	public UnityEvent cogioFicha;
	public static bool vivo;
	private Animator miAnimator;

	void Start () 
	{
		vivo = true;
		miAnimator = GetComponent<Animator>();
	}

	void Update () 
	{
		Vector3 nuevaPos = new Vector3 (posX,transform.position.y,posZ);

		if((nuevaPos-transform.position).magnitude>0.1f)
		{
			transform.position = Vector3.Lerp(transform.position,nuevaPos,velocidad);
		}
	}

	public void CaminarFrente()
	{
		posX ++;
		miAnimator.SetTrigger("saltar");
		transform.eulerAngles = Vector3.zero;
		Mundo.singleton.CrearPiso();
	}

	public void CaminarAtras()
	{
		posX --;
		miAnimator.SetTrigger("saltar");
		transform.eulerAngles = Vector3.up * 180;
	}
	public void CaminarDerecha()
	{
		posZ --;
		miAnimator.SetTrigger("saltar");
		transform.eulerAngles = Vector3.up * 90;

	}

	public void CaminarIzquierda()
	{
		posZ ++;
		miAnimator.SetTrigger("saltar");
		transform.eulerAngles = Vector3.up * 270;

	}

	void OnTriggerEnter(Collider cualquiera){

		if (cualquiera.tag == "trompa") {
			miAnimator.SetTrigger ("muerte1");
			deshabilitarTodoEso ();
			vivo = false;
		}

		else if (cualquiera.tag == "Ficha") {
			Destroy (cualquiera.gameObject);
			//Metodo para ingresar un evento desde afuera
			cogioFicha.Invoke ();
		}
	}

	void deshabilitarTodoEso(){

		for(int i=0; i<objetosADeshabilitar.Length;i++){
			objetosADeshabilitar [i].enabled = false;
			print ("Entro en desahbilitar todo eso");
		}
	}

	void reiniciarJuego(){
		
	}
}
