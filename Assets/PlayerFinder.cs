using UnityEngine;
using System.Collections;
using Prime31;

public class PlayerFinder : MonoBehaviour {

    private CharacterController2D _controller;

    void Awake()
    {
        _controller = this.gameObject.GetComponentInParent<CharacterController2D>();
        _controller.onTriggerEnterEvent += SearchPlayer;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void SearchPlayer(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            SendMessageUpwards("FoundPlayer");
        }
    }
}
