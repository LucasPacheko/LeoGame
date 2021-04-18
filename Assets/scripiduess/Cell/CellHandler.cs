using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellHandler : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    [SerializeField] private float atrito;
    [SerializeField] private float threshold = 0.001f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.inertia = atrito;
    }

    // Update is called once per frame
    void Update()
    {
        if (rigidbody2D.velocity != Vector2.zero)
        {
            var directionAtrito = rigidbody2D.velocity;
            rigidbody2D.velocity -= (directionAtrito * atrito * Time.deltaTime);
        }
        if (rigidbody2D.velocity.magnitude < threshold)
        {
            rigidbody2D.velocity = Vector2.zero;
        }
    }
}
