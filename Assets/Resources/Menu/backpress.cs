using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backpress : MonoBehaviour {

	// Update is called once per frame

	void Update()
	{
		//Android Back Button
		if (Input.GetKeyDown (KeyCode.Escape))
			Application.LoadLevel ("sc_main_menu");
	}
}
