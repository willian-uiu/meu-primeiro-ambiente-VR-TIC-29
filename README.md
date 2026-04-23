# Projeto Final: Meu Primeiro Ambiente VR 🥽
**Web 3.0 Residência em TIC 29 - Atividade Avaliativa**

## 1. Identificação
* **Nome Completo:** Willian Mamede (willian-uiu)
* **Turma / Residência:** TIC 29

## 2. Descrição do Projeto
Este projeto consiste na criação de um ambiente imersivo em Realidade Virtual (VR) utilizando Unity e o Meta XR SDK. O cenário é uma **Dungeon Medieval** estilizada (Low Poly), desenvolvida para demonstrar a aplicação prática de conceitos de física, colisão, hierarquia de objetos e interações espaciais.

## 3. Contexto e Objetivos no Metaverso
Este ambiente foi projetado com foco na área de **Entretenimento e Jogos** dentro do Metaverso. O objetivo é simular uma "Sala de Preparação" (Hub) de um jogo de RPG em Realidade Virtual, onde os jogadores podem interagir com itens antes de embarcarem em uma missão virtual. O espaço serve como um ponto de encontro imersivo que demonstra como objetos virtuais podem reagir de forma realista à presença e manipulação do usuário.

## 4. Interação Funcional em C#
Além da física padrão do Meta XR (agarrar e soltar objetos), o projeto conta com uma interação programada em C# para aumentar a imersão:
* **O Caldeirão Mágico (`CaldeiraoMagico.cs`):** Um script foi implementado utilizando a função `OnTriggerEnter`. Quando o jogador joga um item que possui a tag específica `Ingrediente` (como uma cenoura) dentro do caldeirão, o sistema detecta a colisão, emite um efeito sonoro de feitiço e utiliza o comando `Destroy()` para fazer o item ser "consumido" pela poção, desaparecendo da cena.

## 5. Processo de Criação e Dificuldades
O desenvolvimento foi dividido em etapas: montagem do cenário base (chão, paredes, iluminação), configuração do Meta XR SDK para testes via simulador, e por fim, a lógica de interação.
* **Desafios e Soluções:** 1. Durante os testes de colisão, itens incorretos (ou as próprias mãos do avatar) ativavam o som do caldeirão. Isso foi resolvido criando um sistema de validação por Tags (`Ingrediente`) no script C#.
  2. Houve um erro de Tracking do Headset (`Unable to set TrackingOrigin Floor`) ao testar o jogo direto no computador. O problema foi contornado configurando corretamente a ativação do XR Meta Simulator no XR Plugin Management da aba PC/Monitor.

## 6. Configuração Técnica
Para garantir a compatibilidade e o funcionamento adequado, o projeto foi configurado com:
* **Versão do Unity:** Unity 6000.3.10f1 LTS.
* **Plataforma de Build:** Android (focado em Meta Quest 2/3).
* **SDK:** Meta XR All-in-One SDK devidamente instalado e configurado.
* **Render Pipeline:** Universal Render Pipeline (URP).
* **XR Plugin Management:** Configurado com suporte a 'Oculus' na aba Android.

## 7. Estrutura do Repositório
Conforme os requisitos de entrega, este repositório contém apenas as pastas essenciais para a reconstrução do projeto no Unity:
* `/Assets`: Contém todos os modelos 3D, materiais, texturas, prefabs e scripts (`CaldeiraoMagico.cs`).
* `/Packages`: Gerenciamento de dependências e SDKs.
* `/ProjectSettings`: Configurações globais de build e física.
* `/Scenes`: Contém a cena principal do ambiente VR.

## 8. Elementos da Cena
O ambiente virtual conta com diversos objetos 3D posicionados de forma coerente:
* **Plano de Chão (construcao/chão):** Superfície navegável para o usuário.
* **Mesa de Madeira (ornamentos/mesa):** Suporte para itens interativos.
* **Objetos Interativos (acima_da_mesa):** Inclui caldeirão, cenouras e outros itens com `Box Colliders` e `Rigidbodys` configurados para interação física.
* **Sistema de Partículas (ornamentos/caldeirao):** Efeito visual de fumaça/poção mágica no caldeirão para maior imersão.
* **Iluminação e Skybox (ornamentos/tochas e velas):** Configuração de ambiente para atmosfera de dungeon.

## 9. Como Executar
1. Clone este repositório.
2. Abra o projeto no **Unity Hub** utilizando a versão recomendada (6000.3.10f1 LTS).
3. Certifique-se de que o **Build Settings** está definido para **Android**.
4. Para testes no PC (sem óculos), ative o **XR Meta Simulator** no menu da Unity para emular os controles e o headset via mouse e teclado.

## 10. Referências de Assets
* **LowPolyDungeonsLite:** Modelos de cenário (Paredes, chão e estruturas).
* **LowPolyMedievalProps:** Itens decorativos e interativos.
* **Real Stars Skybox:** Skybox do cenário.
* **Meta XR SDK:** Ferramentas de interação e simulação VR.
* **A.M.P. DEMO:** Asset de áudios de magias.