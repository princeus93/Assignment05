using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WordDestroyer : MonoBehaviour
{
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("wordDestroyer"))
            {
                Destroy(gameObject);
           
            }
        }

}
