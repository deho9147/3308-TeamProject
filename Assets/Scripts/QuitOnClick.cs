using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Exits the process. To be attached to a UI trigger event such as OnClick().
 */
public class QuitOnClick : MonoBehaviour {

	/**
	 * In the Unity editor, this stops play mode. In the built program, this closes the application.
	 */
	public void Quit(){
		#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
		#else
			Application.Quit();
		#endif
	}
}
