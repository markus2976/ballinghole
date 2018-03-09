using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour 
{


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKeyDown(KeyCode.W))
		{
			if (transform.rotation.x < -0.6087615)
			{
				transform.Rotate(1,0,0);
			}
		}

		if (Input.GetKeyDown(KeyCode.A))
		{
			if (transform.rotation.z < 0.09229597)
			{
			transform.Rotate(0,-1,0);
			}
			print (transform.rotation.z);
		}

		if (Input.GetKeyDown(KeyCode.S))
		{
			if (transform.rotation.x > -0.7880108)
			{
			transform.Rotate(-1,0,0);

			}
		}

		if (Input.GetKeyDown(KeyCode.D))
		{
			if (transform.rotation.z > -0.09229597)
			{
			transform.Rotate(0,1,0);
			}
			print (transform.rotation.z);
		}
	
	
	}
}
