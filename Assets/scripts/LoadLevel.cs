using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour 
{
//my versio0n without public level load	
/*	public void OnTriggerEnter(Collider other)
	{
		if (other.transform.root.CompareTag("Ball"))
		{
			 Application.LoadLevel("WinScreen");
		}
	}

}*/

public string sLevel;

public void OnTriggerEnter(Collider other)
{
	if (other.transform.root.CompareTag("Ball"))
	{
		Application.LoadLevel(sLevel);
	}
}

}
