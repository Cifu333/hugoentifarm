using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Terreno : MonoBehaviour
{
    private Button button;
    private Vector3 buttonPosition;
    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(GetButtonPosition);
    }
    public void GetButtonPosition()
    {
        buttonPosition = transform.position;
        Debug.Log("Button Position: X = " + buttonPosition.x + ", Y = " +
        buttonPosition.y);
    }
}