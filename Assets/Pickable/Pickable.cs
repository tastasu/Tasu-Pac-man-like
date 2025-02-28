using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    [SerializeField]
    public PickableType PickableType;
    public Action<Pickable> OnPicked;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
         
            OnPicked(this);
            Destroy(gameObject);
        }
        
    }
    
}
