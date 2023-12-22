using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPlant : MonoBehaviour
{

    public void SelectPlantToPlant(int idPlatn)
    {
        GameManager.Instance.id_clicked=idPlatn;
    }

}