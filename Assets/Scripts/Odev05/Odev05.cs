using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Soru1 - Bir cube olu�turup i�ine att���m�z bir script ile cube�nin boxcolliderinin isTrigger de�erini true, radius de�erini 2 yap�n�z ve bu de�erleri consola yazd�r�n�z.

//Soru2- Soru1 deki objeye bir Rigidbody componenti ekleyip ayn� scriptten bu Rigidbody compenentine ula��p mass de�erini 10, drag de�erini 5 yap�n�z ve konsolda g�steriniz.

//Soru3- Yeni bir obje olu�turup bu objenin alt�na 10 adet child obje olu�turunuz. 
//Child objelerimize rigidbody ekleyelim ve parent objemize att���m�z script ile child objelerimizdeki rigidbodyleri bir dizinin i�ine alal�m. 
//Dizideki b�t�n rigidbodylerin usegravity de�erini false yapal�m.

//Soru4- 2 ayr� objemiz olsun. Birinde bizim yazd���m�z bir script olsun di�erinde ise SphereCollider olsun. 
//Kendi yazd���m�z script ile di�er objede var olan SphereCollidera ula��p isTrigger de�erini true, radius de�erini 3 yapal�m.

//Soru5- 2 ayr� objemiz ve her ikisine att���m�z 2 ayr� scriptimiz olsun. Bu iki scripte int, string ve bool de�i�kenler ve bu de�i�kenlerle alakal� metot olu�tural�m. 
//En son bu objelerden birbirine ve birbirinin i�indeki scriptlere ula��p de�i�kenlerin de�erlerini de�i�tirelim. 
//Ve metotlar�n� kullan�p consola de�i�tirdi�imiz de�i�kenleri yazal�m.

namespace Odev05

{
    public class Odev05 : MonoBehaviour
    {

        private BoxCollider _boxCollider;

        private Rigidbody _rigidbody;

        private Rigidbody[] _rigidbodies;

        private SphereCollider _sphereCollider;

        private void Awake()  // Ke�leme i�lemlerini ( Newleme - yakalama i�lemi ) Awake metodunda yapar�z. // Awake, start tan �nce �al���r, o y�zden ke�leme i�lemleri bu metotta yap�l�r.
        {

            _boxCollider = GetComponent<BoxCollider>();

            _rigidbody = GetComponent<Rigidbody>();

            _rigidbodies = GetComponentsInChildren<Rigidbody>();

            _sphereCollider = GameObject.FindGameObjectWithTag("Sphere").GetComponent<SphereCollider>();

        }

        private void Start()  // Oyun ba�lar ba�lamaz �al��acak bir metod varsa Start metodunda bu metodlar� �al��t�r�r�z.
        {

            //ChangeBoxCollider();

            //ChangeRigidbody();

            //RigidbodyChangeUseGravity();

            ChangeSphere();


            //GetComponent<BoxCollider>().isTrigger = true;  // Uzun yaz�m�
            //Debug.Log(GetComponent<BoxCollider>().isTrigger);

        }


        private void ChangeBoxCollider()   

        {

            _boxCollider.isTrigger = true;
            Debug.Log(_boxCollider.isTrigger);

        }

        private void ChangeRigidbody()

        {
            _rigidbody.mass = 10;
            _rigidbody.drag = 2;

            Debug.Log("Mass :" + _rigidbody.mass);
            Debug.Log("Drag :" +_rigidbody.drag);

        }

        private void RigidbodyChangeUseGravity()

        {

            foreach (var rigidbody1 in _rigidbodies)
            {

                rigidbody1.useGravity = false;
                rigidbody1.isKinematic = true;

            }

        }

        private void ChangeSphere()

        {

            _sphereCollider.radius = 3;
            _sphereCollider.isTrigger = true;

        }

    }

}
