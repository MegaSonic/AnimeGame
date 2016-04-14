using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour, IPickupable {

    public int value;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public int pickupAmount
    {
        get { return value; }
    }

    void IPickupable.Pickup()
    {
        this.gameObject.SetActive(false);
        Destroy(this.gameObject);
    }
}
