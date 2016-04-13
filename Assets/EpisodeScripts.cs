using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EpisodeScripts : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void LoadLevel()
    {
        //Application.LoadLevel("Level");
        SceneManager.LoadScene("Level");
    }
}
