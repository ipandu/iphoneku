using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Vuforia
{
	public class Spesifikasi : MonoBehaviour {

		public Transform ButtonSpek5;
		public Transform ButtonSpek5s;
		public Transform ButtonSpek6;
		public Transform ButtonSpek6Plus;
		public Transform ButtonSpek6s;
		public Transform ButtonSpek6sPlus;
		public Transform ButtonSpek7;
		public Transform ButtonSpek7Plus;

		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			//Get Image Target Name
			StateManager sm = TrackerManager.Instance.GetStateManager();
			IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

			foreach (TrackableBehaviour tb in tbs)
			{
				string name = tb.TrackableName;
				ImageTarget it = tb.Trackable as ImageTarget;
				Vector2 size = it.GetSize();

				Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);

				//If the target name was “iphone5” or "iphone5video" then ButtonSpek5 will visible
				if(name == "iphone5" || name=="iphone5video"){
					ButtonSpek5.gameObject.SetActive(true);
				}
					
				//If the target name was “iphone5s” or "iphone5svideo" then ButtonSpek5s will visible
				if (name == "iphone5s" || name=="iphone5svideo")
				{
					ButtonSpek5s.gameObject.SetActive(true);
				}

				//If the target name was “iphone6new” or "iphone6vidnew" then ButtonSpek6 will visible
				if(name == "iphone6new" || name=="iphone6vidnew"){
					ButtonSpek6.gameObject.SetActive(true);
				}

				//If the target name was “iphone6pnew” or "iphone6pvidnew" then ButtonSpek6Plus will visible
				if(name == "iphone6pnew" || name=="iphone6pvidnew"){
					ButtonSpek6Plus.gameObject.SetActive(true);
				}

				//If the target name was “iphone6snew” or "iphone6svidnew" then ButtonSpek6s will visible
				if(name == "iphone6snew" || name=="iphone6svidnew"){
					ButtonSpek6s.gameObject.SetActive(true);
				}

				//If the target name was “iphone6spnew” or "iphone6svidnew" then ButtonSpek6sPlus will visible
				if(name == "iphone6spnew" || name=="iphones6spvidnew"){
					ButtonSpek6sPlus.gameObject.SetActive(true);
				}

				//If the target name was “iphone7” or "iphone7video" then ButtonSpek7 will visible
				if(name == "iphone7" || name=="iphone7video"){
					ButtonSpek7.gameObject.SetActive(true);
				}

				//If the target name was “iphone7plus” or "iphone7pvnew" then ButtonSpek7Plus will visible
				if(name == "iphone7plus" || name=="iphone7pvnew"){
					ButtonSpek7Plus.gameObject.SetActive(true);
				}
			}
		}
	}
}