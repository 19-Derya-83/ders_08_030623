using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TransformAndVectors

{

    public class TransformVectorOrnekleri : MonoBehaviour
    {

        public Vector3 rotation;  //Global de�i�ken larak da tan�mlanabilir.

        public float speed;
        public float rotateSpeed;
        public float scaleSpeed;

        [SerializeField] private Transform cube2;
        [SerializeField] private GameObject cube2New;

        [SerializeField] private float lerpSpeed;

        private void Start()
        {

            //TransformChange(); 

            
        }


        private void Update()
        {

            //Move();

            //Rotate();

            //Scale();

            //Distance();

            //Lerp();
            
        }

        private void TransformChange()

        {

            #region Vector 3 olu�turma

            //Vector3 newVector3 = new Vector3(2, 3, 4); // Float de�erler al�r.
            ////Vector3Int newVector3Int = new Vector3Int(1,2f , 0, 2);  sadece int de�erler al�r.

            //Debug.Log(newVector3);
            //Debug.Log(newVector3.x);
            //Debug.Log(newVector3.y);
            //Debug.Log(newVector3.z);

            #endregion

            #region transform.position Vector 3 olu�turma

            //transform.position = newVector3; // �stteki newleme de e�itlenebilir.

            //transform.position = new Vector3(2, 0, 5); // yeni newleme de yap�labilir.

            //transform.position = new Vector3 ( 2, transform.position.y, transform.position.z);
            //transform.position = new Vector3 ( transform.position.x, 5, transform.position.z);
            //transform.position = new Vector3 ( transform.position.x, transform.position.y, 10);

            #endregion

            #region transform.rotation Vector 3 olu�turma

            //transform.eulerAngles = new Vector3(90, 0, 0);

            transform.eulerAngles = rotation;  // yukar�da vermi� oldu�umuz public rptation de�i�kene de �itlenebilir.

            #endregion

            #region transform.scale Vector 3 olu�turma

            //transform.localScale = new Vector3(2, 5, 7);

            #endregion

        }

        private void Vector3OzelTanimliDegerler()

        {
            Debug.Log(Vector3.zero);
            transform.position = Vector3.zero;  // new Vector3(0, 0, 0);

            Debug.Log(Vector3.one);
            Debug.Log(Vector3.right);
            Debug.Log(Vector3.left);
            Debug.Log(Vector3.forward);
            Debug.Log(Vector3.back);
            Debug.Log(Vector3.up);
            Debug.Log(Vector3.down);

        }

        private void Move ()

        {

            // 30 * 1/30 = 60 * 1/60 Time.deltatime cihazlar e�itlenmi� oluyor, her cihazda ayn� �al��acak.

            Debug.Log(Time.deltaTime);

            transform.position += new Vector3(0, 0, 1) * (speed * Time.deltaTime); // New li yaz�m
            transform.position += Vector3.forward * (speed * Time.deltaTime); // forward l� yaz�m
            transform.position += Vector3.back * (speed * Time.deltaTime);

            transform.Translate(Vector3.forward * (speed * Time.deltaTime)); //transform.position + - siz yaz�m�

        }

        private void Rotate ()

        {

            transform.Rotate(Vector3.right * (rotateSpeed * Time.deltaTime));

        }

        private void Scale()

        {

            transform.localScale += Vector3.one * (scaleSpeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.A))
            {

                transform.localScale += Vector3.one * (scaleSpeed * Time.deltaTime);

            }

            if (Input.GetKey(KeyCode.B))
            {

                transform.localScale -= Vector3.one * (scaleSpeed * Time.deltaTime);

            }

        }

        private void Distance()

        {

            if (!cube2.gameObject.activeInHierarchy) 

            {

                return;

            }

            float mesafe = Vector3.Distance(transform.position, cube2.position); //transform ile yaz�m�

            //float mesafe2 = Vector3.Distance(transform.position, cube2New.transform.position);  // gameobject ile yaz�m�

            Debug.Log("Mesafemiz : " + mesafe);

            if (mesafe < 2)
            {

                cube2.gameObject.SetActive(false);

                //cube2New.SetActive(false);

            }

        }

        private void Lerp()

        {

           transform.position = Vector3.Lerp(transform.position, cube2.position, lerpSpeed * Time.deltaTime);

        }

    }

}