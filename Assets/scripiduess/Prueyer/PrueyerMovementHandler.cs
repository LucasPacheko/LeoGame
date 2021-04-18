using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrueyerMovementHandler : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    [SerializeField] private float atrito;
    [SerializeField] private float threshold = 0.001f;
    private Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    private InputHandler inputHandler;
    void Start()
    {
        
    }
    private void Awake()
    {   
        inputHandler = GetComponent<InputHandler>();
        rigidbody2D =  GetComponent<Rigidbody2D>();
        rigidbody2D.inertia = atrito;
    }
    // Update is called once per frame
    void Update()
    {
        var movement = inputHandler.GetMovement() * Time.deltaTime * playerSpeed;
        
        rigidbody2D.velocity += movement ;
        if (rigidbody2D.velocity != Vector2.zero )
        {
            var directionAtrito = rigidbody2D.velocity;
            rigidbody2D.velocity -= (directionAtrito * atrito * Time.deltaTime);
        }
        if (rigidbody2D.velocity.magnitude < threshold)
        {
            rigidbody2D.velocity = Vector2.zero;
        }

        //transform.position += new Vector3(movement.x,movement.y) * Time.deltaTime * playerSpeed;

    }
}
