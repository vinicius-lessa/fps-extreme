# Esboço do Game Design Document (GDD)
**Projeto:** Shooter Multiplayer 3D Low Poly/Doodle com Mutilação Dinâmica

---

## 1. Fundamentos da Ideia (Visão do Game Designer)

### Qual é o principal objetivo do game?
O objetivo central é sobreviver e eliminar a equipe adversária (ou todos os outros jogadores), precisando se adaptar constantemente às limitações físicas extremas que seu personagem sofre durante o combate.

### Qual característica fará com que os jogadores não queiram parar de jogar? (Fator de Retenção)
O caos cômico e a jogabilidade emergente. Perder um braço ou uma perna não deve ser apenas uma penalidade, mas uma mudança drástica na forma de jogar. A frustração de quase morrer se transforma em diversão ao ver seu personagem pulando em uma perna só para tentar dar um tiro de escopeta, ou usando o próprio braço arrancado como arma corpo-a-corpo. Situações absurdas geram clipes engraçados (ótimo para YouTube e Twitch), o que atrai e retém jogadores.

### Qual inovação o jogo traz?
A maioria dos shooters trata a vida como uma barra de HP. Este jogo transforma o dano em um **estado dinâmico do avatar**. A inovação está em forçar o jogador a mudar sua estratégia de combate e movimentação em tempo real, dependendo de quais partes do corpo ele ainda possui.

---

## 2. Aspectos Gerais da Ideia

### Gênero, Público e Objetivo
* **Gênero:** Action Shooter (FPS/TPS), Comédia Sombria (Dark Comedy), Arena Multiplayer.
* **Público-Alvo:** Jovens e adultos (16+) que gostam de jogos competitivos rápidos, humor negro e ação caótica (fãs de jogos como *Team Fortress 2*, *Borderlands*, *Garry's Mod* ou *Paint the Town Red*).
* **Objetivo do Jogador:** Ser o último sobrevivente (Battle Royale) ou atingir a pontuação máxima de abates para o time (TDM).

### Regras e Desafios
* **Regras Core:** Dano na cabeça e tronco reduzem a vida principal e podem ser fatais. Dano nos membros causa mutilação. Armas de duas mãos exigem dois braços; perder um braço força o uso de armas secundárias ou reduz drasticamente a precisão. Perder as pernas força o jogador a rastejar (movimento lento, mas vira um alvo menor).
* **Desafios:** O maior desafio será dominar a movimentação e a mira sob condições adversas, além de aprender a usar o ambiente a seu favor quando a mobilidade for reduzida.

### Estilo Visual e Level Design
* **Level Design / Art Style:** O contraste é a alma do jogo. Ambientes vibrantes, super coloridos e com formas simples (Doodle ou Low Poly). O Level Design deve focar em verticalidade, pontos de estrangulamento e **armadilhas ambientais** (espinhos, serras, trituradores) para incentivar a mutilação criativa, não apenas por tiros.

### Tecnologia e Mecânicas
* **Core Mechanics:** Tiroteio fluido, sistema de dano modular avançado (dismemberment system), física ragdoll (corpos maleáveis) e movimentação adaptativa baseada no estado do corpo.
* **Tecnologias:**
  * **Modelagem 3D e Animação:** O **Blender** é a ferramenta ideal para criar personagens Low Poly e configurar o rigging modular (as separações onde os membros serão cortados).
  * **Engine e Programação:** **Unity** ou **Godot** são escolhas sólidas para lidar com física ragdoll e networking multiplayer. Godot é excelente para equipes pequenas. (Caso queira explorar tecnologias web para prototipagem via browser, PlayCanvas ou Three.js são opções, mas engines nativas entregam melhor performance para física e multiplayer).
* **Plataformas:** **PC (Steam)** é o melhor terreno de testes inicial para jogos indie multiplayer, focado em controles de teclado/mouse.

### Monetização
* **Modelo Sugerido:** **Free to Play (F2P)**. Jogos multiplayer independentes precisam de uma base grande de jogadores rapidamente para garantir partidas cheias. A receita viria da venda de cosméticos (skins absurdas, chapéus, efeitos de sangue, próteses hilárias como perna de pau ou braço robótico) e um Passe de Batalha (Battle Pass).
