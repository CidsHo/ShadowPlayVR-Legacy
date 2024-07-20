using UnityEngine;

public class ResetCameraPositionAndRotation : MonoBehaviour
{
    public Camera targetCamera; // ָ��Ҫ���õ������
    private Vector3 initialPosition; // �洢��ʼλ��
    private Quaternion initialRotation; // �洢��ʼ��ת

    void Start()
    {
        // ����Ϸ��ʼʱ��¼������ĳ�ʼλ�ú���ת
        if (targetCamera != null)
        {
            initialPosition = targetCamera.transform.position;
            initialRotation = targetCamera.transform.rotation;
        }
    }

    // ������������������������λ�ú���ת
    public void ResetCamera()
    {
        if (targetCamera != null)
        {
            targetCamera.transform.position = initialPosition;
            targetCamera.transform.rotation = initialRotation;
        }
    }
}
