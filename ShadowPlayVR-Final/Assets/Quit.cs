using UnityEngine;

public class ExitApplication : MonoBehaviour
{
    // ����������ڰ�ť���ʱ������
    public void QuitApplication()
    {
        // �ڱ༭����
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // �ڹ�����Ӧ����
        Application.Quit();
#endif
    }
}
