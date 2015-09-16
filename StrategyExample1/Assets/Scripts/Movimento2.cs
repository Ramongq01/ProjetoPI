using UnityEngine;
using System.Collections;

public class Movimento2  : IMovimentacao {
	private float velocidade = 5;

	public void Mover(GameObject g){
		g.transform.Translate (new Vector3 (velocidade*Time.deltaTime, 0, 0));
		g.GetComponent<Renderer> ().material.SetColor ("_Color", Color.blue);
	}
}
