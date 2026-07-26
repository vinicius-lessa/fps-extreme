# Protótipo MVP: Os 3 Cs (Character, Controls, Camera)

Começar pelos "3 Cs" é exatamente o que um programador sênior de jogos faria. Antes de arrancar braços e pernas, a movimentação e o tiro precisam parecer fluidos e precisos.

### 1. A Cápsula Base (Física e Movimentação)
Você não precisa de um personagem modelado ainda.
* **O Objeto:** Crie uma Cápsula 3D. Ela servirá como a "caixa de colisão" (hitbox) do seu jogador.
* **O Código de Movimento:** Crie um script para ler os inputs (`W, A, S, D`). Você vai transformar esses inputs em vetores de direção.
* **Gravidade e Pulo:** Aplique gravidade constante à cápsula. Para o pulo, verifique se a cápsula está encostando no chão (usando um pequeno raio de detecção na base dela) e, se estiver, aplique uma força instantânea no eixo Y (para cima) ao pressionar espaço.

### 2. A Câmera FPS (Mouse Look)
A câmera dita a perspectiva do jogador e onde ele está mirando.
* **Posicionamento:** Adicione uma Câmera 3D e coloque-a próxima ao topo da cápsula (onde ficaria a "cabeça"). Torne a câmera "filha" (child) da cápsula.
* **Rotação Horizontal (Yaw):** O movimento do mouse no eixo X deve girar a **Cápsula inteira** para os lados. Assim, o corpo sempre vira para onde você olha.
* **Rotação Vertical (Pitch):** O movimento do mouse no eixo Y deve girar **apenas a Câmera** para cima e para baixo. Lembre-se de limitar (clamp) essa rotação entre -90 e 90 graus, para que o jogador não consiga dar uma cambalhota com o pescoço.

### 3. O Viewmodel (Braços e Arma)
No FPS, a arma e os braços não ficam grudados no corpo do personagem, eles ficam "grudados" na tela.
* **Configuração:** Crie formas básicas no Blender (ou use cubos esticados na própria engine) para representar dois braços e uma arma poligonal simples.
* **Posicionamento:** Torne esses objetos "filhos" da Câmera. Dessa forma, não importa para onde você olhe ou ande, a arma estará sempre renderizada na frente da sua visão, acompanhando os movimentos verticais e horizontais perfeitamente.

### 4. O Sistema de Tiro (Raycasting)
O maior erro de iniciantes é fazer o tiro sair do cano da arma. Em jogos FPS responsivos, o tiro quase sempre sai do centro da tela.
* **A Lógica do Raycast:** Ao clicar com o mouse, programe a engine para disparar um "raio" invisível (Raycast) saindo exatamente do centro da Câmera, indo reto em direção ao infinito.
* **O Impacto:** O script deve retornar as informações do primeiro objeto que esse raio atingir (ponto exato de impacto, qual objeto foi, etc).

### 5. Os Bonecos de Treino (Targets)
* Crie cilindros ou cubos estáticos espalhados pelo mapa.
* Adicione um script simples chamado `Vida` ou `Target` a eles, com uma variável de HP e uma função `ReceberDano(valor)`.
* No script de tiro do jogador, se o Raycast colidir com um objeto que tenha o script `Target`, chame a função `ReceberDano`. Para feedback visual, você pode fazer o boneco de treino mudar de cor por uma fração de segundo ao ser atingido.
