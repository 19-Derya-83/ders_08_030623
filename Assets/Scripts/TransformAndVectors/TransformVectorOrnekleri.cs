using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TransformAndVectors

{

    public class TransformVectorOrnekleri : MonoBehaviour
    {

        public Vector3 rotation;  //Global deðiþken larak da tanýmlanabilir.

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

            #region Vector 3 oluþturma

            //Vector3 newVector3 = new Vector3(2, 3, 4); // Float deðerler alýr.
            ////Vector3Int newVector3Int = new Vector3Int(1,2f , 0, 2);  sadece int deðerler alýr.

            //Debug.Log(newVector3);
            //Debug.Log(newVector3.x);
            //Debug.Log(newVector3.y);
            //Debug.Log(newVector3.z);

            #endregion

            #region transform.position Vector 3 oluþturma

            //transform.position = newVector3; // üstteki newleme de eþitlenebilir.

            //transform.position = new Vector3(2, 0, 5); // yeni newleme de yapýlabilir.

            //transform.position = new Vector3 ( 2, transform.position.y, transform.position.z);
            //transform.position = new Vector3 ( transform.position.x, 5, transform.position.z);
            //transform.position = new Vector3 ( transform.position.x, transform.position.y, 10);

            #endregion

            #region transform.rotation Vector 3 oluþturma

            //transform.eulerAngles = new Vector3(90, 0, 0);

            transform.eulerAngles = rotation;  // yukarýda vermiþ olduðumuz public rptation deðiþkene de þitlenebilir.

            #endregion

            #region transform.scale Vector 3 oluþturma

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

            // 30 * 1/30 = 60 * 1/60 Time.deltatime cihazlar eþitlenmiþ oluyor, her cihazda ayný çalýþacak.

            Debug.Log(Time.deltaTime);

            transform.position += new Vector3(0, 0, 1) * (speed * Time.deltaTime); // New li yazým
            transform.position += Vector3.forward * (speed * Time.deltaTime); // forward lý yazým
            transform.position += Vector3.back * (speed * Time.deltaTime);

            transform.Translate(Vector3.forward * (speed * Time.deltaTime)); //transform.position + - siz yazýmý

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

            float mesafe = Vector3.Distance(transform.position, cube2.position); //transform ile yazýmý

            //float mesafe2 = Vector3.Distance(transform.position, cube2New.transform.position);  // gameobject ile yazýmý

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