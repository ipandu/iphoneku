using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_Handler : MonoBehaviour {
	
	public Transform PanelIph5;
	public Transform PanelIph5_2;
	public Transform PanelIph5s;
	public Transform PanelIph5s_2;
	public Transform PanelIph6;
	public Transform PanelIph6_2;
	public Transform PanelIph6Plus;
	public Transform PanelIph6Plus_2;
	public Transform PanelIph6s;
	public Transform PanelIph6s_2;
	public Transform PanelIph6sPlus;
	public Transform PanelIph6sPlus_2;
	public Transform PanelIph7;
	public Transform PanelIph7_2;
	public Transform PanelIph7Plus;
	public Transform PanelIph7Plus_2;

	//Close All Panel
	public void DestroyPanel(){
		PanelIph5.gameObject.SetActive (false);
		PanelIph5_2.gameObject.SetActive (false);
		PanelIph5s.gameObject.SetActive (false);
		PanelIph5s_2.gameObject.SetActive (false);
		PanelIph6.gameObject.SetActive (false);
		PanelIph6_2.gameObject.SetActive (false);
		PanelIph6Plus.gameObject.SetActive (false);
		PanelIph6Plus_2.gameObject.SetActive (false);
		PanelIph6s.gameObject.SetActive (false);
		PanelIph6s_2.gameObject.SetActive (false);
		PanelIph6sPlus.gameObject.SetActive (false);
		PanelIph6sPlus_2.gameObject.SetActive (false);
		PanelIph7.gameObject.SetActive (false);
		PanelIph7_2.gameObject.SetActive (false);
		PanelIph7Plus.gameObject.SetActive (false);
		PanelIph7Plus_2.gameObject.SetActive (false);
	}


	//Next And Previous Panel
	public void NextPrevPaneliph5(){
		PanelIph5_2.gameObject.SetActive (true);
		PanelIph5.gameObject.SetActive (false);
	}

	public void NextPrevPaneliph5_2(){
		PanelIph5.gameObject.SetActive (true);
		PanelIph5_2.gameObject.SetActive (false);
	}

	public void NextPrevPaneliph5s(){
		PanelIph5s_2.gameObject.SetActive (true);
		PanelIph5s.gameObject.SetActive (false);
	}

	public void NextPrevPaneliph5s_2(){
		PanelIph5s.gameObject.SetActive (true);
		PanelIph5s_2.gameObject.SetActive (false);
	}

	public void NextPrevPaneliph6(){
		PanelIph6_2.gameObject.SetActive (true);
		PanelIph6.gameObject.SetActive (false);
	}

	public void NextPrevPaneliph6_2(){
		PanelIph6.gameObject.SetActive (true);
		PanelIph6_2.gameObject.SetActive (false);
	}

	public void NextPrevPaneliph6p(){
		PanelIph6Plus_2.gameObject.SetActive (true);
		PanelIph6Plus.gameObject.SetActive (false);
	}

	public void NextPrevPaneliph6p_2(){
		PanelIph6Plus.gameObject.SetActive (true);
		PanelIph6Plus_2.gameObject.SetActive (false);
	}

	public void NextPrevPaneliph6s(){
		PanelIph6s_2.gameObject.SetActive (true);
		PanelIph6s.gameObject.SetActive (false);
	}

	public void NextPrevPaneliph6s_2(){
		PanelIph6s.gameObject.SetActive (true);
		PanelIph6s_2.gameObject.SetActive (false);
	}

	public void NextPrevPaneliph6sp(){
		PanelIph6sPlus_2.gameObject.SetActive (true);
		PanelIph6sPlus.gameObject.SetActive (false);
	}

	public void NextPrevPaneliph6sp_2(){
		PanelIph6sPlus.gameObject.SetActive (true);
		PanelIph6sPlus_2.gameObject.SetActive (false);
	}

	public void NextPrevPaneliph7(){
		PanelIph7_2.gameObject.SetActive (true);
		PanelIph7.gameObject.SetActive (false);
	}

	public void NextPrevPaneliph7_2(){
		PanelIph7.gameObject.SetActive (true);
		PanelIph7_2.gameObject.SetActive (false);
	}

	public void NextPrevPaneliph7p(){
		PanelIph7Plus_2.gameObject.SetActive (true);
		PanelIph7Plus.gameObject.SetActive (false);
	}

	public void NextPrevPaneliph7p_2(){
		PanelIph7Plus.gameObject.SetActive (true);
		PanelIph7Plus_2.gameObject.SetActive (false);
	}


	//Set Panel Visible
	public void ShowPanelIph5(){
		PanelIph5.gameObject.SetActive (true);
	}

	public void ShowPanelIph5s(){
		PanelIph5s.gameObject.SetActive (true);
	}

	public void ShowPanelIph6(){
		PanelIph6.gameObject.SetActive (true);
	}

	public void ShowPanelIph6Plus(){
		PanelIph6Plus.gameObject.SetActive (true);
	}

	public void ShowPanelIph6s(){
		PanelIph6s.gameObject.SetActive (true);
	}

	public void ShowPanelIph6sPlus(){
		PanelIph6sPlus.gameObject.SetActive (true);
	}

	public void ShowPanelIph7(){
		PanelIph7.gameObject.SetActive (true);
	}

	public void ShowPanelIph7Plus(){
		PanelIph7Plus.gameObject.SetActive (true);
	}
}