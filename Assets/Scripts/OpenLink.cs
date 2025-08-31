using UnityEngine;

public class OpenLink : MonoBehaviour
{
    [SerializeField] private string url;

    public void Abrir()
    {
        Application.OpenURL(url);
    }
}
