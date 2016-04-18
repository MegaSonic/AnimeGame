using UnityEngine;
using System.Collections;
using System;
using Prime31;

public class Enemy : MonoBehaviour, IHealth, IKillable {
    public int health;
    public int maxHealth;
    public bool foundPlayer = false;
    public float walkSpeed;

    private Vector3 _velocity;

    public float gravity;
    public float deathJumpHeight = 5;

    public bool isDead = false;

    private CharacterController2D _controller;
    public SpriteAnimator _animator;

    void Awake()
    {
        _controller = GetComponent<CharacterController2D>();
        
        _velocity = _controller.velocity;
    }

    public void Damage(int amount)
    {
        health -= amount;
        if (health <= 0) Kill();
    }

    public void FoundPlayer()
    {
        foundPlayer = true;
        _animator.Play("EnemyWalk", true);
    }

    public void Heal(int amount)
    {
        health += amount;
        if (health > maxHealth) health = maxHealth;
    }

    public void Kill()
    {
        _animator.Play("EnemyDeath");
        isDead = true;
        this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }

    public void Destroy()
    {
        Destroy(this.gameObject);
    }

    // Use this for initialization
    void Start () {
        // _animator.Play("EnemyIdle");
	}
	
	// Update is called once per frame
	void Update () {

        if (isDead)
        {
            _velocity.x = 0;
            _velocity.y = 0;
        }


        if (foundPlayer && !isDead) {
            if (transform.localScale.x < 0)
            {
                _velocity.x = walkSpeed;
            }
            else
            {
                _velocity.x = walkSpeed * -1;
            }
        }
        else
        {
            
            
        }

        if (!_controller.isGrounded && !isDead)
        {
            _velocity.y += gravity * Time.deltaTime;
        }
        else
        {
            _velocity.y = 0;
        }



        _velocity *= Time.deltaTime;
        _controller.move(_velocity);
        _velocity = _controller.velocity;
    }
}
