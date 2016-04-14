using UnityEngine;
using System.Collections;

public interface IPickupable {

    int pickupAmount
    {
        get;
    }

    void Pickup();
}
