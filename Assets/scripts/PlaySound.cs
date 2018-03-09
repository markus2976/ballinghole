using UnityEngine;
using System.Collections;


public class PlaySound : MonoBehaviour 
{

		public AudioSource mySource;

			public void playAudio (AudioClip x)
			{
				mySource = GetComponent<AudioSource> ();
				mySource.PlayOneShot (x);
			}

}

