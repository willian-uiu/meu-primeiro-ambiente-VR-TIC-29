# RELATÓRIO TÉCNICO - PROJETO VR NO METAVERSO
**Web 3.0 Residência em TIC 29 - Atividade Avaliativa**

---

## SEÇÃO 1 - IDENTIFICAÇÃO
* **Nome Completo:** Willian Mamede (willian-uiu)
* **Turma / Residência:** TIC 29
* **Limitação de Hardware Relatada:** Uso do 'XR Meta Simulator' para otimização de performance durante os testes no Unity Editor, permitindo o desenvolvimento fluido sem a dependência constante do hardware físico.

---

## SEÇÃO 2 - CONCEITO DO PROJETO
* **2.1 Nome do Projeto:** Minha Casa Medieval (Hub VR)
* **2.2 Contexto e Objetivo no Metaverso:** Criar um ambiente imersivo com foco em entretenimento e jogos (Hub de RPG) para demonstrar a aplicação de física, interações de "Grab" em VR e mecânicas programadas, resolvendo a necessidade de prototipagem rápida de cenários interativos no Metaverso.
* **2.3 Descrição Geral do Ambiente Virtual:** Uma sala de dungeon em estilo Low Poly, composta por paredes de pedra, um caldeirão central interativo com efeitos de partículas místicas e efeitos sonoros, uma mesa de madeira para suporte de itens e objetos coletáveis com física ativa (Rigidbodys).

---

## SEÇÃO 3 - CONFIGURAÇÃO TÉCNICA DO PROJETO
* **3.1 Versão do Unity e Porquê:** Unity 6000.3.10f1 LTS, por ser a versão estável com suporte de longo prazo recomendada para o Meta XR SDK.
* **3.2 Instalação do Meta XR SDK (Passo a Passo):** * Acesso ao Project Settings; 
  * Adição do escopo "Oculus"; 
  * Download e Importação do 'Meta XR All-in-One SDK'.
* **3.3 Configurações de Build para Android/Meta Quest:** * Switch Platform para Android; 
  * Texture Compression: ASTC; 
  * Minimum API Level: Android 10 (Level 29) para compatibilidade com Quest 2/3.
* **3.4 Configuração do XR Plugin Management:** Seleção da opção 'Oculus' na aba Android e ativação do simulador na aba PC/Mac.
* **3.5 Movimentação no PC (Editor):** Utilização do 'XR Meta Simulator' do Meta SDK para emular os controles e headset usando mouse e teclado.

---

## SEÇÃO 4 - ASSETS E ELEMENTOS DA CENA

### ASSET 1
* **Nome:** Caldeirão (Pot_01)
* **Tipo:** Objeto 3D interativo com Script C#
* **Origem:** Asset Store (LowPolyDungeonsLite)
* **Função:** Elemento central de ambientação, programado para reagir à colisão de ingredientes emitindo som e consumindo os itens.

### ASSET 2
* **Nome:** Cenoura (Food_02) / Itens Variados
* **Tipo:** Objeto 3D Interativo
* **Origem:** Asset Store (LowPolyMedievalProps)
* **Função:** Item com tag `Ingrediente` utilizado para testar colisões, gravidade, o sistema de Grab no VR e o Trigger do caldeirão.

### ASSET 3
* **Nome:** Sistema de Partículas (Fumaça Mística)
* **Tipo:** Efeito Visual (VFX)
* **Origem:** Nativo do Unity (Particle System)
* **Função:** Fornecer feedback visual imersivo e místico ao ambiente do caldeirão.

### ASSET 4
* **Nome:** Caixa (Box_02)
* **Tipo:** Objeto 3D / Prefab
* **Origem:** Asset Store (LowPolyDungeonsLite)
* **Função:** Servir de ornamentação para o ambiente, agregando a imersão.

### ASSET 5
* **Nome:** Áudio de Feitiço / Borbulhar
* **Tipo:** Efeito Sonoro (AudioClip)
* **Origem:** Asset Store / Bibliotecas de áudio Royalty-Free
* **Função:** Tocado via C# (`AudioSource.PlayOneShot`) para dar feedback sonoro imersivo ao jogador quando a poção é feita.

---

## SEÇÃO 5 - HIERARQUIA DE GAME OBJECTS
**Scene: SampleScene**

A hierarquia foi organizada de forma modular para facilitar a manutenção e o desenvolvimento, estruturada da seguinte forma:

* **[--- MANAGEMENT ---]**
    * **Global Volume**: Configurações de pós-processamento e efeitos visuais.

* **[--- PLAYER ---]**
    * **[BuildingBlock] Camera Rig**: Sistema de câmera e tracking do Meta Quest.
        * **TrackingSpace**: Espaço de rastreamento local.
        * **[BuildingBlock] OVRInteractionComprehensive**: Framework de interações XR.

* **[--- ORNAMENTOS ---]**
    * **Bandeirola_direita / Bandeirola_esquerda**: Elementos decorativos de parede.
    * **Caldeirao**: Objeto central contendo `ParticleSystem`, `BoxCollider` (Is Trigger), `AudioSource` e o script `CaldeiraoMagico.cs`.
    * **Caixa**: Elemento de composição de cenário.
    * **Mesa**: Móvel de suporte para itens interativos.
    * **Velas / Tochas**: Fontes de luz pontuais para ambientação.

* **[--- ACIMA_DA_MESA ---]**
    * **Beterraba / Moedinha / Cenoura**: Itens com física ativa (`Rigidbody`) e tag `Ingrediente`.
    * **JarroGrande / Poção**: Objetos de cena interativos.

* **[--- CONSTRUCAO ---]**
    * **Teto / Chão**: Limites verticais da dungeon.
    * **Parede_esquerda / Parede_frente / Parede_direita / Parede_costas**: Estrutura modular do ambiente.

---

## SEÇÃO 6 - PLANEJAMENTO DO REPOSITÓRIO GITHUB
* **6.1 Nome do Repositório:** Projeto-Metaverso-TIC29-Willian
* **6.2 Estrutura de Pastas:** * `/Assets` (Contém Scripts C#, Prefabs, Áudios e Materiais);
  * `/ProjectSettings` (Configurações de Build);
  * `/Packages` (Dependências do projeto);
  * `/Scenes` (Cena principal funcional);
  * `.gitignore` (Para impedir o envio de pastas pesadas e desnecessárias como `/Library` e `/Temp`).

---

## SEÇÃO 7 - PLANO DE EXECUÇÃO PASSO A PASSO
1. Instalação do Unity e criação do projeto 3D (URP).
2. Importação do Meta XR SDK via Package Manager e configuração do XR Origin/Mãos.
3. Montagem do cenário utilizando assets Low Poly e ferramentas de snapping.
4. Aplicação de materiais, texturas e correção de shaders (URP conversion).
5. Configuração de componentes de física (`Rigidbody`) e colisores em objetos interativos.
6. Criação do Script em C# (`CaldeiraoMagico.cs`) usando a função `OnTriggerEnter` e o comando `Destroy()`.
7. Implementação do sistema de partículas e do `AudioSource` para feedback na interação.
8. Configuração de Tags para evitar colisões indesejadas no caldeirão.
9. Teste final via XR Simulator, solução de erros de Tracking, e preparação para Build (.apk).

---

## SEÇÃO 8 - REFLEXÃO FINAL
* **8.1 Aprendizado:** Compreensão profunda da hierarquia de objetos e da diferença entre colisões físicas e zonas de detecção ('Is Trigger'). Apreendi também sobre a integração de scripts C# no VR (detecção de objetos por Tags e comandos de destruição), além de criar efeitos de partículas e usar áudios espaciais e direcionais no Unity.
* **8.2 Dificuldades Superadas e Previstas:** * *Superadas:* Resolução do erro de `TrackingOrigin` ao testar via Editor configurando o simulador no XR Plugin Management (PC/Mac). Resolução de bugs no script onde a própria mão ativava o som, consertado com o uso inteligente de `Tags`.
  * *Previstas:* Ajustar o desempenho (Draw Calls) para garantir fluidez no hardware mobile do Quest e lidar com otimização de texturas futuras.
* **8.3 Melhorias Futuras:** Implementaria suporte a Multiplayer usando Photon (PUN2/Fusion) para interação entre usuários em tempo real, adição de áudios de passos ao caminhar e a emissão de som físico dinâmico quando os objetos colidem com o chão.