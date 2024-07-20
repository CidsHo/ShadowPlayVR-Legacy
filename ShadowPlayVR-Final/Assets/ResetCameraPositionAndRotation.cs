using UnityEngine;

public class ResetCameraPositionAndRotation : MonoBehaviour
{
    public Camera targetCamera; // 指向要重置的摄像机
    private Vector3 initialPosition; // 存储初始位置
    private Quaternion initialRotation; // 存储初始旋转

    void Start()
    {
        // 在游戏开始时记录摄像机的初始位置和旋转
        if (targetCamera != null)
        {
            initialPosition = targetCamera.transform.position;
            initialRotation = targetCamera.transform.rotation;
        }
    }

    // 调用这个方法来重置摄像机的位置和旋转
    public void ResetCamera()
    {
        if (targetCamera != null)
        {
            targetCamera.transform.position = initialPosition;
            targetCamera.transform.rotation = initialRotation;
        }
    }
}
