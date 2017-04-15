using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

	public Camera attachedCamera;
	private CanvasGroup menu;
	
	// Use this for initialization
	void Start(){
		menu = gameObject.GetComponent(typeof(CanvasGroup)) as CanvasGroup;
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

		gameObject.transform.position = attachedCamera.transform.position + attachedCamera.transform.forward * 10;
		gameObject.transform.LookAt(attachedCamera.transform, Vector3.up);
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
