using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Root
{

    public class FirstPersonScript : CameraController
    {
        public Camera firstPerson;
        public Camera overhead;

        public void OverheadShow()
        {
            firstPerson.enabled = false;
            overhead.enabled = true;
        }
        public void FirstPersonShow()
        {
            overhead.enabled = false;
            firstPerson.enabled = true;
        }
        void Update()
        {

            if (Input.GetButtonDown("Jump"))
            {
                firstPerson.enabled = false;
                overhead.enabled = true;
            }
            if (Input.GetButtonDown("Fire1"))
            {
                overhead.enabled = false;
                firstPerson.enabled = true;
            }
        }
    }
}