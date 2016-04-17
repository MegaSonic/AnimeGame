using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MusicOuttro : MonoBehaviour {

    public AudioSource platinum;
    public AudioSource platinumStinger;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void StartStinger()
    {
        platinum.Stop();
        platinumStinger.Play();
    }

    void LoadScene()
    {
        SceneManager.LoadScene("Episode");
    }
}
