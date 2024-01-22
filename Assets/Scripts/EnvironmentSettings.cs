using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnvironmentSettings : MonoBehaviour
{
    public Material skyboxMaterial;

    private void OnEnable()
    {
        ApplyEnvironmentSettings();
    }

    private void ApplyEnvironmentSettings()
    {
        if (PlayerPrefs.HasKey("GameSkybox"))
        {
            string skyboxName = PlayerPrefs.GetString("GameSkybox");
            Material newSkybox = Resources.Load<Material>(skyboxName);

            if (newSkybox != null)
            {
                RenderSettings.skybox = newSkybox;
                RenderSettings.ambientIntensity = 1.1f;
                DynamicGI.UpdateEnvironment();
            }
            else
            {
                Debug.LogWarning("Skybox material not found.");
            }
        }
    }
}
