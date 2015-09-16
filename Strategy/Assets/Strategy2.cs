using UnityEngine;
using System.Collections;

public class Strategy2 : IStrategy {
	float v = 1;

	public void Method(GameObject g){
		g.GetComponent<SpriteRenderer> ().color = new Color (0, 0, 1, 1);
		g.transform.Translate (new Vector2 (v *Time.deltaTime, 0));
		if (g.transform.position.x > 0.1f)
			v = -1;
		if (g.transform.position.x < -0.1f)
			v = 1;
	}

}
