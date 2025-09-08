using UnityEngine;
using UnityEngine.SceneManagement;

public class Navegacion : MonoBehaviour
{
    public void IrAEscena2()
    {
        SceneManager.LoadScene("Escena2");
    }

    public void VolverAEscena1()
    {
        SceneManager.LoadScene("EscenaUnidad2");
    }
}
