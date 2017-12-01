using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour {

	public enum RotationAxis{
MouseX=1,
MouseY=2
	}

	public RotationAxis axes = RotationAxis.MouseX; 

public float minVert =-45.0f; 
public float maxVert =45.0f;
public  float sensHz =10.0f; 
public float sensV = 10.0f; 
public float _rotationX=0; 
 
	
	// Update is called once per frame
	void Update () {
		if (axes == RotationAxis.MouseX) {
			transform.Rotate (0, Input.GetAxis ("Mouse X") * sensHz, 0); 
		} else if (axes == RotationAxis.MouseY) { 
			_rotationX -= Input.GetAxis ("Mouse Y") * sensV; 
			_rotationX = Mathf.Clamp (_rotationX, minVert, maxVert);

			float rotationY = transform.localEulerAngles.y; 
			transform.localEulerAngles = new Vector3 (_rotationX, rotationY, 0); 
		}
	}	
}
