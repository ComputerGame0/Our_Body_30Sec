using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevel : MonoBehaviour
{
    [SerializeField] string sceneName;
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == triggeringTag)
        {
            Debug.Log("player");
            SceneManager.LoadScene(sceneName);
        }
    }
}