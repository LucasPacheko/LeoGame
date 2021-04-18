using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellTriggerHandler : MonoBehaviour
{
    private bool isActive = false;
    [SerializeField] private SpriteRenderer border;
    // Start is called before the first frame update
    public void Change()
    {
        isActive = !isActive;
        border.enabled = isActive;
    }
    public void Active()
    {
        isActive = true;
        border.enabled = isActive;
    }
    public void Deactive()
    {
        isActive = false;
        border.enabled = isActive;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
