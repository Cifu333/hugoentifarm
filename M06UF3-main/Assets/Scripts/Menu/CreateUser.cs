using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class createUser : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField InsertUserName;

    [SerializeField]
    private TMP_InputField InsertPasword;

    [SerializeField]
    private TMP_InputField InsertSecondPassword;

    [SerializeField]
    private TMP_Text error;


    public void CreateUser()
    {
        if (InsertUserName.text.Length > 12)
        {
            return;
        }
        if (InsertPasword.text != InsertSecondPassword.text)
        {
            return;
        }

       

        BaseDeDatos.Instance.NewUser(InsertUserName.text, InsertPasword.text);

        


        SceneManager.LoadScene(1);
    }


    //get md5 de la string
    



}
