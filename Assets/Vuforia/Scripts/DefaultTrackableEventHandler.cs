/*==============================================================================
Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using UnityEngine;
using UnityEngine.UI;

namespace Vuforia
{
    /// <summary>
    /// A custom handler that implements the ITrackableEventHandler interface.
    /// </summary>
    public class DefaultTrackableEventHandler : MonoBehaviour,
                                                ITrackableEventHandler
    {
		public Transform ButtonSpek5;
		public Transform ButtonSpek5s;
		public Transform ButtonSpek6;
		public Transform ButtonSpek6Plus;
		public Transform ButtonSpek6s;
		public Transform ButtonSpek6sPlus;
		public Transform ButtonSpek7;
		public Transform ButtonSpek7Plus;
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

		#region PRIVATE_MEMBER_VARIABLES
 
        private TrackableBehaviour mTrackableBehaviour;
    
        #endregion // PRIVATE_MEMBER_VARIABLES



        #region UNTIY_MONOBEHAVIOUR_METHODS
    
        void Start()
        {
            mTrackableBehaviour = GetComponent<TrackableBehaviour>();
            if (mTrackableBehaviour)
            {
                mTrackableBehaviour.RegisterTrackableEventHandler(this);
            }
        }

        #endregion // UNTIY_MONOBEHAVIOUR_METHODS



        #region PUBLIC_METHODS

        /// <summary>
        /// Implementation of the ITrackableEventHandler function called when the
        /// tracking state changes.
        /// </summary>
        public void OnTrackableStateChanged(
                                        TrackableBehaviour.Status previousStatus,
                                        TrackableBehaviour.Status newStatus)
        {
            if (newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED ||
                newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
            {
                OnTrackingFound();
            }
            else
            {
                OnTrackingLost();
            }
        }

        #endregion // PUBLIC_METHODS



        #region PRIVATE_METHODS


        private void OnTrackingFound()
        {
            Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
            Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);

            // Enable rendering:
            foreach (Renderer component in rendererComponents)
            {
                component.enabled = true;
            }

            // Enable colliders:
            foreach (Collider component in colliderComponents)
            {
                component.enabled = true;
            }

            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
        }


        private void OnTrackingLost()
        {
            Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
            Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);

            // Disable rendering:
            foreach (Renderer component in rendererComponents)
            {
                component.enabled = false;
            }

            // Disable colliders:
            foreach (Collider component in colliderComponents)
            {
                component.enabled = false;
            }

            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
			
			ButtonSpek5.gameObject.SetActive(false);
			ButtonSpek5s.gameObject.SetActive(false);
			ButtonSpek6.gameObject.SetActive(false);
			ButtonSpek6Plus.gameObject.SetActive(false);
			ButtonSpek6s.gameObject.SetActive(false);
			ButtonSpek6sPlus.gameObject.SetActive(false);
			ButtonSpek7.gameObject.SetActive(false);
			ButtonSpek7Plus.gameObject.SetActive(false);
			PanelIph5.gameObject.SetActive(false);
			PanelIph5_2.gameObject.SetActive(false);
			PanelIph5s.gameObject.SetActive(false);
			PanelIph5s_2.gameObject.SetActive(false);
			PanelIph6.gameObject.SetActive(false);
			PanelIph6_2.gameObject.SetActive(false);
			PanelIph6s.gameObject.SetActive(false);
			PanelIph6s_2.gameObject.SetActive(false);
			PanelIph6Plus.gameObject.SetActive(false);
			PanelIph6Plus_2.gameObject.SetActive(false);
			PanelIph6sPlus.gameObject.SetActive(false);
			PanelIph6sPlus_2.gameObject.SetActive(false);
			PanelIph7.gameObject.SetActive(false);
			PanelIph7_2.gameObject.SetActive(false);
			PanelIph7Plus.gameObject.SetActive(false);
			PanelIph7Plus_2.gameObject.SetActive(false);
        }

        #endregion // PRIVATE_METHODS
    }
}
