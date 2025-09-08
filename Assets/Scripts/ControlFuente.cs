using UnityEngine;
using TMPro;

public class ControlFuente : MonoBehaviour
{
    public TMP_Text titulo;

    public void CambiarFuente()
    {
        titulo.fontSize += 5; // aumenta el tamaño
        titulo.text = "Texto modificado!";
    }
}
