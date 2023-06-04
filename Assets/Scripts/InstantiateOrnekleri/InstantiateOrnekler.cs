using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace InstantiateOrnkleri

{

    public class InstantiateOrnekler : MonoBehaviour
    {

        public GameObject cube;

        private void Start()
        {

            //RandomOrnek();

            //InstantiateOrnekMethod();

            //ObjeYakalama();


        }

        private void Update()
        {

            if (Input.GetMouseButtonDown(0)) 
            {

                //RandomOrnek();

            }

            //RandomOrnek();

        }


        private void RandomOrnek()

        {

           float index = Random.Range(0, 5f);

            Debug.Log("index : " + index);

        }

        private void InstantiateOrnekMethod()
        {

            //Instantiate(cube); // Instantiate en basit kullanýmý

            //Instantiate(cube, new Vector3 (3, 7, 10), Quaternion.identity);

            //Instantiate(cube, transform.position, Quaternion.identity);

            //Instantiate(cube, 
            //    new Vector3( transform.position.x-2, transform.position.y-3, transform.position.z ), 
            //    Quaternion.identity);

            //for (int i = 0; i < 5; i++)
            //{

            //    Instantiate(cube, new Vector3(3, 7, 10), Quaternion.identity);

            //}

            //for (int i = 0; i < 5; i++)
            //{

            //    Instantiate(cube, 
            //        new Vector3(Random.Range(-5f, 5f), Random.Range(-5, 5f), Random.Range(-5, 5f)), 
            //        Quaternion.identity);

            //}

            //for (int i = 0; i < Random.Range(100, 1000); i++)
            //{

            //    Instantiate(cube,
            //        new Vector3(Random.Range(-50f, 50f), Random.Range(-50, 50f), Random.Range(-50, 50f)),
            //        Quaternion.identity, transform);

            //}

            for (int i = 0; i < Random.Range(10, 100); i++)
            {

                Instantiate(cube,
                    new Vector3( 5, Random.Range(-50, 50f), Random.Range(-50, 50f)),
                    Quaternion.identity, transform);

            }

            Debug.Log(transform.childCount);

        }

        private void ObjeYakalama()

        {

           GameObject newCube =  Instantiate(cube, transform.position, transform.rotation);

            //cube.transform.position = Vector3.one * 5; // yanlýþ bir yöntem.

            newCube.transform.position = Vector3.one *5;

            newCube.GetComponent<Rigidbody>().isKinematic = true;

        }

    }

}