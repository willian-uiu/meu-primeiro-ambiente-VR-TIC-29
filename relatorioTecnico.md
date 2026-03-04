# RELATÓRIO TÉCNICO - PROJETO VR NO METAVERSO
**Web 3.0 Residência em TIC 29 - Atividade Avaliativa**

---

## SEÇÃO 1 - IDENTIFICAÇÃO
* **Nome Completo:** Willian Mamede
* **Turma / Residência:** TIC 29
* **Limitação de Hardware Relatada:** Uso do 'XR Meta Simulator' para otimização de performance durante os testes no Unity Editor, permitindo o desenvolvimento fluido sem a dependência constante do hardware físico.

---

## SEÇÃO 2 - CONCEITO DO PROJETO
* **2.1 Nome do Projeto:** Minha casa medieval
* **2.2 Contexto e Objetivo no Metaverso:** Criar um ambiente de exploração medieval para demonstrar a aplicação de física e interações de "Grab" em VR, resolvendo a necessidade de prototipagem rápida de cenários interativos.
* **2.3 Descrição Geral do Ambiente Virtual:** Uma sala de dungeon em estilo Low Poly, composta por paredes de pedra, um caldeirão central com efeitos de partículas místicas, uma mesa de madeira para suporte de itens e objetos coletáveis com física ativa.

---

## SEÇÃO 3 - CONFIGURAÇÃO TÉCNICA DO PROJETO
* **3.1 Versão do Unity e Porquê:** Unity 6000.3.10f1 LTS, por ser a versão estável com suporte de longo prazo recomendada para o Meta XR SDK.
* **3.2 Instalação do Meta XR SDK (Passo a Passo):** 
  * Acesso ao Project Settings; 
  * Adição do escopo "Oculus"; 
  * Download e Importação do 'Meta XR All-in-One SDK'.
* **3.3 Configurações de Build para Android/Meta Quest:** 
  * Switch Platform para Android; 
  * Texture Compression: ASTC; 
  * Minimum API Level: Android 10 (Level 29) para compatibilidade com Quest 2/3.
* **3.4 Configuração do XR Plugin Management:** Seleção da opção 'Oculus' na aba Android para habilitar o suporte ao hardware.
* **3.5 Movimentação no PC (Editor):** Utilização do 'XR Meta Simulator' do Meta SDK para emular os controles e headset usando mouse e teclado.

---

## SEÇÃO 4 - ASSETS E ELEMENTOS DA CENA

### ASSET 1
* **Nome:** Caldeirão (Pot_01)
* **Tipo:** Objeto 3D / Prefab
* **Origem:** Asset Store (LowPolyDungeonsLite)
* **Função:** Elemento central de ambientação e suporte para o sistema de partículas.

### ASSET 2
* **Nome:** Cenoura (Food_02)
* **Tipo:** Objeto 3D Interativo
* **Origem:** Asset Store (LowPolyMedievalProps)
* **Função:** Item interativo utilizado para testar colisões, gravidade e o sistema de Grab no VR.

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
    * **Caldeirao**: Objeto central com sistema de partículas.
    * **Caixa**: Elemento de composição de cenário.
    * **Mesa**: Móvel de suporte para itens interativos.
    * **Velas / Tochas**: Fontes de luz pontuais para ambientação.

* **[--- ACIMA_DA_MESA ---]**
    * **Beterraba / Moedinha / Cenoura**: Itens com física ativa para interação de Grab.
    * **JarroGrande / Poção**: Objetos de cena interativos.

* **[--- CONSTRUCAO ---]**
    * **Teto / Chão**: Limites verticais da dungeon.
    * **Parede_esquerda / Parede_frente / Parede_direita / Parede_costas**: Estrutura modular do ambiente.

---

## SEÇÃO 6 - PLANEJAMENTO DO REPOSITÓRIO GITHUB
* **6.1 Nome do Repositório:** Projeto-Metaverso-TIC29-Willian
* **6.2 Estrutura de Pastas:** /Assets (Scripts, Prefabs e Materiais); /ProjectSettings (Configurações de Build); .gitignore (para ignorar /Library e /Temp).

---

## SEÇÃO 7 - PLANO DE EXECUÇÃO PASSO A PASSO
1. Instalação do Unity e criação do projeto 3D (URP).
2. Importação do Meta XR SDK via Package Manager.
3. Configuração do XR Origin e mãos do Player.
4. Montagem do cenário utilizando assets e ferramentas de snapping.
5. Aplicação de materiais, texturas e correção de shaders (URP conversion).
6. Configuração de componentes de física (Rigidbody) e colisores em objetos interativos.
7. Implementação de sistema de partículas para ambientação.
8. Teste final via XR Simulator e preparação para Build (.apk).

---

## SEÇÃO 6 - REFLEXÃO FINAL
* **8.1 Aprendizado:** Compreensão da hierarquia de objetos e da diferença entre 'Is Trigger' e colisões físicas, efeitos de partiulas no caldeirão, adição de textura nos objetos, dimensionamento do ambiente.
* **8.2 Dificuldades Previstas:** Ajustar o desempenho (Draw Calls) para garantir fluidez no hardware mobile do Quest e resolver incompatibilidades de shaders.
* **8.3 Melhorias Futuras:** Implementaria suporte a Multiplayer usando Photon 
(PUN2) para interação entre usuários, adição de áudio ao caminhar, áudio dos objetos ao caírem no chão com som espacial.