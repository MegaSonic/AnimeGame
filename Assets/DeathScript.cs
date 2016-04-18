using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using Prime31;


public class DeathScript :MonoBehaviour
{

    private CharacterController2D _controller;

    public void Awake()
    {
        _controller = GetComponent<CharacterController2D>();
    }

	public void Start () 
	{
        _controller.onTriggerEnterEvent += OnDeath;
	}


    public void Update()
    {

    }

    public void OnDeath(Collider2D col)
    {
        if (col.gameObject.tag == "DeathTrigger")
        {
            SceneManager.LoadScene("Possibility");
        }
    }

}
