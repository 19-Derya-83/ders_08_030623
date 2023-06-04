using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace InstantiateOrnkleri

{

    public class Bullet : MonoBehaviour
    {
        public float speed;


        private void Update()
        {
            //if (transform.position.z > 100)
            //{

            //    Destroy(gameObject);

            //}

            Move();

        }

        public void Move()
        {

            transform.position += Vector3.forward * (Time.deltaTime * speed);

        }

        public void DestroyBullet()

        {

            Destroy(gameObject, 2);

        }

    }

}