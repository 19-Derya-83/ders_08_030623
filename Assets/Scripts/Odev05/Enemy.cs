using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Odev05

{
    public class Enemy : MonoBehaviour
    {

        [SerializeField] private Player player; // [SerializeField] private olan player field imizi inspector de görmemeizi saðlar.

        //[SerializeField] private Player _player;


        private void Start()
        {

            player.TakeDamege(20);

            //_player = GameObject.Find("Player").GetComponent<Player>();

            //_player.TakeDamege(20);
        }

    }

}
