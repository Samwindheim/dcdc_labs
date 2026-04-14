using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MarbleResetXR : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    Vector3 m_StartPosition;
    Quaternion m_StartRotation;

    void Awake ()
    {
        m_Rigidbody = GetComponent<Rigidbody> ();
        m_StartPosition = transform.position;
        m_StartRotation = transform.rotation;
    }

    public void ResetMarble ()
    {
        m_Rigidbody.linearVelocity = Vector3.zero;
        m_Rigidbody.angularVelocity = Vector3.zero;
        m_Rigidbody.position = m_StartPosition;
        m_Rigidbody.rotation = m_StartRotation;
        m_Rigidbody.Sleep ();
        Physics.SyncTransforms ();
    }
}
