using UnityEngine;

public class ExitApplication : MonoBehaviour
{
    // 这个方法会在按钮点击时被调用
    public void QuitApplication()
    {
        // 在编辑器中
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // 在构建的应用中
        Application.Quit();
#endif
    }
}
