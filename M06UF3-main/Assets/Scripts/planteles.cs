using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class planteles : MonoBehaviour
{
    [SerializeField]
    private int id_plant;
    [SerializeField]
    private TMP_Text plantboton;
    [SerializeField]
    private TMP_Text quantityplant;

    private void Start()
    {
        quantityplant.text = BaseDeDatos.Instance.plants[id_plant].quantity.ToString();
        plantboton.text = BaseDeDatos.Instance.plants[id_plant].plantname;
    }

}
