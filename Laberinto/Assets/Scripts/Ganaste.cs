using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganaste : MonoBehaviour
{
	//Componente canvas.
	Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
		//Se define el componente canvas.
		canvas = GetComponent<Canvas>();
		//Desactiva el componente canvas.
		canvas.enabled = false;
    }
}
