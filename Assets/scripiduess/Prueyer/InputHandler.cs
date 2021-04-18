using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private PlayerInput playerInput;
    // Start is called before the first frame update
    void Start()
    {
        print("VAI COMECAR A PUT*RIA");
    }
    private void Awake()
    {
        playerInput = new PlayerInput();
        print("AWAKEN AWAKEN AWAKEN AWAKEN AWAKEN AWAKEN");
    }
    // Update is called once per frame
    private void OnEnable()
    {
        playerInput.Enable();
        print("TA LIBERADO!!!");
    }
    private void OnDisable()
    {
        playerInput.Disable();
    }
    void Update()

    {
        
    }
    public Vector2 GetMovement()
    {
        return playerInput.Terrain.Movement.ReadValue<Vector2>();
    }
}
