using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TransformAndVectors

{

    public class TransformOzellikleri : MonoBehaviour
    {
        public GameObject targetCube;

        public  BoxCollider[] boxColliders;

        public CubeController[] cubeControllers;

        private void Start()
        {

            //SetParent();

            GetChildOzellikleri();

        }

        private void Update()
        {

            //LookAt();

        }


        private void LookAt()

        {

            transform.LookAt(targetCube.transform);

        }

        private void SetParent()

        {

            //transform.SetParent(targetCube.transform);

            targetCube.transform.SetParent(transform);

        }

        private void GetChildOzellikleri()


        {

            //Debug.Log(transform.childCount);

            //Debug.Log(transform.GetChild(0).name);

            transform.GetChild(1).gameObject.SetActive(false);


            //for (int i = 0; i < transform.childCount; i++)  // Uzun yazým
            //{

            //    transform.GetChild(i).GetComponent<BoxCollider>().isTrigger = true;

            //    transform.GetChild(i).GetComponent<BoxCollider>().center += Vector3.one;

            //    Debug.Log(transform.GetChild(i).GetComponent<BoxCollider>().center);

            //    transform.GetChild(i).GetComponent<BoxCollider>().size *= 2;

            //    Debug.Log(transform.GetChild(i).GetComponent<BoxCollider>().size);

            //}

            //for (int i = 0; i < transform.childCount; i++)  // kýsa yazým
            //{
            //    BoxCollider boxCollider = transform.GetChild(i).GetComponent<BoxCollider>();

            //    boxCollider.isTrigger = true;

            //    boxCollider.size *= 2;

            //    boxCollider.center += Vector3.one;

            //    Debug.Log(boxCollider.center);

            //    Debug.Log(boxCollider.size);

            //}

            //foreach (var boxCollider in boxColliders)
            //{

            //    boxCollider.isTrigger = true;

            //}


            foreach (var cubeController in cubeControllers)
            {

                cubeController.cubeCount = 5;

            }

        }

    }

  

}
