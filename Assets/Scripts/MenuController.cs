﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using Valve;

/**
 * Controls the menu in the main world. Places the menu in a useful location relative to the camera and disables mouselook for the camera when the menu is active.
 */
public class MenuController : MonoBehaviour {

	public Camera attachedCamera;	/**< The camera that the menu follows around. */
	public GameObject leftControl;
	public GameObject rightControl;
	public GameObject rightControlControl;
	public uint controllerIndex;
	private CanvasGroup menu;
	private Vector2 cameraXZLook;


	
	/**
	 * Finds the CanvasGroup to toggle display and hides the menu before the scene is displayed.
	 */
	void Start(){
		menu = gameObject.GetComponent(typeof(CanvasGroup)) as CanvasGroup;
		cameraXZLook = new Vector2(attachedCamera.transform.forward.x, attachedCamera.transform.forward.z);
		Hide();
		GetComponent<VRTK_ControllerEvents>().StartMenuPressed += new ControllerInteractionEventHandler(Toggle);
	}
	
	/**
	 * Shows and hides the menu when Esc is pressed. Also moves and rotates the menu according to the camera's position and rotation.
	 */
	void Update(){
		if(Input.GetKeyDown(KeyCode.Escape)){
			if(menu.blocksRaycasts){
				Hide ();
			}
			else{
				Show ();
			}
		}

		// Sets the position of the menu to be 10 units in front of the camera in the horizontal plane, and sets it to the same elevation.
		cameraXZLook.Set(attachedCamera.transform.forward.x, attachedCamera.transform.forward.z);
		cameraXZLook.Normalize();
		cameraXZLook *= 5;
		gameObject.transform.position = new Vector3(attachedCamera.transform.position.x + cameraXZLook.x, attachedCamera.transform.position.y, attachedCamera.transform.position.z + cameraXZLook.y);
		gameObject.transform.LookAt(attachedCamera.transform, Vector3.up);
		gameObject.transform.Rotate(Vector3.up * 180);
	}

	public void Toggle(object sender, ControllerInteractionEventArgs e){
		if(menu.blocksRaycasts){
			Hide ();
		}
		else{
			Show ();
		}
	}

	/**
	 * Hides and deactivates the menu so it doesn't interfere with gameplay. Also re-enables the mouselook.
	 */
	public void Hide(){
		menu.alpha = 0f;
		menu.blocksRaycasts = false;
		//Camera.main.GetComponent<MouseLook>().active = true;
		leftControl.GetComponent<VRTK_TouchpadMovement>().active = true;
		rightControl.GetComponent<VRTK_TouchpadMovement>().active = true;
		rightControl.GetComponent<VRTK_UIPointer>().active = false;
		GameObject.Find("RightController").GetComponent<VRTK_StraightPointerRenderer>().enabled = false;
	}

	/**
	 * Shows the menu and enables interaction. Also disables mouselook so the mouse can be used to click on the menu.
	 */
	public void Show(){
		menu.alpha = 1f;
		menu.blocksRaycasts = true;
		//Camera.main.GetComponent<MouseLook>().active = false;
		leftControl.GetComponent<VRTK_TouchpadMovement>().active = false;
		rightControl.GetComponent<VRTK_TouchpadMovement>().active = false;
		rightControl.GetComponent<VRTK_UIPointer>().active = true;
		GameObject.Find("RightController").GetComponent<VRTK_StraightPointerRenderer>().enabled = true;
	}
}
