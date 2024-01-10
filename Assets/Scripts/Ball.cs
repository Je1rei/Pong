using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private AudioManager audioManager;
    [SerializeField] private float _speed = 250.0f;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
        CheckVelocityX();
    }

    public void ResetPosition()
    {
        _rigidbody.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;
    }

    public void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : 
                                        Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * this._speed);
    }

    private void CheckVelocityX()
    {
        if (Mathf.Abs(_rigidbody.velocity.x) <= 0.1f)
        {
            Debug.Log("CheckVelocityX()");
            ResetPosition();
            AddStartingForce();
        }
    }
}
