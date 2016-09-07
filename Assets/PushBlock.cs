using UnityEngine;
using System.Collections;
using Prime31;

public class PushBlock : MonoBehaviour, IPushable {

    public CharacterController2D _controller;
    public Vector3 velocity;
    public float speed = 0;
    public float pushSpeed = 5;
    public float gravity = -46;
    private PushState _pushState;

	// Use this for initialization
	void Start () {
        _controller = GetComponent<CharacterController2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!_controller.isGrounded)
        {
            velocity.y += gravity * Time.deltaTime;
            if (velocity.y < -25)
            {
                velocity.y = -25;
            }
            velocity *= Time.deltaTime;
            _controller.move(velocity);
            velocity = _controller.velocity;
        }
	}

    public void Push(PushState pushState)
    {
        speed = 0;

        if (pushState == PushState.LEFT)
        {
            speed = pushSpeed * -1;
        }
        else if (pushState == PushState.RIGHT)
        {
            speed = pushSpeed;
        }
        
        velocity.y += gravity * Time.deltaTime;
        if (velocity.y < -25)
        {
            velocity.y = -25;
        }
        
        velocity.x = speed;
        velocity *= Time.deltaTime;
        _controller.move(velocity);
        velocity = _controller.velocity;
    }
}
