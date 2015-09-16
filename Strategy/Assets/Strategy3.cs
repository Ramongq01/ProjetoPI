using UnityEngine;
using System.Collections;

public class Strategy3 : IStrategy {
	float v = 0.5f;

	public void Method(GameObject g){
		g.GetComponent<SpriteRenderer> ().color = new Color (0, 1, 0, 1);
		g.transform.Translate (new Vector2 (v *Time.deltaTime, v *Time.deltaTime));
		if (g.transform.position.x > 0.05f)
			v = -0.5f;
		if (g.transform.position.x < -0.05f)
			v = 0.5f;
	}

}
