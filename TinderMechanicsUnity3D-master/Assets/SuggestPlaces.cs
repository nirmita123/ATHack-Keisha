using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuggestPlaces : MonoBehaviour
{

    private  String places;
    // Start is called before the first frame update
    void Start()
    {
        places = this.GetComponent<Text>().text;
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    void wheelchair()
    {
        places = "Loyal Nine \nThe Friendly Toast Restaurant\nCommonwealth\nMiddle East";
    }

    void blind()
    {
        places = "Boston Museum of Science \nFenway Park\nIsabella Stewart Gardner Museum";
    }

    void deaf()
    {
        places = "Fenway Park\nNew England Aquarium\nMassachussets State House";
    }
    void other()
    {
        places = "Boston Museum of Science \nNew England Aquarium\nhe Friendly Toast Restaurant";
    }
}
