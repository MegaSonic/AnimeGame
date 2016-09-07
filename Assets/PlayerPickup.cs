using UnityEngine;
using System.Collections;
using Prime31;

public class PlayerPickup : MonoBehaviour {

    public int pickupPoints = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Awake()
    {
        CharacterController2D _controller = GetComponent<CharacterController2D>();
        _controller.onTriggerEnterEvent += Pickup;
    }

 

    void Pickup(Collider2D col)
    {
        if (col.gameObject.GetInterface<IPickupable>() != null)
        {
            var pickup = col.gameObject.GetInterface<IPickupable>();
            pickupPoints += pickup.pickupAmount;
            pickup.Pickup();
            
        }
    }
}
