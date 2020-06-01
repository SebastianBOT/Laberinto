using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour
{
	//Se define el objeto player.
	public GameObject player;
	//Se define el objeto spawn.
	public GameObject spawn;
	//Este es el objeto del camino hacia la meta.
	GameObject camino;
    // Start is called before the first frame update.
    void Start()
    {
		//Busca el objeto camino en la escena.
		camino = GameObject.Find("Camino");
		//Este for oculta el camino buscando cada hijo del objeto camino.
		for (int i = 0; i < camino.transform.childCount; i++)
		{
			camino.transform.GetChild(i).GetComponent<SpriteRenderer>().enabled = false;
		}
    }
	//Este es el metodo usado en el boton salir.
	public void Salir()
	{
		//Cierra la aplicacion.
		Application.Quit();
	}
	//Este es el metodo usado en el boton Mostrar Camino.
	public void MostrarCamino()
	{
		//Este for muestra el camino buscando cada hijo del objeto camino.
		for (int j = 0; j < camino.transform.childCount; j++)
		{
			camino.transform.GetChild(j).GetComponent<SpriteRenderer>().enabled = true;
		}
	}
	//Este es el metodo usado en el boton Ocultar Camino.
	public void OcultarCamino()
	{
		//Este for oculta el camino buscando cada hijo del objeto camino.
		for (int j = 0; j < camino.transform.childCount; j++)
		{
			camino.transform.GetChild(j).GetComponent<SpriteRenderer>().enabled = false;
		}
	}
	//Este es el metodo usado en el boton Reiniciar.
	public void Reiniciar()
	{
		//Ajusta la velocidad del juego a la velocidad normal, por si se encontraba pausado.
		Time.timeScale = (false) ? 0 : 1f;
		//Encuentra el objeto Ganaste en la escena y activa su componente canvas.
		GameObject.Find("Ganaste").GetComponent<Canvas>().enabled = false;
		//Transforma la posicion del jugador a la posicion del spawn.
		player.transform.position = spawn.transform.position;
		//Este for oculta el camino buscando cada hijo del objeto camino.
		for (int p = 0; p < camino.transform.childCount; p++)
		{
			camino.transform.GetChild(p).GetComponent<SpriteRenderer>().enabled = false;
		}
	}
}
