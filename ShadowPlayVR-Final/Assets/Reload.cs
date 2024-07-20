using UnityEngine;
using UnityEngine.SceneManagement; // ����SceneManager�����ռ�

public class ResetScene : MonoBehaviour
{
    // ������������¼��ص�ǰ����ĳ���
    public void ReloadCurrentScene()
    {
        // ��ȡ��ǰ����������
        string currentSceneName = SceneManager.GetActiveScene().name;

        // ���¼��ص�ǰ����
        SceneManager.LoadScene(currentSceneName);
    }
}