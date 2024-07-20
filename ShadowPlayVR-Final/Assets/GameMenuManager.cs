using UnityEngine;
using UnityEngine.SceneManagement; // 引入SceneManager命名空间

public class SceneSwitcher : MonoBehaviour
{
    // 这个方法可以被按钮的点击事件调用
    public void SwitchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName); // 加载指定名称的场景
    }
}