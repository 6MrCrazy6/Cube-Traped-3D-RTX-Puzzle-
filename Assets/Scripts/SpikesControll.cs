using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikesControll : MonoBehaviour
{
    public Material[] materials;
    private Renderer meshRenderer;
    private int currentMaterialIndex = 0;

    private float changeInterval = 3f;
    private float timer = 0f;

    private bool isActive = false;

    private void Start()
    {
        meshRenderer = GetComponent<Renderer>();
        if (materials.Length > 0)
            meshRenderer.material = materials[currentMaterialIndex];
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= changeInterval)
        {
            ChangeMaterial();
            timer = 0f;
        }
    }

    private void ChangeMaterial()
    {
        currentMaterialIndex = (currentMaterialIndex + 1) % materials.Length;
        meshRenderer.material = materials[currentMaterialIndex];

        SetTriggerState(!isActive);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Spike") && other.CompareTag("Player"))
        {
            if (currentMaterialIndex == 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

        if(this.CompareTag("Spike") && other.CompareTag("Cube"))
        {
            if(currentMaterialIndex == 0)
            {
                this.GetComponent<Collider>().isTrigger = false;
            }
        }
    }

    private void SetTriggerState(bool state)
    {
        GetComponent<Collider>().isTrigger = state;
    }
}