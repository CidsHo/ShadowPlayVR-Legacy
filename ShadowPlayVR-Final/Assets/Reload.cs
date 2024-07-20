using UnityEngine;
using UnityEngine.SceneManagement; // 引入SceneManager命名空间

public class ResetScene : MonoBehaviour
{
    // 这个方法将重新加载当前激活的场景
    public void ReloadCurrentScene()
    {
        // 获取当前场景的名称
        string currentSceneName = SceneManager.GetActiveScene().name;

        // 重新加载当前场景
        SceneManager.LoadScene(currentSceneName);
    }
}