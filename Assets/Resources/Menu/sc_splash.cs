using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_splash : MonoBehaviour {

	void Start() {
		StartCoroutine(Example());
	}

	//Wait 2s then load sc_loading
	IEnumerator Example() {
		yield return new WaitForSeconds(2);
		Application.LoadLevel ("sc_loading");
	}

}
