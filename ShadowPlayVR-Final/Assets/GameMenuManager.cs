using UnityEngine;
using UnityEngine.SceneManagement; // ����SceneManager�����ռ�

public class SceneSwitcher : MonoBehaviour
{
    // ����������Ա���ť�ĵ���¼�����
    public void SwitchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName); // ����ָ�����Ƶĳ���
    }
}