using UnityEngine;

public class NubeController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Este método se ejecuta cuando haces clic en la nube
    void OnMouseDown()
    {
        animator.SetTrigger("ReproducirAnimacion");
    }
}
