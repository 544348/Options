using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingBar : MonoBehaviour
{
    [SerializeField] private Slider loadSlider;
    [SerializeField] private string scene;
    private float time = 0f;

    public void Awake()
    {
        loadSlider.value = 0;
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(scene);
    }

    private void Update()
    {
        if (loadSlider.value != 100)
        {
            time += Time.deltaTime;
            loadSlider.value = Mathf.Lerp(0.85f, 115f, time / 3.5f);
        }

        else if (loadSlider.value == 100)
        {
            ChangeScene();
        }
    }
}
