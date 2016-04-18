using UnityEngine;
using System.Collections;

public class LevelMusic : MonoBehaviour {

    public AudioSource music1;
    public AudioSource music2;

    bool musicSwitch = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (music1.isPlaying == false && musicSwitch == false)
        {
            music2.Play();
            musicSwitch = true;
        }
        else if (music2.isPlaying == false && musicSwitch == true)
        {
            music1.Play();
            musicSwitch = false;
        }
	}
}
