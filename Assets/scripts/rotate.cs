using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour 
{
    private Quaternion localRotation;
    public float speed = 1.0f;


	// Use this for initialization
	void Start () 
	{
        localRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () 
	{
       // transform.Translate(Input.acceleration.x , Input.acceleration.z, Input.acceleration.y);
        
// PC Control
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

        // Mobile Control
       float curSpeed = Time.deltaTime * speed;

        localRotation.x += Input.acceleration.y * curSpeed;
        localRotation.z += -Input.acceleration.x * curSpeed;
        localRotation.y = 0;
        Debug.Log(localRotation.z);

        if (localRotation.x < 0.2 && localRotation.x > -0.2 && localRotation.z < 0.2 && localRotation.z > -0.2)
        {
            /*
            if(localRotation.x < 0.2)
            {
                localRotation.x = 0.2f;
            }

            if (localRotation.x > -0.2)
            {
                localRotation.x = -0.2f;
            }

            if(localRotation.z < 0.2)
            {
                localRotation.z = 0.2f;
            }

            if(localRotation.z > -0.2)
            {
                localRotation.z = -0.2f;
            }
            */
            transform.rotation = localRotation;
        }

        


    }
}
