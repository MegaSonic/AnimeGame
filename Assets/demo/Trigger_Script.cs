using UnityEngine;
using System.Collections;
using Prime31;

public class Trigger_Script : MonoBehaviour {

    public Transform Obj2_Activate;
    public CharacterController2D controller;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Awake()
    {
        controller.onTriggerEnterEvent += ActivateObject;
    }
    
    void ActivateObject(Collider2D col)
    {
        if (Obj2_Activate.gameObject.activeSelf == false)
        {
            Obj2_Activate.gameObject.SetActive(true);
        }
    }
}
