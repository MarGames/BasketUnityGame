using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.tag == "cubes")
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("Main");
        }
    }
}
