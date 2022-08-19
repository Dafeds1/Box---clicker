using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject _firstPoint;

    private GameObject _obstacle;

    private bool _isReverce = false;

        
    void Update()
    {
        Movement();
        if (Input.GetMouseButtonDown(0))
        {
            _isReverce = !_isReverce;
        }
    }
    public void Movement()
    {
        transform.rotation *= Quaternion.Euler(0f,0f,1f);
        _firstPoint = GameObject.FindGameObjectWithTag("Point");
        if (_isReverce == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, _firstPoint.transform.position, Time.deltaTime * 3f);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, _firstPoint.transform.position, -Time.deltaTime * 3f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "LowerBlock" || collision.gameObject.name == "UpperBlock")
        {
            _isReverce = !_isReverce;
        }
        if (collision.gameObject == _obstacle)
        {
            Destroy(gameObject);
        }
    }
}
