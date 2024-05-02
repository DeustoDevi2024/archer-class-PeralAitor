using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Archer
{

    public class Enemy : MonoBehaviour, IScoreProvider
    {
        public GameObject gm;
        //private int numBat;

        // Hacer una lista estatica de enemigos, cada vez que se instancie una so añade a la lista, y cada vez que se mata a uno se elimina de la lista, cuando haya 0 se vuelve a empezar AppLogic.LoadGame().

        // Cuántas vidas tiene el enemigo
        [SerializeField]
        private int hitPoints;
        private AppLogic app;

        private Animator animator;

        public event IScoreProvider.ScoreAddedHandler OnScoreAdded;

        private void Awake()
        {
            animator = GetComponent<Animator>();
            //numBat = 5;
        }

        void DieCount()
        //IEnumerator DieCount()
        {
            gm.transform.rotation *= Quaternion.Euler(180, 0, 0);
            //yield return new WaitForSeconds(0.3f);
            //gm.transform.rotation *= Quaternion.Euler(180, 0, 0);
            //numBat = numBat - 1;
            //Debug.Log(numBat);
            //if (numBat == 0)
            //{
            //    app.LoadGame();
            //}
        }

        // Método que se llamará cuando el enemigo reciba un impacto
        public void Hit()
        {
            hitPoints--;
            if (hitPoints == 0)
            {
                //StartCoroutine(DieCount());
                DieCount();
                Die();
            }
        }

        private void Die()
        {
            Destroy(this.gameObject);
        }



    }

}