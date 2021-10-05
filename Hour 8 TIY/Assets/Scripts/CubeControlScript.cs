using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControlScript : MonoBehaviour
{
	private GameObject target;
	void Start()
    {
		target = GameObject.Find("Main Camera");
    }
    void Update()
    {
		//Moves the cube along the x-axis positively and negatively(using A and D)
		//Also moves the cube along the z-axis positively and negatively(using W and S)
		float hVal = Input.GetAxis("Horizontal");
		float vVal = Input.GetAxis("Vertical");

		if (hVal != 0)
			transform.Translate(hVal, 0, 0);
			print("Horizontal movement selected: " + hVal);


		if (vVal != 0)
			transform.Translate(0, 0, vVal);
			print("Vertical movement selected: " + vVal);

		//Testing the mouse input so that it will rotate around the cube
		float mxVal = Input.GetAxis("Mouse X");
		float myVal = Input.GetAxis("Mouse Y");

		if (mxVal != 0)
			target.transform.Rotate(0, myVal, 0);
			print("Mouse X movement selected: " + myVal);

		if (myVal != 0)
			transform.Rotate(mxVal, 0, 0);
			print("Mouse Y movement selected: " + mxVal);

		//Doubling the size and revert it back to normal by pressing the "M" key
		if (Input.GetKey(KeyCode.M))
		{
			transform.localScale = new Vector3(2, 2, 2);
			print("The 'M' key is pressed down");
		}
		else
		{
			transform.localScale = new Vector3(1, 1, 1);
			print("The 'M' key is pressed down");
		}

	}
}
