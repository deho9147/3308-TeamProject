using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Controls camera rotation based on mouse input. Should be attached to a basic camera object.
 */
public class MouseLook : MonoBehaviour {

    public float mouseSensitivity = 100.0f;     /**< Sensitivity of mouse. Higher values means movements of the mouse rotate the camera more. */
    public float clampAngle = 80.0f;            /**< Restricts camera angle vertically. Typically less than 90. Units are degrees. */

    public bool active = true;                  /**< Flag for enabling and disabling mouselook for interacting with UI, etc... */

    private float rotY = 0.0f;
    private float rotX = 0.0f;

    /**
     * Initializes rotations on scene load.
     */
    void Start(){
        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
        rotX = rot.x;
    }

    /**
     * Every frame, checks difference in mouse location and rotates the camera accordingly.
     */
    void Update(){
        if(active){
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = -Input.GetAxis("Mouse Y");

            rotY += mouseX * mouseSensitivity * Time.deltaTime;
            rotX += mouseY * mouseSensitivity * Time.deltaTime;

            rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);

            Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
            transform.rotation = localRotation;
        }
    }
}
