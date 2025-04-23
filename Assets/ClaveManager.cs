using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClaveManager : MonoBehaviour
{
    public TMP_InputField inputClave;
    public TextMeshProUGUI txtMensaje;
    string clave = "clave123";
    void Start()
    {
        txtMensaje.text = string.Empty;
    }

    public void VerificarClave()
    {
       if (inputClave.text != clave)
       {
            txtMensaje.text = "Acceso denegado";
            inputClave.text = string.Empty;
            return;
       } 
       txtMensaje.text = "Facturas bro";
    }
}
