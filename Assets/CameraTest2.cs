using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTest2 : MonoBehaviour {

    public float mouseSensitivity = 0.2f;
    private Vector3 lastPosition;


    float minFov = 15f;
    float maxFov = 90f;
    float sensitivity = -15f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            lastPosition = Input.mousePosition;
        }

        // hold left click to pan X and Y 
        Vector3 delta = Input.mousePosition - lastPosition;

        if (Input.GetMouseButton(0) && (transform.position.x >= -4 || delta.x >= 0) && (transform.position.x <= 4 || delta.x <= 0))
        {

            //transform.Translate(delta.x * mouseSensitivity, 0, delta.y * mouseSensitivity);
            //   if(

            float yMovement = delta.y * mouseSensitivity;
            float radianAngle = 80*Mathf.Deg2Rad;
            transform.Translate(delta.x * mouseSensitivity, yMovement, yMovement*Mathf.Cos(radianAngle));

            lastPosition = Input.mousePosition;
        }

        // scroll to zoom in and out
        float fov = Camera.main.fieldOfView;
        fov += Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        fov = Mathf.Clamp(fov, minFov, maxFov);
        Camera.main.fieldOfView = fov;
    }
}
