using System;
using UnityEngine;
using UnityEngine.EventSystems;


public class DeathScript :MonoBehaviour
{

	Vector3 regeneration; 

	public void Start () 
	{


		regeneration = transform.position;

	}
		public void OnTriggerEnter(Collider other) 
		{


			if (other.gameObject.CompareTag("CheckPoint"))
		    {
			regeneration = other.transform.position;
			//Destroy (other.gameObject);

			}


			if (other.gameObject.CompareTag ("Hazard"))
			{
			transform.position = regeneration;
			}
		}// reload the scene
       
}
