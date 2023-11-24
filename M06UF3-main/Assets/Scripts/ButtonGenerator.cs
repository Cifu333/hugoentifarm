using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject button;

    private int buttonCounter;

    private void Start()
    {
        buttonCounter = BaseDeDatos.Instance.plants.Count;
        for (int i = 0; i < buttonCounter; i++) 
        {
                GameObject temp = Instantiate(button, this.transform);
                temp.GetComponent<planteles>().SetId(i);


        }

    }


}
