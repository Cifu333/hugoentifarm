using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class planteles : MonoBehaviour
{
    public GameManager manager = new GameManager();

    [SerializeField]
    private int id_plant;
    [SerializeField]
    private TMP_Text plantboton;
    [SerializeField]
    private TMP_Text quantityplant;
    [SerializeField]
    private TMP_Text currentplants;

    private int currentplantsPlant;

    private void Start()
    {
        currentplantsPlant = BaseDeDatos.Instance.plants[id_plant].quantity;

        quantityplant.text = BaseDeDatos.Instance.plants[id_plant].quantity.ToString();
        plantboton.text = BaseDeDatos.Instance.plants[id_plant].plantname;
    }

    private void Update()
    {
        currentplants.text= currentplantsPlant.ToString();
    }

    public void GetId()
    {
        manager.SetId(id_plant);
        currentplantsPlant--;

    }


    public void SetId(int id)
    {
        id_plant = id;

    }

}
