using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bandera : MonoBehaviour
{
	//Este metodo se reproduce si algun objeto colisiona con el componente boxcollider.
	void OnTriggerEnter2D(Collider2D col)
	{
		//Encuentra el objeto Ganaste en la escena y activa su componente canvas.
		GameObject.Find("Ganaste").GetComponent<Canvas>().enabled = true;
		//Pausa toda la escena.
		Time.timeScale = (true) ? 0 : 1f;
	}
}
