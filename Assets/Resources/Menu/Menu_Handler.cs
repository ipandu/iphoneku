using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Handler : MonoBehaviour {

	//Change Scene
	public void GoToMainMenu(){
		Application.LoadLevel("sc_main_menu");
	}

	public void GoToARCamera(){
		Application.LoadLevel("sc_ar");
	}

	public void GoToHelp(){
		Application.LoadLevel("sc_help");
	}

	public void GoToAbout(){
		Application.LoadLevel("sc_about");
	}

	public void ExitApplication(){
		Application.Quit ();
	}

}