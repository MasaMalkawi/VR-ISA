using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Gun : MonoBehaviour
{
    XRGrabInteractableFixed xRGrabInteractableFixed;

    [SerializeField] Transform spawnPoint;
    [SerializeField] GameObject ProjectilPreafab;

    private void Awake()
    {
        xRGrabInteractableFixed = GetComponent<XRGrabInteractableFixed>();
    }
    void Start()
    {
        xRGrabInteractableFixed.activated.AddListener(Shoot);
    }

    void Shoot(ActivateEventArgs args)
    {
        Instantiate(ProjectilPreafab, spawnPoint.position , spawnPoint.rotation);
    }
    private void OnDestroy()
    {
        xRGrabInteractableFixed.activated.RemoveListener(Shoot);
    }

}
