using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour // 57
{
    protected Rigidbody2D _rigidbody;
    protected float speed;
    protected float _defaultScaleY;
    protected bool _isActivatedChange;

    private void Awake()
    {
        _defaultScaleY = this.transform.localScale.y - 0.5f;
        _rigidbody = GetComponent<Rigidbody2D>();
        _isActivatedChange = false;
    }

    public void ResetPosition()
    {
        _rigidbody.position = new Vector2(_rigidbody.position.x, 0.0f);
        _rigidbody.velocity = Vector2.zero;
    }

    public void ChangePaddleLength(float score, bool isActivated, float step)
    {
        if (isActivated && this.transform.localScale.y > _defaultScaleY)
        {
            Vector3 newScale = this.transform.localScale;
            newScale.y += step;
            this.transform.localScale = newScale;

            BoxCollider boxCollider = GetComponent<BoxCollider>(); // Получаем компонент Box Collider

            if (boxCollider != null)
            {
                boxCollider.size = new Vector3(boxCollider.size.x, newScale.y, boxCollider.size.z);
            }

            isActivated = false;

        }
    }

    public void ResetScaleY()
    {
        Vector3 newScale = this.transform.localScale;
        newScale.y = _defaultScaleY + 0.5f;
        this.transform.localScale = newScale;
    }
}
