using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginUser : MonoBehaviour
{
    // Start is called before the first frame update

    private List<users> user = new List<users>();




    [SerializeField]
    private TMP_InputField InsertUser;
    [SerializeField]
    private TMP_InputField InsertPasword;

    [SerializeField]
    private GameObject errorEntrada;

    private int player_identification;

    private string data;
    void Start()
    {
        user = BaseDeDatos.Instance.GetUsers();

    }




    // Update is called once per frame


    public void checkUser()
    {
       

       
        for (int i = 0; i < user.Count; i++)
        {

            Debug.Log(user[i].name);

            if (user[i].name == InsertUser.text)
            {
               

                if (user[i].password == InsertPasword.text)
                {
                    player_identification = user[i].id_user;

                 
                    SceneManager.LoadScene(0);
                }
                else
                {
                    errorEntrada.SetActive(true);
                    InsertUser.text = "";
                    InsertPasword.text = "";
                    Debug.Log("password error");
                }
            }

        }
       
        InsertUser.text = "";
        InsertPasword.text = "";


    }

 
   

}
