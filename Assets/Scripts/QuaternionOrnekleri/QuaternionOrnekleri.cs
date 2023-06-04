using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuaternionOrnekleri

{

    public class QuaternionOrnekleri : MonoBehaviour
    {

        [SerializeField] private GameObject cubeObject;

        private void Start()
        {

            //Changerotation(); 

        }

        private void Update()
        {

            //LookRotation();

           // Angle();

        }

        private void Changerotation()

        {

            //transform.eulerAngles = new Vector3(0, 180, 0);

            transform.rotation = Quaternion.Euler(0, 180, 0);

            transform.rotation = Quaternion.identity;

        }


        private void LookRotation()

        {

            transform.rotation = Quaternion.LookRotation(cubeObject.transform.position - transform.position);

            //transform.LookAt(cubeObject.transform);
                

        }


        private void Angle ()

        {

           float angle = Quaternion.Angle(transform.rotation, cubeObject.transform.rotation);

           Debug.Log("Angle : " + angle);

        }
    }

}
