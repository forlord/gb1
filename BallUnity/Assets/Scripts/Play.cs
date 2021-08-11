using UnityEngine;

namespace Root
{
    public class Play : MonoBehaviour
    {
        public float Speed = 70.0f;
        public Rigidbody _rigidbody;
        void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

       protected void Movement()
        {
            float Horizontal = Input.GetAxis("Horizontal");
            float Vertical = Input.GetAxis("Vertical");

            Vector3 move = new Vector3(Horizontal, 0.0f, Vertical);

            _rigidbody.AddForce(move * Speed);

        }
        
    }
}
 
