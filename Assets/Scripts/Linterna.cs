using UnityEngine;
using System.Collections;

public class Linterna : MonoBehaviour {

	// Use this for initialization
	public Light luz;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.F)) {
			if(luz.GetComponent<Light>().enabled == true){
				luz.GetComponent<Light>().enabled = false;
				Debug.Log ("apagada");
			} else {
				luz.GetComponent<Light>().enabled = true;
				Debug.Log ("encendida");
			}
		}
	}
}
