using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
	//Variable que se usara para guardar aqui el componente Animator.
	Animator anim;
	//Variable que se usara para guardar aqui el componente Rigidbody2D.
	Rigidbody2D rb2d;
	//Variable de velocidad del jugador.
	public float speed = 4f;
	public GameObject spawn;
    // Start is called before the first frame update
    void Start()
    {
		//Coloca al objeto que tiene el componente en la posicion del spawn.
		gameObject.transform.position = spawn.transform.position;
		//Define el componente Animator.
		anim = GetComponent<Animator>();
		//Define el componente Rigidbody2D.
		rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		//Define un vector de movimiento, recibiendo las flachas del teclado.
		Vector2 mov = new Vector2(
			Input.GetAxisRaw("Horizontal"),
			Input.GetAxisRaw("Vertical")
		);
		//Mueve la posicion de el jugador, pasandole el vetor mov y la veloocidad speed.
		rb2d.MovePosition(rb2d.position + mov * speed * Time.deltaTime);
		//Pasa los parametros "x", "y" y define si esta caminando o no.
		if(mov != Vector2.zero)
		{
			anim.SetFloat("x", mov.x);
			anim.SetFloat("y", mov.y);
			anim.SetBool("Caminando", true);
		}
		else
		{
			anim.SetBool("Caminando", false);
		}
    }
}
