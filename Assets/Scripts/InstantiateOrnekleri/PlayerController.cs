using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InstantiateOrnkleri

{

    public class PlayerController : MonoBehaviour
    {

        //public GameObject bullet;

        public Bullet bullet;

        private float _gameTime;

        [SerializeField]private float _repeatTime;

        private void Start()
        {

           // CreatBullet();

        }

        private void Update()
        {

            _gameTime += Time.deltaTime;

            Debug.Log(_gameTime);

            if (_gameTime > _repeatTime)
            {

                CreatBullet();

                _gameTime = 0;

            }

        }

        public void CreatBullet()

        {

            //Instantiate(bullet, transform.position, Quaternion.identity);

            //GameObject newBullet = Instantiate(bullet, transform.position, Quaternion.identity);

            //newBullet.GetComponent<Bullet>().DestroyBullet();


            Bullet newBullet = Instantiate(bullet, transform.position, Quaternion.identity);

            newBullet.DestroyBullet();

        }

    }


}
