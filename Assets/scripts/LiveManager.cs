using UnityEngine;
using System.Collections;

public class LiveManager : MonoBehaviour
{
    int Lives = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void checkLives()
    {
        if (Lives < 1)
        {
            Application.LoadLevel("LoseScreen");
        }
    }
}
