using UnityEngine;
using System.Collections;

public class StrategyController : MonoBehaviour {
	IStrategy s = new Strategy1();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha1))
			s = new Strategy1 ();
		if (Input.GetKeyDown (KeyCode.Alpha2))
			s = new Strategy2 ();
		if (Input.GetKeyDown (KeyCode.Alpha3))
			s = new Strategy3 ();

		s.Method (this.gameObject);
	}
}
