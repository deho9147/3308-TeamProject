using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class ControllerButtons : MonoBehaviour {

	public Canvas menu;
	// Use this for initialization
	void Start () {
		GetComponent<VRTK_ControllerEvents>().ButtonTwoPressed += new ControllerInteractionEventHandler(menu.GetComponent<MenuController>().Toggle);
	}
}
