﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{
    [SerializeField] public Text set1 = null;
    [SerializeField] float Show_time = 2f;
    void Start()
    {

        StartCoroutine(ShowMessage(Show_time));

    }
    IEnumerator ShowMessage(float delay)
    {
        yield return new WaitForSeconds(delay);
        set1.text = "*Use the arrow keys to move\n * Navigate your gaze by moving the mouse\n*Collect as many good bacteria as possible and beware of the bad ones\n Good luck!";
        yield return new WaitForSeconds(delay*2);
        Destroy(set1);



    }


    // Update is called once per frame
    void Update()
    {

    }
}
