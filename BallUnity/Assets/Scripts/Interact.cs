using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Root 
{
    public interface IInteractable 
    {
        bool IsInteractable { get; }
    }

    public  class Interact : MonoBehaviour, IInteractable
    {

        protected virtual void Interaction() 
        {

        }
        
        

        public bool IsInteractable { get; } = true;

        private void OnTriggerEnter(Collider other)
        {
            if (!IsInteractable || !other.CompareTag("Player"))
            {
                return;
            }
            Interaction();
            Destroy(gameObject);

        }
    }
}


