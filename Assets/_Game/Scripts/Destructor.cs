using UnityEngine;
using System.Collections;

public class Destructor : MonoBehaviour {

	void OnTriggerEnter(Collider otro)
	{
		Destroy(otro.gameObject);
	}
}
