using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Odev05

{

    public class Player : MonoBehaviour
    {

        public string name;
        public int health;
        public int power;
        public bool isDead;

        public void DoAttack()

        {



        }

        public void TakeDamege( int damage)

        {

            health -= damage;

            if (health <= 0)
            {

                Debug.Log("Öldünüz");
                isDead = true;

            }

        }

    }

}
