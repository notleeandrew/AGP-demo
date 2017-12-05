using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachPoint : MonoBehaviour
{
    public Transform guide;
    public Collider trigger;

    void OnTriggerEnter(Collider collider)
    {
        Liftable liftable = collider.GetComponent<Liftable>();
        if (liftable != null && !liftable.IsAttached())
        {
            liftable.Attach(guide);
        }
    }
}
