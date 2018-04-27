using UnityEngine;
using System.Collections;
using System;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class InteractionManager : MonoBehaviour

{

	SteamVR_TrackedObject trackedObj;
	SteamVR_Controller.Device device;

	void Awake ()
	{
		trackedObj = GetComponent<SteamVR_TrackedObject>();
	}

	void FixedUpdate()
	{
		device = SteamVR_Controller.Input((int)trackedObj.index);
	}

	void OnTriggerStay (Collider col)
	{
		if (device.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
		{
			col.attachedRigidbody.isKinematic = true;
			col.gameObject.transform.SetParent(this.gameObject.transform);
		}

		if (device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger))
		{
			col.gameObject.transform.SetParent(null);
			col.attachedRigidbody.isKinematic = false;

			//tossObject(col.attachedRigidbody);
		}

		if (device.GetPress (SteamVR_Controller.ButtonMask.Grip))
		{
			//hitObject (col.attachedRigidbody);
		}
	}
}