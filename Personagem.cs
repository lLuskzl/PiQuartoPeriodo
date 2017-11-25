using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour {
	Animator Animador;
	Rigidbody2D rb2D;
	// Use this for initialization
	void Start () {
 		Animador.SetBool ("SeMove", true);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			Animador.SetBool ("SeMove", false);
		}
	}

	public void Movimento(object Move){
		Input.GetAxis("Horizontal"), Input.GetAxis("Horizontal")*10;
	} 
	void Move (int direcao, float velocidade){
		if (direcao > 0)
			transform.rotation.eulerAngles.y = 0;
		else
			transform.rotation.eulerAngles.y = 180;

		rb2D.velocity.x = velocidade;
	}
}
