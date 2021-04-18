using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerHadler : MonoBehaviour
{
    [SerializeField] private GameObject spawnable;
    [SerializeField] private float bounds;
    [SerializeField] private int itensToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = itensToSpawn; i>=0; i--)
        {
            
            var vector2d = new Vector2(Random.Range(-bounds, bounds), Random.Range(-bounds, bounds));
            var item = Instantiate(spawnable, vector2d, Quaternion.identity, transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
