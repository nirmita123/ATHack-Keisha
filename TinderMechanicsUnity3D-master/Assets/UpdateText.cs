using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{
    public Text text_sent;

    public Text text_enter;


    // Start is called before the first frame update
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        text_sent.text = text_enter.text;
    }
    
}
