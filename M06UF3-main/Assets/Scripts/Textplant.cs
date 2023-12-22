using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlantSelectedText : MonoBehaviour
{
    private int id_Plant;
    [SerializeField] private TMP_Text plantName;

    void Update()
    {
        id_Plant = GameManager.Instance.id_clicked;

        if (id_Plant >= 0)
        {
            plantName.text = BaseDeDatos.Instance.plants[id_Plant].plantname;
        }
        else if (id_Plant < 0)
        {
            plantName.text = "";
        }



    }
}