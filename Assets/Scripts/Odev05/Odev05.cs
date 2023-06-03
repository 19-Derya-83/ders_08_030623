using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Soru1 - Bir cube oluþturup içine attýðýmýz bir script ile cube’nin boxcolliderinin isTrigger deðerini true, radius deðerini 2 yapýnýz ve bu deðerleri consola yazdýrýnýz.

//Soru2- Soru1 deki objeye bir Rigidbody componenti ekleyip ayný scriptten bu Rigidbody compenentine ulaþýp mass deðerini 10, drag deðerini 5 yapýnýz ve konsolda gösteriniz.

//Soru3- Yeni bir obje oluþturup bu objenin altýna 10 adet child obje oluþturunuz. 
//Child objelerimize rigidbody ekleyelim ve parent objemize attýðýmýz script ile child objelerimizdeki rigidbodyleri bir dizinin içine alalým. 
//Dizideki bütün rigidbodylerin usegravity deðerini false yapalým.

//Soru4- 2 ayrý objemiz olsun. Birinde bizim yazdýðýmýz bir script olsun diðerinde ise SphereCollider olsun. 
//Kendi yazdýðýmýz script ile diðer objede var olan SphereCollidera ulaþýp isTrigger deðerini true, radius deðerini 3 yapalým.

//Soru5- 2 ayrý objemiz ve her ikisine attýðýmýz 2 ayrý scriptimiz olsun. Bu iki scripte int, string ve bool deðiþkenler ve bu deðiþkenlerle alakalý metot oluþturalým. 
//En son bu objelerden birbirine ve birbirinin içindeki scriptlere ulaþýp deðiþkenlerin deðerlerini deðiþtirelim. 
//Ve metotlarýný kullanýp consola deðiþtirdiðimiz deðiþkenleri yazalým.

namespace Odev05

{
    public class Odev05 : MonoBehaviour
    {

        private BoxCollider _boxCollider;

        private Rigidbody _rigidbody;

        private Rigidbody[] _rigidbodies;

        private SphereCollider _sphereCollider;

        private void Awake()  // Keþleme iþlemlerini ( Newleme - yakalama iþlemi ) Awake metodunda yaparýz. // Awake, start tan önce çalýþýr, o yüzden keþleme iþlemleri bu metotta yapýlýr.
        {

            _boxCollider = GetComponent<BoxCollider>();

            _rigidbody = GetComponent<Rigidbody>();

            _rigidbodies = GetComponentsInChildren<Rigidbody>();

            _sphereCollider = GameObject.FindGameObjectWithTag("Sphere").GetComponent<SphereCollider>();

        }

        private void Start()  // Oyun baþlar baþlamaz çalýþacak bir metod varsa Start metodunda bu metodlarý çalýþtýrýrýz.
        {

            //ChangeBoxCollider();

            //ChangeRigidbody();

            //RigidbodyChangeUseGravity();

            ChangeSphere();


            //GetComponent<BoxCollider>().isTrigger = true;  // Uzun yazýmý
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
