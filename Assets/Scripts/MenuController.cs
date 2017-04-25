using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

	public Camera attachedCamera;
	private CanvasGroup menu;
	private Vector2 cameraXZLook;
	
	// Use this for initialization
	void Start(){
		menu = gameObject.GetComponent(typeof(CanvasGroup)) as CanvasGroup;
		cameraXZLook = new Vector2(attachedCamera.transform.forward.x, attachedCamera.transform.forward.z);
		Hide();
	}
	
	// Update is called once per frame
	void Update(){
		if(Input.GetKeyDown(KeyCode.Escape)){
			if(menu.blocksRaycasts){
				Hide();
			}
			else{
				Show();
			}
		}

		cameraXZLook.Set(attachedCamera.transform.forward.x, attachedCamera.transform.forward.z);
		cameraXZLook.Normalize();
		cameraXZLook *= 10;
		gameObject.transform.position = new Vector3(attachedCamera.transform.position.x + cameraXZLook.x, attachedCamera.transform.position.y, attachedCamera.transform.position.z + cameraXZLook.y);
		gameObject.transform.LookAt(attachedCamera.transform, Vector3.up);
		gameObject.transform.Rotate(Vector3.up * 180);
	}

	public void Hide(){
		menu.alpha = 0f;
		menu.blocksRaycasts = false;
		Camera.main.GetComponent<MouseLook>().active = true;
	}

	public void Show(){
		menu.alpha = 1f;
		menu.blocksRaycasts = true;
		Camera.main.GetComponent<MouseLook>().active = false;
	}
}
