using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Loads a scene. To be attached to a UI trigger event such as OnClick().
 */
public class LoadSceneOnClick : MonoBehaviour {

	/**
	 * Loads a scene based on its index in the build specification.
	 * @param i The index of the scene to load.
	 */
	public void LoadByIndex(int i){
		SceneManager.LoadScene(i);
	}
}
