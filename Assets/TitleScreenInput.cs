using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TitleScreenInput : MonoBehaviour {

    public Text _text;
    public Animation _animation;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (_text.IsActive() == true)
        {
            if (Input.GetButtonDown("Jump"))
            {
                _animation.Play("Stinger");
            }
        }
	}
}
