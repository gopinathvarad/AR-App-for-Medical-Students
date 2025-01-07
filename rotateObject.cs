using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObject : MonoBehaviour
{
	public GameObject objectRotate;

	public float rotateSpeed = 50f;
	bool rotatingStatus = false;

	//rotate object function implemented using boolean values
	public void RotateObject()
	{

		if (rotatingStatus == false)
		{
			rotatingStatus = true;
		}
		else
		{
			rotatingStatus = false;
		}
	}

	void Update()
	{
		if (rotatingStatus == true)
		{
			//rotate object with speed of that respect to the deltatime
			objectRotate.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
		}
	}
}