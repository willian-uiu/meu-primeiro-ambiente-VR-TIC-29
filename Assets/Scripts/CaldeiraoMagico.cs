using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CaldeiraoMagico : MonoBehaviour
{
    [Header("Configurações Mágicas")]
    [Tooltip("Coloque aqui o arquivo de áudio do feitiço")]
    public AudioClip somDeFeitico;

    private AudioSource audioSource;

    void Start()
    {
        // Obtém o componente AudioSource que estará no mesmo GameObject
        audioSource = GetComponent<AudioSource>();
        
        // Evita que o som toque sozinho ao iniciar a cena
        audioSource.playOnAwake = false;
    }

    // Essa função é chamada automaticamente quando algo entra no "Trigger" do caldeirão
    private void OnTriggerEnter(Collider outroObjeto)
    {
        // Verifica se o objeto que caiu tem a tag "Ingrediente"
        // Isso evita que o som toque se a mão do jogador encostar no caldeirão
        if (outroObjeto.CompareTag("Ingrediente"))
        {
            // Verifica se o arquivo de áudio foi colocado no Inspector
            if (somDeFeitico != null)
            {
                // Toca o som do feitiço uma vez
                audioSource.PlayOneShot(somDeFeitico);
            }

            // Destrói o ingrediente após ele cair na água
            Destroy(outroObjeto.gameObject);
        }
    }
}
