using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int id_clicked;

    // Update is called once per frame
    public void SetId(int id)
    {
        id_clicked = id;
    }
}
