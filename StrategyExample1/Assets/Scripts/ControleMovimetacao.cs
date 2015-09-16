using UnityEngine;
using System.Collections;

public class ControleMovimetacao : MonoBehaviour {

	IMovimentacao a = new Movimento1();

	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			a = new Movimento1 ();
		}
		if (Input.GetKeyDown(KeyCode.Alpha2))
			a = new Movimento2();
		if (Input.GetKeyDown(KeyCode.Alpha3))
			//a = new Movimento3();

		a.Mover(this.gameObject);
	
	}
}
