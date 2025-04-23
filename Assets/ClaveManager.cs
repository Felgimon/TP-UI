using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClaveManager : MonoBehaviour
{
    public TMP_InputField inputClave;
    public TMP_InputField inputUsuario;
    public TextMeshProUGUI txtMensaje;
    string clave = "clave123";
    string usuario = "Felipe";
    void Start()
    {
        txtMensaje.text = string.Empty;
    }

    public void VerificarClave()
    {
       if (inputClave.text != clave || inputUsuario.text != usuario)
       {
            txtMensaje.text = "Acceso denegado";
            inputClave.text = string.Empty;
            inputUsuario.text = string.Empty;
            return;
       } 
       txtMensaje.text = "Acceso otorgado";
    }
}
