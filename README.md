# Projeto Final: Meu Primeiro Ambiente VR 🥽
**Web 3.0 Residência em TIC 29 - Atividade Avaliativa**

## 1. Identificação
* **Nome Completo:** Willian Mamede (neg0uiu)
* **Turma / Residência:** TIC 29

## 2. Descrição do Projeto
Este projeto consiste na criação de um ambiente imersivo em Realidade Virtual (VR) utilizando Unity e o Meta XR SDK. O cenário é uma **Dungeon Medieval** estilizada (Low Poly), desenvolvida para demonstrar a aplicação prática de conceitos de física, colisão, hierarquia de objetos e interações espaciais.

## 3. Configuração Técnica
Para garantir a compatibilidade e o funcionamento adequado, o projeto foi configurado com:
* **Versão do Unity:** Unity 6000.3.10f1 LTS.
* **Plataforma de Build:** Android (focado em Meta Quest 2/3).
* **SDK:** Meta XR All-in-One SDK devidamente instalado e configurado.
* **Render Pipeline:** Universal Render Pipeline (URP).
* **XR Plugin Management:** Configurado com suporte a 'Oculus' na aba Android.

## 4. Estrutura do Repositório
Conforme os requisitos de entrega, este repositório contém apenas as pastas essenciais para a reconstrução do projeto:
* `/Assets`: Contém todos os modelos 3D, materiais, texturas, prefabs e scripts.
* `/Packages`: Gerenciamento de dependências e SDKs.
* `/ProjectSettings`: Configurações globais de build e física.

## 5. Elementos da Cena
O ambiente virtual conta com mais de 5 objetos 3D posicionados de forma coerente:
* **Plano de Chão (construcao/chão):** Superfície navegável para o usuário.
* **Mesa de Madeira (ornamentos/mesa):** Suporte para itens interativos.
* **Objetos Interativos (acima_da_mesa):** Inclui caldeirão, cenouras e outros itens com `Box Colliders` e `Rigidbodys` configurados para interação física.
* **Sistema de Partículas (ornamentos/caldeirao):** Efeito visual de fumaça/poção mágica no caldeirão para maior imersão.
* **Iluminação e Skybox (ornamentos/tochas(1, 2, 3) e velas):** Configuração de ambiente para atmosfera de dungeon.

## 6. Como Executar
1. Clone este repositório.
2. Abra o projeto no **Unity Hub** utilizando a versão recomendada.
3. Certifique-se de que o **Build Settings** está definido para **Android**.
4. Para testes no PC (sem óculos), utilize o **XR Meta Simulator** incluído no SDK para emular os controles e o headset via mouse e teclado.

## 7. Referências de Assets
* **LowPolyDungeonsLite:** Modelos de cenário (Paredes, chão e estruturas).
* **LowPolyMedievalProps:** Itens decorativos e interativos.
* **Real Stars Skybox:** Skybox do cenário.
* **Meta XR SDK:** Ferramentas de interação e simulação VR.