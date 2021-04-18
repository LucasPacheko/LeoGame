using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCellContact : MonoBehaviour
{
    [SerializeField] private LayerMask cellMask;
    [SerializeField] private float raioBusca =1.7f;
    private CellTriggerHandler lastAtivated = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        var vizins= Physics2D.CircleCastAll(transform.position, raioBusca, Vector2.one, 0, cellMask);
        var distante = Mathf.Infinity;
        CellTriggerHandler mostClosest = null;
        foreach (var item in vizins)
        {
            var distAtual = Vector3.Distance(transform.position, item.transform.position);
            if (distAtual < distante)
            {
                mostClosest = item.transform.GetComponent<CellTriggerHandler>();
                distante = distAtual;
            } 
           
        }
            
        
         lastAtivated?.Deactive();
         mostClosest?.Active();
         lastAtivated = mostClosest;
        
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position,raioBusca);
    }
}
