using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MusicOuttro : MonoBehaviour {

    public AudioSource platinum;
    public AudioSource platinumStinger;

    public MovieTexture movie;
    public RawImage image;

	// Use this for initialization
	void Start () {
        image.texture = movie as MovieTexture;
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

    void PlayMovie()
    {
        //movie.Play();
        //movie.loop = true;
    }
}
