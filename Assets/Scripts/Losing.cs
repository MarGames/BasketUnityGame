using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Losing : MonoBehaviour
{
    public GameObject U;
    public GameObject reload;
    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.tag == "Player")
        {
            U.SetActive(true);
            reload.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void Reload()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1f;
    }
}
