using UnityEngine;
using System.Collections;

public class Strategy1 : IStrategy {
	float v = 1;

	public void Method(GameObject g){
		g.GetComponent<SpriteRenderer> ().color = new Color (1, 0, 0, 1);
		g.transform.Translate (new Vector2 (0, v *Time.deltaTime));
		if (g.transform.position.y > 0.1f)
			v = -1;
		if (g.transform.position.y < -0.1f)
			v = 1;
	}

}
