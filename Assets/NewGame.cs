using UnityEngine;
using System.Collections;

public class NewGame : MonoBehaviour {

    public Animation _animation;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void StartNewGame()
    {
        _animation.Play("Stinger");
    }
}
