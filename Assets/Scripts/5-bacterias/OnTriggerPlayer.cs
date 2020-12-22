using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class OnTriggerPlayer : MonoBehaviour
{

    [SerializeField] string triggeringTag_good;
    [SerializeField] string triggeringTag_bad;
    [SerializeField] string sceneName;

    [SerializeField] GameObject heartLeft;
    [SerializeField] GameObject heartRight;
    [SerializeField] GameObject heartMiddle;
    [SerializeField] public Text Score_Text = null;
    public static int Score = 0;



    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == triggeringTag_good)
        {
           
            Debug.Log(collision.gameObject.name);
            Destroy(collision.gameObject);
            Score = Score + 1;
            Score_Text.text = "Score:" + Score;
            Debug.Log("Score "+Score);
        }
        if (collision.tag == triggeringTag_bad)
        {

            if (heartLeft != null)
            {
                Destroy(heartLeft.gameObject);
            }
            else
            {
                if (heartMiddle != null)
                {
                    Destroy(heartMiddle.gameObject);
                }
                else
                {
                    if (heartRight != null)
                    {
                        Destroy(heartRight.gameObject);
                        Debug.Log(collision.gameObject.name);
                        Score = 0;
                        SceneManager.LoadScene(sceneName);
                    }
                }
            }
           
            

        }
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
